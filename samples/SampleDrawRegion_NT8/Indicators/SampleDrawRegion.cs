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
using NinjaTrader.Gui.Tools;
using NinjaTrader.Data;
using NinjaTrader.NinjaScript;
using NinjaTrader.Core.FloatingPoint;
using NinjaTrader.NinjaScript.DrawingTools;
#endregion

//This namespace holds Indicators in this folder and is required. Do not change it. 
namespace NinjaTrader.NinjaScript.Indicators
{
	public class SampleDrawRegion : Indicator
	{	
		protected override void OnStateChange()
		{
			if (State == State.SetDefaults)
			{
				Description									= @"Enter the description for your new custom Indicator here.";
				Name										= "SampleDrawRegion";
				Calculate									= Calculate.OnBarClose;
				IsOverlay									= true;
				DisplayInDataBox							= true;
				DrawOnPricePanel							= true;
				DrawHorizontalGridLines						= true;
				DrawVerticalGridLines						= true;
				PaintPriceMarkers							= true;
				ScaleJustification							= NinjaTrader.Gui.Chart.ScaleJustification.Right;
				//Disable this property if your indicator requires custom values that cumulate with each new market data event. 
				//See Help Guide for additional information.
				IsSuspendedWhileInactive					= true;
				Period		= 14;
				NumStdDev 	= 2;
			}
		}

		protected override void OnBarUpdate()
		{
			// With the DrawRegion() method you can fill the space inbetween two DataSeries objects very easily.
			
			// This region fills in the space between the Upper Bollinger Band and the Middle Bollinger Band. The region extends from the first bar of the chart
			// till the last bar of the chart. It has a border color of black and is filled with blue on an opacity setting of 2. Opacity setting ranges from 0-10.
			// 0 being transparent and 10 being completely colored.
			Draw.Region(this, "Bollinger Upper Region", CurrentBar, 0, Bollinger(NumStdDev, Period).Upper, Bollinger(NumStdDev, Period).Middle, Brushes.Black, Brushes.Blue, 20);
			
			// This region fills the space between the Lower Bollinger Band and the Middle Bollinger Band. It has the same attributes as the previous region, except
			// the blue fill color is darker in this one. If you wish to create a region without a border you can use this color: Color.Transparent
			Draw.Region(this,"Bollinger Lower Region", CurrentBar, 0, Bollinger(NumStdDev, Period).Lower, Bollinger(NumStdDev, Period).Middle, Brushes.Black, Brushes.Blue, 50);
			
			// Besides filling inbetween two DataSeries objects we can also fill between a double value and a DataSeries.
			// This is demonstrated in the following code segment. 
			
			// If the price closes above the upper bollinger band, color the price region above the bollinger band gold.
			if (Bollinger(NumStdDev, Period).Upper[0] < Close[0])
			{
				// In our string tag we use "+ CurrentBar" to ensure unique tag names for all our regions. If we did not have unique names each call
				// upon the tag would modify the existing DrawRegion() instead of coloring a new one.
				Draw.Region(this,"Upper Bollinger Broken" + CurrentBar, 1, 0, Bollinger(NumStdDev, Period).Upper, High[0], Brushes.Black, 100);
			}
			
			// If the price closes below the lower bollinger band, color the price region below the bollinger band gold.
			else if (Bollinger(NumStdDev, Period).Lower[0] > Close[0])
			{
				Draw.Region(this,"Lower Bollinger Broken" + CurrentBar, 1, 0, Bollinger(NumStdDev, Period).Lower, Low[0], Brushes.Black,100);
			}
		}
		
		[Range(1, int.MaxValue), NinjaScriptProperty]
		[Display(Name = "Period", GroupName = "NinjaScriptParameters", Order = 0)]
		public int Period
		{ get; set; }
		
		[Range(0, double.MaxValue), NinjaScriptProperty]
		[Display(Name = "NumStdDev", GroupName = "NinjaScriptParameters", Order = 1)]
		public double NumStdDev
		{ get; set; }
	}
}

#region NinjaScript generated code. Neither change nor remove.

namespace NinjaTrader.NinjaScript.Indicators
{
	public partial class Indicator : NinjaTrader.Gui.NinjaScript.IndicatorRenderBase
	{
		private SampleDrawRegion[] cacheSampleDrawRegion;
		public SampleDrawRegion SampleDrawRegion(int period, double numStdDev)
		{
			return SampleDrawRegion(Input, period, numStdDev);
		}

		public SampleDrawRegion SampleDrawRegion(ISeries<double> input, int period, double numStdDev)
		{
			if (cacheSampleDrawRegion != null)
				for (int idx = 0; idx < cacheSampleDrawRegion.Length; idx++)
					if (cacheSampleDrawRegion[idx] != null && cacheSampleDrawRegion[idx].Period == period && cacheSampleDrawRegion[idx].NumStdDev == numStdDev && cacheSampleDrawRegion[idx].EqualsInput(input))
						return cacheSampleDrawRegion[idx];
			return CacheIndicator<SampleDrawRegion>(new SampleDrawRegion(){ Period = period, NumStdDev = numStdDev }, input, ref cacheSampleDrawRegion);
		}
	}
}

namespace NinjaTrader.NinjaScript.MarketAnalyzerColumns
{
	public partial class MarketAnalyzerColumn : MarketAnalyzerColumnBase
	{
		public Indicators.SampleDrawRegion SampleDrawRegion(int period, double numStdDev)
		{
			return indicator.SampleDrawRegion(Input, period, numStdDev);
		}

		public Indicators.SampleDrawRegion SampleDrawRegion(ISeries<double> input , int period, double numStdDev)
		{
			return indicator.SampleDrawRegion(input, period, numStdDev);
		}
	}
}

namespace NinjaTrader.NinjaScript.Strategies
{
	public partial class Strategy : NinjaTrader.Gui.NinjaScript.StrategyRenderBase
	{
		public Indicators.SampleDrawRegion SampleDrawRegion(int period, double numStdDev)
		{
			return indicator.SampleDrawRegion(Input, period, numStdDev);
		}

		public Indicators.SampleDrawRegion SampleDrawRegion(ISeries<double> input , int period, double numStdDev)
		{
			return indicator.SampleDrawRegion(input, period, numStdDev);
		}
	}
}

#endregion
