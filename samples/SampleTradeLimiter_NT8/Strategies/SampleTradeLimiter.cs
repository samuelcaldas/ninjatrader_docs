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
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Xml.Serialization;
using NinjaTrader.Cbi;
using NinjaTrader.Gui;
using NinjaTrader.Gui.Chart;
using NinjaTrader.Gui.SuperDom;
using NinjaTrader.Data;
using NinjaTrader.NinjaScript;
using NinjaTrader.Core.FloatingPoint;
using NinjaTrader.NinjaScript.DrawingTools;
#endregion

// This namespace holds all strategies and is required. Do not change it.
namespace NinjaTrader.NinjaScript.Strategies
{
	public class SampleTradeLimiter : Strategy
	{
		private int aDXPeriod 		= 14; // Default setting for ADXPeriod
		private int tradeCounter	= 0;  // This variable represents the number of trades taken per day.
		private int maxTrades		= 5;  // This variable sets the maximum number of trades to take per day.

		protected override void OnStateChange()
		{
			if(State == State.SetDefaults)
			{
				ADXPeriod	= 14;
				MaxTrades	= 5;
				Calculate 	= Calculate.OnBarClose;
				Name		= "Sample Trade Limiter";
			}
			else if(State == State.Configure)
			{
				// Add the current day open, high, low indicator to visually see entry conditions.
				AddChartIndicator(CurrentDayOHL());
			}
		}

		protected override void OnBarUpdate()
		{
			// Make sure there are enough bars.
			if (CurrentBar < 1)
				return;
			
			// Reset the tradeCounter value at the first tick of the first bar of each session.
			if (Bars.IsFirstBarOfSession && IsFirstTickOfBar)
			{
				Print("resetting tradeCounter");
				tradeCounter = 0;	
			}
			
			// If the amount of trades is less than the permitted value and the position is flat, go on to the next set of conditions.
			if (tradeCounter < MaxTrades && Position.MarketPosition == MarketPosition.Flat)
			{
				/* If a new low is made, enter short and increase the trade count by 1.
				In C#, ++ means increment by one. An equilivent would be tradeCounter = tradeCounter + 1; */
				if (CurrentDayOHL().CurrentLow[0] < CurrentDayOHL().CurrentLow[1])
				{
					tradeCounter++;
					EnterShort();
				}
				// If a new high is made, enter long and increase the trade count by 1.
				else if (CurrentDayOHL().CurrentHigh[0] > CurrentDayOHL().CurrentHigh[1])
				{
					tradeCounter++;
					EnterLong();
				}
			}
			
			/* Exit a position if "the trend has ended" as indicated by ADX.
			If the current ADX value is less than the previous ADX value, the trend strength is weakening. */
			if (ADX(ADXPeriod)[0] < ADX(ADXPeriod)[1] && Position.MarketPosition != MarketPosition.Flat)
			{
				if (Position.MarketPosition == MarketPosition.Long)
					ExitLong();
				else if (Position.MarketPosition == MarketPosition.Short)
					ExitShort();
			}
		}

		#region Properties
		[Display(GroupName="Parameters", Description="Period for the ADX indicator")]
		public int ADXPeriod
		{
			get { return aDXPeriod; }
			set { aDXPeriod = Math.Max(1, value); }
		}

		[Display(GroupName="Parameters", Description="Maximum number of trades to take per day.")]
		public int MaxTrades
		{
			get { return maxTrades; }
			set { maxTrades = Math.Max(1, value); }
		}
		#endregion
	}
}