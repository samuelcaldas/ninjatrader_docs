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
using NinjaTrader.NinjaScript.Indicators;
using NinjaTrader.NinjaScript.DrawingTools;
#endregion

//This namespace holds Strategies in this folder and is required. Do not change it. 
namespace NinjaTrader.NinjaScript.Strategies
{
	public class SampleIsLiveUntilCanceled : Strategy
	{
		private int		fast;
		private int		slow;
		private double	entryPrice;
		
		protected override void OnStateChange()
		{
			if (State == State.SetDefaults)
			{
				Description					= @"Enter the description for your new custom Strategy here.";
				Name						= "Sample Live Until Canceled";
				Calculate					= Calculate.OnBarClose;
				EntryHandling				= EntryHandling.UniqueEntries;
				BarsRequiredToTrade			= 20;
				IsExitOnSessionCloseStrategy    = true;
          		ExitOnSessionCloseSeconds       = 30;
				IsFillLimitOnTouch			= false;
				MaximumBarsLookBack			= MaximumBarsLookBack.TwoHundredFiftySix;
				OrderFillResolution			= OrderFillResolution.Standard;
				Slippage					= 0;
				StartBehavior				= StartBehavior.WaitUntilFlat;
				TraceOrders					= false;
				Fast 						= 10;
				Slow 						= 25;	
				entryPrice					= 0;
			}
			else if (State == State.Configure)
			{
				AddChartIndicator(SMA(Fast));
				AddChartIndicator(SMA(Slow));
			}
		}

		protected override void OnBarUpdate()
		{
			/* 	This code sample demonstrates the difference between orders that have liveUntilCancelled = true and false.
			The default setting for limit orders is for the orders to be cancelled if the conditions that caused the order are no longer true (liveUntilCancelled = false).
			Lets say in OnBarUpdate() the entry condition is if (Close[0] >= Close[1]). If the condition evaluates to true, or the current close is greater than the previous close,
			the order will be placed. Then on the next bar, the close is lower then the previous close so the conditions are no longer true. Thus, the limit order would be cancelled.
			For more information on this auto-expire behavior, please see the “Strategy - Managed Approach” section from this link:
			http://www.ninjatrader.com/support/helpGuides/nt8/en-us/index.html?managed_approach.htm
			In another example, we have the same entry conditions. This time, there are 5 bars that all close higher than the previous close.
			The order would not be cancelled for any of those five bars because the condition remains true. Until a bar closes lower, the order will not be cancelled.
			
			There is an overload for stop and limit order methods that includes a bool flag named "liveUntilCancelled". This flag is what will decide how the order needs to be cancelled.
			The overload is this: EnterLongLimit(int barsInProgressIndex, bool liveUntilCancelled, int quantity, double limitPrice, string signalName);
			For more information, please visit http://www.ninjatrader.com/support/helpGuides/nt8/en-us/index.html?enterlonglimit.htm. */
						
			// Get a price for entries.
			entryPrice = Low[0] - 2 * TickSize;
			
			/* CrossAbove/Below conditions usually do not evaluate to true for several bars in a row.
			   If we submitted with liveUntilCancelled = false our order would be cancelled on the next bar as the condition is no longer true.
			   If we wanted to persist our order we would want to use liveUntilCancelled = true. */
			if (CrossAbove(SMA(Fast), SMA(Slow), 1))
			{
			/* 	This order is kept alive until explicitly cancelled. For information on how to explicitly cancel this order please see this reference sample:
				!!! Need updated potential forum link here !!! */
				EnterLongLimit(0, true, DefaultQuantity, entryPrice, "live until cancelled long");
			}
			
			if (Close[0] > Open[0])
			{
				// This EnterLongLimit is cancelled if the conditions that caused it are no longer true. It is then resubmitted upon the conditions being true again.
				EnterLongLimit(0, false, DefaultQuantity, entryPrice, "long order to be resubmitted");
			}
			
			if (CrossBelow(SMA(Fast), SMA(Slow), 1))
				ExitLong();
		}
		
		#region Properties
		
		[Range(1, int.MaxValue), NinjaScriptProperty]
		[Description("Period for fast MA")]
		[Category("Parameters")]
		public int Fast
		{
			get { return fast; }
			set { fast = value; }
		}

		[Range(1, int.MaxValue), NinjaScriptProperty]
		[Description("Period for slow MA")]
		[Category("Parameters")]
		public int Slow
		{
			get { return slow; }
			set { slow = value; }
		}
		
		#endregion
	}
}