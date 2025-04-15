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

//This namespace holds Indicators in this folder and is required. Do not change it. 
namespace NinjaTrader.NinjaScript.Indicators
{
	public class SampleDisplayName : Indicator
	{
		private int period;
		private int interval;
		private int smooth;
		private int numStdDev;

		protected override void OnStateChange()
		{
			if (State == State.SetDefaults)
			{
				Description							= @"A Sample on how to override the displayname of a NinjaScript item. ";
				Name                                = "Sample display name";
				Calculate                           = Calculate.OnBarClose;
				IsOverlay                           = false;
				DisplayInDataBox                    = true;
				DrawOnPricePanel                    = true;
				DrawHorizontalGridLines             = true;
				DrawVerticalGridLines               = true;
				PaintPriceMarkers                   = true;
				ScaleJustification                  = ScaleJustification.Right;
				interval                            = 10;
				period                              = 5;
				smooth                              = 15;
				numStdDev                           = 2;
			}
		}

		protected override void OnBarUpdate()
		{
			Draw.TextFixed(this, "textOutput","Period: " + Period + "\nInterval: " + Interval + "\nSmooth: " + Smooth + "\nStdDev: " + NumStdDev, TextPosition.BottomRight);
		}

		public override string DisplayName
		{
			get { return Name + "(" + Period + "," + Interval + ")"; }
		}

		#region Properties

		// Create our four user-definable variables.
		[Range(1, int.MaxValue), NinjaScriptProperty]
		[Display(ResourceType = typeof(Custom.Resource), Name = "Period", GroupName = "NinjaScriptParameters", Order = 0)]
		public int Period
		{ get { return period; } set { period = value; } }

		[Range(1, int.MaxValue), NinjaScriptProperty]
		[Display(ResourceType = typeof(Custom.Resource), Name = "Interval", GroupName = "NinjaScriptParameters", Order = 1)]
		public int Interval
		{ get { return interval; } set { interval = value; } }

		[Range(1, int.MaxValue), NinjaScriptProperty]
		[Display(ResourceType = typeof(Custom.Resource), Name = "Smooth", GroupName = "NinjaScriptParameters", Order = 2)]
		public int Smooth
		{ get { return smooth; } set { smooth = value; } }

		[Range(1, int.MaxValue), NinjaScriptProperty]
		[Display(ResourceType = typeof(Custom.Resource), Name = "NumStdDev", GroupName = "NinjaScriptParameters", Order = 3)]
		public int NumStdDev
		{ get { return numStdDev; } set { numStdDev = value; } }

		#endregion
	}
}

#region NinjaScript generated code. Neither change nor remove.

namespace NinjaTrader.NinjaScript.Indicators
{
	public partial class Indicator : NinjaTrader.Gui.NinjaScript.IndicatorRenderBase
	{
		private SampleDisplayName[] cacheSampleDisplayName;
		public SampleDisplayName SampleDisplayName(int period, int interval, int smooth, int numStdDev)
		{
			return SampleDisplayName(Input, period, interval, smooth, numStdDev);
		}

		public SampleDisplayName SampleDisplayName(ISeries<double> input, int period, int interval, int smooth, int numStdDev)
		{
			if (cacheSampleDisplayName != null)
				for (int idx = 0; idx < cacheSampleDisplayName.Length; idx++)
					if (cacheSampleDisplayName[idx] != null && cacheSampleDisplayName[idx].Period == period && cacheSampleDisplayName[idx].Interval == interval && cacheSampleDisplayName[idx].Smooth == smooth && cacheSampleDisplayName[idx].NumStdDev == numStdDev && cacheSampleDisplayName[idx].EqualsInput(input))
						return cacheSampleDisplayName[idx];
			return CacheIndicator<SampleDisplayName>(new SampleDisplayName(){ Period = period, Interval = interval, Smooth = smooth, NumStdDev = numStdDev }, input, ref cacheSampleDisplayName);
		}
	}
}

namespace NinjaTrader.NinjaScript.MarketAnalyzerColumns
{
	public partial class MarketAnalyzerColumn : MarketAnalyzerColumnBase
	{
		public Indicators.SampleDisplayName SampleDisplayName(int period, int interval, int smooth, int numStdDev)
		{
			return indicator.SampleDisplayName(Input, period, interval, smooth, numStdDev);
		}

		public Indicators.SampleDisplayName SampleDisplayName(ISeries<double> input , int period, int interval, int smooth, int numStdDev)
		{
			return indicator.SampleDisplayName(input, period, interval, smooth, numStdDev);
		}
	}
}

namespace NinjaTrader.NinjaScript.Strategies
{
	public partial class Strategy : NinjaTrader.Gui.NinjaScript.StrategyRenderBase
	{
		public Indicators.SampleDisplayName SampleDisplayName(int period, int interval, int smooth, int numStdDev)
		{
			return indicator.SampleDisplayName(Input, period, interval, smooth, numStdDev);
		}

		public Indicators.SampleDisplayName SampleDisplayName(ISeries<double> input , int period, int interval, int smooth, int numStdDev)
		{
			return indicator.SampleDisplayName(input, period, interval, smooth, numStdDev);
		}
	}
}

#endregion
