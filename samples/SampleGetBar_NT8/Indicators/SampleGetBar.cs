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

// This namespace holds all indicators and is required. Do not change it.
namespace NinjaTrader.NinjaScript.Indicators
{
    public class SampleGetBar : Indicator
    {
        private int 		sMAPeriod; 			// Default setting for sMAPeriod
		private int			barsAgo;  			// Variable to hold a bars ago value.
		private DateTime	timeOfInterest;   	// DateTime object to hold the time we're interested in.

        protected override void OnStateChange()
        {
			if(State == State.SetDefaults)
			{
	            Description					= @"Sample Getting a value from an indicator for a specific time";
				Name						= "Sample GetBar";
				Calculate					= Calculate.OnBarClose;
				IsOverlay					= true;
				DisplayInDataBox			= true;
				DrawOnPricePanel			= true;
				DrawHorizontalGridLines		= true;
				DrawVerticalGridLines		= true;
				PaintPriceMarkers			= true;
				ScaleJustification			= NinjaTrader.Gui.Chart.ScaleJustification.Right;
				sMAPeriod					= 14;
				barsAgo 					= 0;
				AddPlot(Brushes.Orange, "SMAPlot");
			}
        }

        protected override void OnBarUpdate()
        {
			// Plots the SMA indicator.
			SMAPlot[0] = SMA(sMAPeriod)[0];
			
			/* This sample assumes instrument sessions that go from Monday-Friday and not the weekends.
			   If you are using an instrument that has weekend trading sessions like the ES futures, please be aware that the logic presented will need to be
			   modified to reflect the trading sessions for your particular instrument.
			   Here, timeOfInterest is reset once per day at session break. */
			if (Bars.IsFirstBarOfSession && IsFirstTickOfBar)
			{
				DateTime holdDT = new DateTime(Time[0].Year, Time[0].Month, Time[0].Day, 9, 30, 0);
				/* If the day is Monday, and we want the value from Friday, we must subtract 3 days from the current date.
				   If the day is Tuesday-Friday, just subtract one day. */
				if (Time[0].DayOfWeek == DayOfWeek.Monday)
					timeOfInterest = holdDT.AddDays(-3);
				else
					timeOfInterest = holdDT.AddDays(-1);
			}

			/* Determine the number of bars ago it would take to access the 9:30AM bar for the previous trading day by pulling the bars index and subtracting from the CurrentBar.
			   GetBar() returns returns the first bar that matches the time stamp for the 9:30AM bar if it exists or the number for the first bar after 9:30AM 
			   if there isn’t a specific bar with the exact 9:30AM timestamp (e.g. tick-based bars). With tick bars, it is possible 
			   for many bars to have the same exact time stamp. In this case, the first bar of all the bars with the same timestamp is returned.*/
			barsAgo = CurrentBar - Bars.GetBar(timeOfInterest);
			
			/* If GetBar returns 0, the time you are looking for would either be the current bar or at some time after the current bar.
			   Also, make sure there are enough bars to draw the line 10 bars back. */
			if (barsAgo != 0 && CurrentBar > 10)
			{
				// Draw a line with the value of the SMA the correct number of bars ago.
				Draw.Line(this, "yesterday SMA", true, 10, SMAPlot[barsAgo], 0, SMAPlot[barsAgo], Brushes.Red, DashStyleHelper.Solid, 5); 
				//DrawLine("yesterday SMA", false, 10, SMAPlot[barsAgo], 0, SMAPlot[barsAgo], Color.Black, DashStyle.Solid, 2);
            }
        }

        #region Properties
		
			[Browsable(false)]
			[XmlIgnore()]
			public Series<double> SMAPlot
			{
				get { return Values[0]; }
			}
		
     		[Range(1, int.MaxValue), NinjaScriptProperty]
			[Display(ResourceType = typeof(Custom.Resource), Name = "SMAPeriod", GroupName = "NinjaScriptParameters", Order = 0)]
			public int SMAPeriod
			{ get { return sMAPeriod;} set{ sMAPeriod = value;} }

        #endregion
    }
}

#region NinjaScript generated code. Neither change nor remove.

namespace NinjaTrader.NinjaScript.Indicators
{
	public partial class Indicator : NinjaTrader.Gui.NinjaScript.IndicatorRenderBase
	{
		private SampleGetBar[] cacheSampleGetBar;
		public SampleGetBar SampleGetBar(int sMAPeriod)
		{
			return SampleGetBar(Input, sMAPeriod);
		}

		public SampleGetBar SampleGetBar(ISeries<double> input, int sMAPeriod)
		{
			if (cacheSampleGetBar != null)
				for (int idx = 0; idx < cacheSampleGetBar.Length; idx++)
					if (cacheSampleGetBar[idx] != null && cacheSampleGetBar[idx].SMAPeriod == sMAPeriod && cacheSampleGetBar[idx].EqualsInput(input))
						return cacheSampleGetBar[idx];
			return CacheIndicator<SampleGetBar>(new SampleGetBar(){ SMAPeriod = sMAPeriod }, input, ref cacheSampleGetBar);
		}
	}
}

namespace NinjaTrader.NinjaScript.MarketAnalyzerColumns
{
	public partial class MarketAnalyzerColumn : MarketAnalyzerColumnBase
	{
		public Indicators.SampleGetBar SampleGetBar(int sMAPeriod)
		{
			return indicator.SampleGetBar(Input, sMAPeriod);
		}

		public Indicators.SampleGetBar SampleGetBar(ISeries<double> input , int sMAPeriod)
		{
			return indicator.SampleGetBar(input, sMAPeriod);
		}
	}
}

namespace NinjaTrader.NinjaScript.Strategies
{
	public partial class Strategy : NinjaTrader.Gui.NinjaScript.StrategyRenderBase
	{
		public Indicators.SampleGetBar SampleGetBar(int sMAPeriod)
		{
			return indicator.SampleGetBar(Input, sMAPeriod);
		}

		public Indicators.SampleGetBar SampleGetBar(ISeries<double> input , int sMAPeriod)
		{
			return indicator.SampleGetBar(input, sMAPeriod);
		}
	}
}

#endregion