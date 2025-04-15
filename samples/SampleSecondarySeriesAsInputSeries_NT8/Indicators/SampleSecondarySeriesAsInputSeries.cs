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
	public class SampleSecondarySeriesAsInputSeries : Indicator
	{
		private SMA sma1;
		private SMA sma2;
		
		protected override void OnStateChange()
		{
			if (State == State.SetDefaults)
			{
				Description									= @"";
				Name										= "SampleSecondarySeriesAsInputSeries";
				Calculate									= Calculate.OnBarClose;
				IsOverlay									= true;
				DisplayInDataBox							= true;
				
				BarsRequiredToPlot							= 14;
				
				AddPlot(Brushes.Blue, "SMA Primary Series");
				AddPlot(Brushes.Green, "SMA Secondary Series");
			}
			else if (State == State.Configure)
			{
				// Adds a secondary bar object to the indicator
				AddDataSeries(BarsPeriodType.Minute, 5);
			}
			else if (State == State.DataLoaded)
			{
				// initialize the SMA using the primary series and assign to sma1
				sma1 = SMA(BarsArray[0], 14);
				// initialize the SMA using the secondary 5 minute series and assign to sma1
				sma2 = SMA(BarsArray[1], 14);
			}
		}

		protected override void OnBarUpdate()
		{
			// ensure both series have at least one bar
			if (CurrentBars[0] < 1 || CurrentBars[1] < 1)
				return;			
			
			// when the 5 minute series is processing set the secondary plot to the sma with the secondary series input
			if (BarsInProgress == 1)
				SMASecondary[0] = sma2[0];
			
			// when the primary series is processing set the primary plot to the sma with the primary series input
			if (BarsInProgress == 0)
			{
				SMAPrimary[0] = sma1[0];
				
				// if the secondary 5 minute series did not close, set the current bar's value to the previous bar's value to prevent gaps 
				if (!SMASecondary.IsValidDataPoint(0))
					SMASecondary[0] = SMASecondary[1];
			}
		}

		[Browsable(false)]
		[XmlIgnore]
		public Series<double> SMAPrimary
		{
			get { return Values[0]; }
		}
		
		[Browsable(false)]
		[XmlIgnore]
		public Series<double> SMASecondary
		{
			get { return Values[1]; }
		}
	}
}

#region NinjaScript generated code. Neither change nor remove.

namespace NinjaTrader.NinjaScript.Indicators
{
	public partial class Indicator : NinjaTrader.Gui.NinjaScript.IndicatorRenderBase
	{
		private SampleSecondarySeriesAsInputSeries[] cacheSampleSecondarySeriesAsInputSeries;
		public SampleSecondarySeriesAsInputSeries SampleSecondarySeriesAsInputSeries()
		{
			return SampleSecondarySeriesAsInputSeries(Input);
		}

		public SampleSecondarySeriesAsInputSeries SampleSecondarySeriesAsInputSeries(ISeries<double> input)
		{
			if (cacheSampleSecondarySeriesAsInputSeries != null)
				for (int idx = 0; idx < cacheSampleSecondarySeriesAsInputSeries.Length; idx++)
					if (cacheSampleSecondarySeriesAsInputSeries[idx] != null &&  cacheSampleSecondarySeriesAsInputSeries[idx].EqualsInput(input))
						return cacheSampleSecondarySeriesAsInputSeries[idx];
			return CacheIndicator<SampleSecondarySeriesAsInputSeries>(new SampleSecondarySeriesAsInputSeries(), input, ref cacheSampleSecondarySeriesAsInputSeries);
		}
	}
}

namespace NinjaTrader.NinjaScript.MarketAnalyzerColumns
{
	public partial class MarketAnalyzerColumn : MarketAnalyzerColumnBase
	{
		public Indicators.SampleSecondarySeriesAsInputSeries SampleSecondarySeriesAsInputSeries()
		{
			return indicator.SampleSecondarySeriesAsInputSeries(Input);
		}

		public Indicators.SampleSecondarySeriesAsInputSeries SampleSecondarySeriesAsInputSeries(ISeries<double> input )
		{
			return indicator.SampleSecondarySeriesAsInputSeries(input);
		}
	}
}

namespace NinjaTrader.NinjaScript.Strategies
{
	public partial class Strategy : NinjaTrader.Gui.NinjaScript.StrategyRenderBase
	{
		public Indicators.SampleSecondarySeriesAsInputSeries SampleSecondarySeriesAsInputSeries()
		{
			return indicator.SampleSecondarySeriesAsInputSeries(Input);
		}

		public Indicators.SampleSecondarySeriesAsInputSeries SampleSecondarySeriesAsInputSeries(ISeries<double> input )
		{
			return indicator.SampleSecondarySeriesAsInputSeries(input);
		}
	}
}

#endregion
