// 
// Copyright (C) 2015, NinjaTrader LLC <www.ninjatrader.com>.
// NinjaTrader reserves the right to modify or overwrite this NinjaScript component with each release.
//
#region Using declarations
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Xml.Serialization;
using NinjaTrader.NinjaScript.Indicators;
using NinjaTrader.Cbi;
using NinjaTrader.NinjaScript.DrawingTools; 
#endregion
// This namespace holds all strategies and is required. Do not change it.
namespace NinjaTrader.NinjaScript.Strategies
{
    public class SampleATMPnL : Strategy
    {
		private string	atmStrategyId			= string.Empty;	// Variable to hold the atmStrategyId
		private string	orderId					= string.Empty; // Variable to hold the orderId
		private double	realizedProfitLoss		= 0;			// Variable to hold a specific ATM strategy's profit/loss
		private double	unrealizedProfitLoss	= 0;			// Variable to hold a strategy's unrealized profit/loss
		private double	totalPL					= 0;			// Variable to hold the running total of realized profit/loss
		private bool   	isAtmStrategyCreated 	= false;
		
        protected override void OnStateChange()
        {
			if(State == State.SetDefaults)
			{
            	Calculate = Calculate.OnBarClose;
			}
			
			else if(State == State.Historical)
			{
				/* HELP DOCUMENTATION REFERENCE: Please see the Help Guide section "Using ATM Strategies"
			    Make sure this strategy does not execute against historical data */
				return;
			}
        }

        protected override void OnBarUpdate()
        {
			/* Submits an entry limit order at the current low price to initiate an ATM Strategy if both order id and strategy id are in a reset state
               **** YOU MUST HAVE AN ATM STRATEGY TEMPLATE NAMED 'AtmStrategyTemplate' CREATED IN NINJATRADER (SUPERDOM FOR EXAMPLE) FOR THIS TO WORK ****/
			if (orderId.Length == 0 && atmStrategyId.Length == 0 && Close[0] > Open[0] && State == State.Realtime)
			{
				atmStrategyId = GetAtmStrategyUniqueId();
				orderId = GetAtmStrategyUniqueId();
				//AtmStrategyCreate(OrderAction.Buy, OrderType.Market, 0, 0, TimeInForce.Day, orderId, "AtmStrategyTemplate", atmStrategyId);
				AtmStrategyCreate(OrderAction.Buy, OrderType.Market, 0, 0, TimeInForce.Day, orderId, "AtmStrategyTemplate", atmStrategyId, 
				(atmCallbackErrorCode, atmCallbackId) => {
					if(atmCallbackId == atmStrategyId)
                    	if (atmCallbackErrorCode == Cbi.ErrorCode.NoError)
                        	isAtmStrategyCreated = true; 
				});
			}

			// Check for a pending entry order
			if (orderId.Length > 0)
			{
				string[] status = GetAtmStrategyEntryOrderStatus(orderId);
                
				// If the status call can't find the order specified, the return array length will be zero otherwise it will hold elements
				if (status.GetLength(0) > 0)
				{
					// If the order state is terminal, reset the order id value
					if (status[2] == "Filled" || status[2] == "Cancelled" || status[2] == "Rejected")
						orderId = string.Empty;
				}
			} // If the strategy has terminated reset the strategy id after doing some profit/loss calculations.
			else if (atmStrategyId.Length > 0 && GetAtmStrategyMarketPosition(atmStrategyId) == Cbi.MarketPosition.Flat)
			{
				/* Retrieve the profit or loss from the just-closed ATM strategy and round it to the nearest tick. This only updates after all targets or stops are filled (the position is flat).
				   GetAtmStrategyRealizedProfitLoss can return values such as 99.9999999998 or 100.00000000012, which would be rounded to 100. */
				realizedProfitLoss = Instrument.MasterInstrument.RoundToTickSize(GetAtmStrategyRealizedProfitLoss(atmStrategyId));
				
				// Sum the profit to the running total.
				totalPL = totalPL + realizedProfitLoss;
				
				// Reset the strategy id and unrealized profit/loss variables because the strategy is now terminated.
				atmStrategyId = string.Empty;
				unrealizedProfitLoss = 0;
			}
			
			// Make sure atmStrategyId contains a value or GetAtmStrategyUnrealizedProfitLoss() will throw an error.
			if (atmStrategyId.Length > 0)
			{
				unrealizedProfitLoss = Instrument.MasterInstrument.RoundToTickSize(GetAtmStrategyUnrealizedProfitLoss(atmStrategyId));
			}
			
			// Concatenate all the information and then draw it onto the chart. '\r\n' basically just means new line.
			string textToDraw = "Unrealized P/L: " + unrealizedProfitLoss.ToString() + "\r\nRealized P/L: " + totalPL.ToString() + "\r\nLast Strategy's P/L: " + realizedProfitLoss.ToString();
			//Draw.TextFixed(this, "P/L information", textToDraw, TextPosition.BottomRight);
				
        }
    }
}
