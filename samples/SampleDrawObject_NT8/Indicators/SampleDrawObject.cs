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
    public class SampleDrawObject : Indicator
    {
		private int rectWidth;

        protected override void OnStateChange()
        {
			if(State == State.SetDefaults)
			{
				Name		= "Sample draw object";
            	Calculate	= Calculate.OnBarClose;
            	IsOverlay	= true;
			}
        }

        protected override void OnBarUpdate()
        {
			// When the close of the bar crosses above the SMA(20), draw a blue diamond
			if (CrossAbove(Close, SMA(20), 1))
			{
				/* Adding the 'CurrentBar' to the string creates unique draw objects because they will all have unique IDs
				Having unique ID strings may cause performance issues if many objects are drawn */
				Draw.Diamond(this, "Up Diamond" + CurrentBar, false, 0, SMA(20)[0], Brushes.Blue);
			}
			
			// But when the close crosses below the SMA(20), draw a magenta diamond
			else if (CrossBelow(Close, SMA(20), 1))
			{
				/* Adding the 'CurrentBar' to the string creates unique draw objects because they will all have unique IDs
				Having unique ID strings may cause performance issues if many objects are drawn */
				Draw.Diamond(this, "Down Diamond" + CurrentBar, false, 0, SMA(20)[0], Brushes.Magenta);
			}
			
			// Draw a blue-violet rectangle representing the latest uptrend based on the SMA(20)
			if (Close[0] >= SMA(20)[0])
			{
				/* Because the ID string is not unique for every rectangle, the latest draw object will replace the
				old draw object. The rectangle's starting bar is determined by the uptrend counter. */
				Draw.Rectangle(this, "Rectangle", false, rectWidth, Close[rectWidth], 0, Close[0], Brushes.Blue, Brushes.BlueViolet, 5);
				
				// Counter that keeps track of the uptrend by incrementing
				rectWidth++;
			}
			
			// Reset the uptrend counter when trend has ended
			if (Close[0] < SMA(20)[0])
				rectWidth = 0;
        }

        #region Properties
        #endregion
    }
}

#region NinjaScript generated code. Neither change nor remove.

namespace NinjaTrader.NinjaScript.Indicators
{
	public partial class Indicator : NinjaTrader.Gui.NinjaScript.IndicatorRenderBase
	{
		private SampleDrawObject[] cacheSampleDrawObject;
		public SampleDrawObject SampleDrawObject()
		{
			return SampleDrawObject(Input);
		}

		public SampleDrawObject SampleDrawObject(ISeries<double> input)
		{
			if (cacheSampleDrawObject != null)
				for (int idx = 0; idx < cacheSampleDrawObject.Length; idx++)
					if (cacheSampleDrawObject[idx] != null &&  cacheSampleDrawObject[idx].EqualsInput(input))
						return cacheSampleDrawObject[idx];
			return CacheIndicator<SampleDrawObject>(new SampleDrawObject(), input, ref cacheSampleDrawObject);
		}
	}
}

namespace NinjaTrader.NinjaScript.MarketAnalyzerColumns
{
	public partial class MarketAnalyzerColumn : MarketAnalyzerColumnBase
	{
		public Indicators.SampleDrawObject SampleDrawObject()
		{
			return indicator.SampleDrawObject(Input);
		}

		public Indicators.SampleDrawObject SampleDrawObject(ISeries<double> input )
		{
			return indicator.SampleDrawObject(input);
		}
	}
}

namespace NinjaTrader.NinjaScript.Strategies
{
	public partial class Strategy : NinjaTrader.Gui.NinjaScript.StrategyRenderBase
	{
		public Indicators.SampleDrawObject SampleDrawObject()
		{
			return indicator.SampleDrawObject(Input);
		}

		public Indicators.SampleDrawObject SampleDrawObject(ISeries<double> input )
		{
			return indicator.SampleDrawObject(input);
		}
	}
}

#endregion
