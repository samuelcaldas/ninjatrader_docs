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
	public class SampleEveryNBarTest : Indicator
	{
		protected override void OnStateChange()
		{
			if(State == State.SetDefaults)
			{

				Name					= "Sample every N bar test";
				AddPlot(new Stroke(Brushes.Orange, 1), PlotStyle.Block, "Plot0");
				IsOverlay				= false;
				N						= 14;
			}
			else if (State == State.Historical)
			{}
		}

		protected override void OnBarUpdate()
		{
			/* Checks to see if the current bar has a valid indicator plot value set on indicator plot: Value. It is important to check this to know if the values you are
			 using are relevant or not. Using irrelevant values for your script logic can cause inaccurate calculations and trade signals. */
			if(!SampleEveryNBar(N).Value.IsValidDataPoint(0))
			{
				// SampleEveryNBar does not have a valid indicator plot value. Set hosting indicator's plot to zero and paint the bar red.
				BarBrushes[0] = Brushes.Red;
				PlotBrushes[0][0] = Brushes.Red;
				Value[0]= 0;
			}
			else 
			{
				// SampleEveryNBar does have a valid indicator plot value. Set hosting indicator's plot to this value and paint the bar blue.
				BarBrushes[0] = Brushes.Blue;
				PlotBrushes[0][0] = Brushes.Blue;
				double val = SampleEveryNBar(N).Value[0];
				Value[0] = val;
			}
		}

		#region Properties
		[Range(1, int.MaxValue), NinjaScriptProperty]
		[Display(ResourceType = typeof(Custom.Resource), Name = "N", GroupName = "NinjaScriptParameters", Order = 0)]
		public int N
		{ get; set; }
		#endregion
	}
}

#region NinjaScript generated code. Neither change nor remove.

namespace NinjaTrader.NinjaScript.Indicators
{
	public partial class Indicator : NinjaTrader.Gui.NinjaScript.IndicatorRenderBase
	{
		private SampleEveryNBarTest[] cacheSampleEveryNBarTest;
		public SampleEveryNBarTest SampleEveryNBarTest(int n)
		{
			return SampleEveryNBarTest(Input, n);
		}

		public SampleEveryNBarTest SampleEveryNBarTest(ISeries<double> input, int n)
		{
			if (cacheSampleEveryNBarTest != null)
				for (int idx = 0; idx < cacheSampleEveryNBarTest.Length; idx++)
					if (cacheSampleEveryNBarTest[idx] != null && cacheSampleEveryNBarTest[idx].N == n && cacheSampleEveryNBarTest[idx].EqualsInput(input))
						return cacheSampleEveryNBarTest[idx];
			return CacheIndicator<SampleEveryNBarTest>(new SampleEveryNBarTest(){ N = n }, input, ref cacheSampleEveryNBarTest);
		}
	}
}

namespace NinjaTrader.NinjaScript.MarketAnalyzerColumns
{
	public partial class MarketAnalyzerColumn : MarketAnalyzerColumnBase
	{
		public Indicators.SampleEveryNBarTest SampleEveryNBarTest(int n)
		{
			return indicator.SampleEveryNBarTest(Input, n);
		}

		public Indicators.SampleEveryNBarTest SampleEveryNBarTest(ISeries<double> input , int n)
		{
			return indicator.SampleEveryNBarTest(input, n);
		}
	}
}

namespace NinjaTrader.NinjaScript.Strategies
{
	public partial class Strategy : NinjaTrader.Gui.NinjaScript.StrategyRenderBase
	{
		public Indicators.SampleEveryNBarTest SampleEveryNBarTest(int n)
		{
			return indicator.SampleEveryNBarTest(Input, n);
		}

		public Indicators.SampleEveryNBarTest SampleEveryNBarTest(ISeries<double> input , int n)
		{
			return indicator.SampleEveryNBarTest(input, n);
		}
	}
}

#endregion
