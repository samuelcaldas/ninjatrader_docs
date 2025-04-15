//
// Copyright (C) 2019, NinjaTrader LLC <www.ninjatrader.com>
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
	public class SampleUniversalMovingAverage : Indicator
	{
		// Create a variable that stores the user's selection for a moving average 
		private CustomEnumNamespace.UniversalMovingAverage	maType	= CustomEnumNamespace.UniversalMovingAverage.SMA;
		private int											period	= 14;

		protected override void OnStateChange()
		{
			if(State == State.SetDefaults)
			{
				// Adds a plot for the MA values to be stored in
				AddPlot(Brushes.Orange, "MA");
				
				Calculate 	= Calculate.OnBarClose;
				IsOverlay 	= true;
				Name		= "Sample universal moving average";
			}
		}

		protected override void OnBarUpdate()
		{
			// We use a switch which allows NinjaTrader to only execute code pertaining to our case
			switch (maType)
			{
				// If the maType is defined as an EMA then...
				case CustomEnumNamespace.UniversalMovingAverage.EMA:
				{
					// Sets the plot to be equal to the EMA's plot
					Value[0] = (EMA(Period)[0]);
					break;
				}
				
				// If the maType is defined as a HMA then...
				case CustomEnumNamespace.UniversalMovingAverage.HMA:
				{
					// Sets the plot to be equal to the HMA's plot
					Value[0] = (HMA(Period)[0]);
					break;
				}
				
				// If the maType is defined as a SMA then...
				case CustomEnumNamespace.UniversalMovingAverage.SMA:
				{
					// Sets the plot to be equal to the SMA's plot
					Value[0] = (SMA(Period)[0]);
					break;
				}
				
				// If the maType is defined as a WMA then...
				case CustomEnumNamespace.UniversalMovingAverage.WMA:
				{
					// Sets the plot to be equal to the WMA's plot
					Value[0] = (WMA(Period)[0]);
					break;
				}
			}
		}

		#region Properties
		// Creates the user definable parameter for the moving average type.
		[Display(GroupName = "Parameters", Description="Choose a Moving Average Type.")]
		public CustomEnumNamespace.UniversalMovingAverage MAType
		{
			get { return maType; }
			set { maType = value; }
		}
		
		[Display(GroupName = "Parameters", Description="Numbers of bars used for calculations")]
		public int Period
		{
			get { return period; }
			set { period = Math.Max(1, value); }
		}
		#endregion
	}
}

/* Creates an enum in a custom namespace that is assigned to UniversalMovingAverage.
Basically it assigns a numerical value to each item in the list and the items can be referenced without the use
of their numerical value.
For more information on enums you can read up on it here: http://www.csharp-station.com/Tutorials/Lesson17.aspx */

namespace CustomEnumNamespace
{
	public enum UniversalMovingAverage
	{
		EMA,
		HMA,
		SMA,
		WMA,
	}
}

#region NinjaScript generated code. Neither change nor remove.

namespace NinjaTrader.NinjaScript.Indicators
{
	public partial class Indicator : NinjaTrader.Gui.NinjaScript.IndicatorRenderBase
	{
		private SampleUniversalMovingAverage[] cacheSampleUniversalMovingAverage;
		public SampleUniversalMovingAverage SampleUniversalMovingAverage()
		{
			return SampleUniversalMovingAverage(Input);
		}

		public SampleUniversalMovingAverage SampleUniversalMovingAverage(ISeries<double> input)
		{
			if (cacheSampleUniversalMovingAverage != null)
				for (int idx = 0; idx < cacheSampleUniversalMovingAverage.Length; idx++)
					if (cacheSampleUniversalMovingAverage[idx] != null &&  cacheSampleUniversalMovingAverage[idx].EqualsInput(input))
						return cacheSampleUniversalMovingAverage[idx];
			return CacheIndicator<SampleUniversalMovingAverage>(new SampleUniversalMovingAverage(), input, ref cacheSampleUniversalMovingAverage);
		}
	}
}

namespace NinjaTrader.NinjaScript.MarketAnalyzerColumns
{
	public partial class MarketAnalyzerColumn : MarketAnalyzerColumnBase
	{
		public Indicators.SampleUniversalMovingAverage SampleUniversalMovingAverage()
		{
			return indicator.SampleUniversalMovingAverage(Input);
		}

		public Indicators.SampleUniversalMovingAverage SampleUniversalMovingAverage(ISeries<double> input )
		{
			return indicator.SampleUniversalMovingAverage(input);
		}
	}
}

namespace NinjaTrader.NinjaScript.Strategies
{
	public partial class Strategy : NinjaTrader.Gui.NinjaScript.StrategyRenderBase
	{
		public Indicators.SampleUniversalMovingAverage SampleUniversalMovingAverage()
		{
			return indicator.SampleUniversalMovingAverage(Input);
		}

		public Indicators.SampleUniversalMovingAverage SampleUniversalMovingAverage(ISeries<double> input )
		{
			return indicator.SampleUniversalMovingAverage(input);
		}
	}
}

#endregion
