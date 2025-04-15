// 
// Copyright (C) 2015, NinjaTrader LLC <www.ninjatrader.com>.
// NinjaTrader reserves the right to modify or overwrite this NinjaScript component with each release.
//
#region Declarations
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
     public class SampleCustomSeries : Indicator
     {		
		// Defines the Series object
		private Series<double> myDoubleSeries;

        protected override void OnStateChange()
        {
			if (State == State.SetDefaults)
			{
				// Adds a plot to our NinjaScript Indicator
	            AddPlot(new Stroke(Brushes.Orange, 1), PlotStyle.Bar, "Average Range");
				
				Period					= 5;
				Name					= "Sample custom series";
	            Calculate				= Calculate.OnBarClose;
	            IsOverlay				= false;
			}
			
			else if (State == State.DataLoaded)
			{
				// Create a new Series object and assign it to the variable myDoubleSeries declared in the ‘Variables’ region above
				myDoubleSeries = new Series<double>(this);
			}
        }

        protected override void OnBarUpdate()
        {
			/* To set values to our Series object we use the [] method. Here we are setting the DataSeries
			object for the current bar to take on the absolute value of the difference between the current bar's
			open and close. */
			
			myDoubleSeries[0] = Math.Abs(Close[0] - Open[0]);
			
			/* Take note that the method for setting the value to be plotted is the same as for setting a value
			to a DataSeries object. The difference here is that the custom DataSeries object is not plotted while
			this "Average Range" is plotted.
			
			In this case we are plotting the Simple Moving Average of the intermediate calculation step stored in our
			Series object. */
			
            Value[0] = SMA(myDoubleSeries, Period)[0];
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
		private SampleCustomSeries[] cacheSampleCustomSeries;
		public SampleCustomSeries SampleCustomSeries(int period)
		{
			return SampleCustomSeries(Input, period);
		}

		public SampleCustomSeries SampleCustomSeries(ISeries<double> input, int period)
		{
			if (cacheSampleCustomSeries != null)
				for (int idx = 0; idx < cacheSampleCustomSeries.Length; idx++)
					if (cacheSampleCustomSeries[idx] != null && cacheSampleCustomSeries[idx].Period == period && cacheSampleCustomSeries[idx].EqualsInput(input))
						return cacheSampleCustomSeries[idx];
			return CacheIndicator<SampleCustomSeries>(new SampleCustomSeries(){ Period = period }, input, ref cacheSampleCustomSeries);
		}
	}
}

namespace NinjaTrader.NinjaScript.MarketAnalyzerColumns
{
	public partial class MarketAnalyzerColumn : MarketAnalyzerColumnBase
	{
		public Indicators.SampleCustomSeries SampleCustomSeries(int period)
		{
			return indicator.SampleCustomSeries(Input, period);
		}

		public Indicators.SampleCustomSeries SampleCustomSeries(ISeries<double> input , int period)
		{
			return indicator.SampleCustomSeries(input, period);
		}
	}
}

namespace NinjaTrader.NinjaScript.Strategies
{
	public partial class Strategy : NinjaTrader.Gui.NinjaScript.StrategyRenderBase
	{
		public Indicators.SampleCustomSeries SampleCustomSeries(int period)
		{
			return indicator.SampleCustomSeries(Input, period);
		}

		public Indicators.SampleCustomSeries SampleCustomSeries(ISeries<double> input , int period)
		{
			return indicator.SampleCustomSeries(input, period);
		}
	}
}

#endregion
