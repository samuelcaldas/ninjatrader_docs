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
	public class SampleEveryNBar : Indicator
	{
		protected override void OnStateChange()
		{
			if(State == State.SetDefaults)
			{
				AddPlot(Brushes.Yellow, "PlotN");
				Name 						= "Sample every N bar";
				IsOverlay					= false;
				N							= 14;
			}
			
			else if(State == State.Historical)
			{
				
			}
		}

		protected override void OnBarUpdate()
		{
			// This indicator will not show anything on the chart, it is only for creating data for the SampleEveryNBarTest indicator to use. 
			// Sets a plot value every N number of bars. When there is no plot value set this indicator should not be accessed programmatically.
			if(CurrentBar % N == 0)
				Value[0] = Median[0];
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
		private SampleEveryNBar[] cacheSampleEveryNBar;
		public SampleEveryNBar SampleEveryNBar(int n)
		{
			return SampleEveryNBar(Input, n);
		}

		public SampleEveryNBar SampleEveryNBar(ISeries<double> input, int n)
		{
			if (cacheSampleEveryNBar != null)
				for (int idx = 0; idx < cacheSampleEveryNBar.Length; idx++)
					if (cacheSampleEveryNBar[idx] != null && cacheSampleEveryNBar[idx].N == n && cacheSampleEveryNBar[idx].EqualsInput(input))
						return cacheSampleEveryNBar[idx];
			return CacheIndicator<SampleEveryNBar>(new SampleEveryNBar(){ N = n }, input, ref cacheSampleEveryNBar);
		}
	}
}

namespace NinjaTrader.NinjaScript.MarketAnalyzerColumns
{
	public partial class MarketAnalyzerColumn : MarketAnalyzerColumnBase
	{
		public Indicators.SampleEveryNBar SampleEveryNBar(int n)
		{
			return indicator.SampleEveryNBar(Input, n);
		}

		public Indicators.SampleEveryNBar SampleEveryNBar(ISeries<double> input , int n)
		{
			return indicator.SampleEveryNBar(input, n);
		}
	}
}

namespace NinjaTrader.NinjaScript.Strategies
{
	public partial class Strategy : NinjaTrader.Gui.NinjaScript.StrategyRenderBase
	{
		public Indicators.SampleEveryNBar SampleEveryNBar(int n)
		{
			return indicator.SampleEveryNBar(Input, n);
		}

		public Indicators.SampleEveryNBar SampleEveryNBar(ISeries<double> input , int n)
		{
			return indicator.SampleEveryNBar(input, n);
		}
	}
}

#endregion
