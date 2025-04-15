// 
// Copyright (C) 2015, NinjaTrader LLC <www.ninjatrader.com>
// NinjaTrader reserves the right to modify or overwrite this NinjaScript component with each release.
//
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


// This namespace holds all strategies and is required. Do not change it.
namespace NinjaTrader.NinjaScript.Strategies
{
	public class SampleMultiTimeFrameOrders : Strategy
	{
		protected override void OnStateChange()
		{
			if (State == State.SetDefaults)
			{
				Calculate 		= Calculate.OnBarClose;
				Name			= "Sample multi time frame orders";
			}
			else if (State == State.Configure)
			{
				// We call AddDataSeries() from the Configure state
				
				// Add a 5 minute Bars object to the strategy
				AddDataSeries(Data.BarsPeriodType.Minute, 5);  // BarsArray[1]
				
				// Add a 15 minute Bars object to the strategy
				AddDataSeries(Data.BarsPeriodType.Minute, 15); // BarsArray[2]
			}
		}

		protected override void OnBarUpdate()
		{
			// Test for enough bars in each data set.
			if (CurrentBars[0] < BarsRequiredToTrade || CurrentBars[1] < BarsRequiredToTrade || CurrentBars[2] < BarsRequiredToTrade)
				return;
			/* OnBarUpdate() method will execute this portion of the code when incoming ticks are on the
			secondary bar object. */
			if (BarsInProgress == 1)
			{
				/* Checks if the 5 period SMA is decreasing in the secondary bar series (5min) and if it is below the 10
				period SMA in the tertiary bar series (15min). */
				if (SMA(BarsArray[1],5)[0] < SMA(BarsArray[1],5)[1] && SMA(BarsArray[1],5)[0] < SMA(BarsArray[2], 10)[0])
				{
					/* Exit the long position entered from the 15min bar object on a more granular time period.
					This allows for more control in the management of your positions and can be used to improve
					exit timing of your trades. */
					ExitLong(0,1,"Exit Long from 5min", "Enter Long from 15min");
				}
			}
			else if (BarsInProgress == 2)
			{
				/* OnBarUpdate() method will execute this portion of the code when incoming ticks are on the
				tertiary bar object (15min). */

				// Checks if the 25 period SMA is greater than the 50 period SMA on the 15min.
				if (SMA(BarsArray[2],25)[0] > SMA(BarsArray[2],50)[0] && (BarsSinceExitExecution(1,"Exit Long from 5min",0) > 1 || BarsSinceExitExecution(1,"Exit Long from 5min",0) == -1))
				{
					/* Enter long for 1 contract on the 15min bar object based on the barsInProgress parameter.
					A value of 0=primary bars, 1=secondary bars, 2=tertiary bars */
					EnterLong(0, 1, "Enter Long from 15min");
				}
			}
		}

		#region Properties
		#endregion
	}
}
