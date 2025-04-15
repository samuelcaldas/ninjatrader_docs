//
// Copyright (C) 2015, NinjaTrader LLC <www.ninjatrader.com>
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
	public class SampleMultiColoredPlot : Indicator
	{
		private int 				period;	// Default setting for the SMA's period
		private Series<double>		middle;	// This DataSeries stores the average of a upper and lower SMA

		protected override void OnStateChange()
		{
			if(State == State.SetDefaults)
			{
				AddPlot(Brushes.SkyBlue, "Upper");
				AddPlot(Brushes.SkyBlue, "Lower");
				// Increase the default widths of the plots
				Plots[0].Width 		= 2;
				Plots[1].Width 		= 2;
				Calculate 			= Calculate.OnBarClose;
				IsOverlay 			= true;
				Name				= "Sample multi-colored Plot";
				Period 				= 14;
			}
			else if(State == State.Configure)
			{
				// Initialize the DataSeries.
				middle = new Series<double>(this);
			}
		}

		protected override void OnBarUpdate()
		{
			// Check that we have enough bars on our chart before processing
			if(CurrentBar < Period) 
				return;
			
			// Set the plots and the DataSeries.
 			Values[0][0] 	= SMA(High, Period)[0];
			Values[1][0]	= SMA(Low, Period)[0];
			middle[0] 		= (SMA(Low, Period)[0] + SMA(High, Period)[0]) / 2;
			
			// If the average of the two plots is rising, change the plot colors.
			if (IsRising(middle))
			{
				// The indexers for PlotBrushes are PlotBrushes[plot index][bars back], so the below code would set 
				// the first plot (Upper) to black and the second plot (Lower) to green.
				PlotBrushes[0][0] = Brushes.Black;
				PlotBrushes[1][0] = Brushes.LimeGreen;
			}
			// If the average is falling, change the plot colors.
			else if (IsFalling(middle))
			{
				PlotBrushes[0][0] = Brushes.Red;
				PlotBrushes[1][0] = Brushes.Black;
			}
			// If the average remains the same, set both plots to the same color.
			else
			{
				PlotBrushes[0][0] = Brushes.Blue;
				PlotBrushes[1][0] = Brushes.Blue;
			}
		}

		#region Properties
		[Range(1, int.MaxValue), NinjaScriptProperty]
		[Display(ResourceType = typeof(Custom.Resource), Name = "Period", GroupName = "NinjaScriptParameters", Order = 0)]
		public int Period
		{ get; set; }
		#endregion
	}
}

#region NinjaScript generated code. Neither change nor remove.

namespace NinjaTrader.NinjaScript.Indicators
{
	public partial class Indicator : NinjaTrader.Gui.NinjaScript.IndicatorRenderBase
	{
		private SampleMultiColoredPlot[] cacheSampleMultiColoredPlot;
		public SampleMultiColoredPlot SampleMultiColoredPlot(int period)
		{
			return SampleMultiColoredPlot(Input, period);
		}

		public SampleMultiColoredPlot SampleMultiColoredPlot(ISeries<double> input, int period)
		{
			if (cacheSampleMultiColoredPlot != null)
				for (int idx = 0; idx < cacheSampleMultiColoredPlot.Length; idx++)
					if (cacheSampleMultiColoredPlot[idx] != null && cacheSampleMultiColoredPlot[idx].Period == period && cacheSampleMultiColoredPlot[idx].EqualsInput(input))
						return cacheSampleMultiColoredPlot[idx];
			return CacheIndicator<SampleMultiColoredPlot>(new SampleMultiColoredPlot(){ Period = period }, input, ref cacheSampleMultiColoredPlot);
		}
	}
}

namespace NinjaTrader.NinjaScript.MarketAnalyzerColumns
{
	public partial class MarketAnalyzerColumn : MarketAnalyzerColumnBase
	{
		public Indicators.SampleMultiColoredPlot SampleMultiColoredPlot(int period)
		{
			return indicator.SampleMultiColoredPlot(Input, period);
		}

		public Indicators.SampleMultiColoredPlot SampleMultiColoredPlot(ISeries<double> input , int period)
		{
			return indicator.SampleMultiColoredPlot(input, period);
		}
	}
}

namespace NinjaTrader.NinjaScript.Strategies
{
	public partial class Strategy : NinjaTrader.Gui.NinjaScript.StrategyRenderBase
	{
		public Indicators.SampleMultiColoredPlot SampleMultiColoredPlot(int period)
		{
			return indicator.SampleMultiColoredPlot(Input, period);
		}

		public Indicators.SampleMultiColoredPlot SampleMultiColoredPlot(ISeries<double> input , int period)
		{
			return indicator.SampleMultiColoredPlot(input, period);
		}
	}
}

#endregion
