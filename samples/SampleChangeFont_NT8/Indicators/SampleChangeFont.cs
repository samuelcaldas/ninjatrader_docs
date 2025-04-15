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
using NinjaTrader.Gui.Tools;
using NinjaTrader.Gui.SuperDom;
using NinjaTrader.Data;
using NinjaTrader.NinjaScript;
using NinjaTrader.Core.FloatingPoint;
using NinjaTrader.NinjaScript.DrawingTools;

using System.Windows.Forms;
using System.Windows.Forms.Design;
#endregion
// This namespace holds all indicators and is required. Do not change it.
namespace NinjaTrader.NinjaScript.Indicators
{
    public class SampleChangeFont : Indicator
    {
		private SimpleFont	largeFont;		// This variable holds the large font.
		private SimpleFont	smallFont;		// This variable holds the small font.

        protected override void OnStateChange()
        {
			if(State == State.SetDefaults)
			{
				Description					= @"A demonstration of how to change a font.";
				Name						= "Sample change font";
				Calculate 				= Calculate.OnBarClose;
           		IsOverlay				= true;
				largeFont = new Gui.Tools.SimpleFont("Arial", 12);
				smallFont = new Gui.Tools.SimpleFont("Arial", 8);
			}
			
			else if(State == State.Terminated)
			{
				largeFont = null;
				smallFont = null;
			}
        }

        protected override void OnBarUpdate()
        {
			if (CurrentBar < 1)
				return;
			
			// If the close is greater than the open, draw the high price with the larger font.
			if (Close[0] > Open[0])
			{
				Draw.Text(this, "highText", true, High[0].ToString(), 1, High[0] + 2 * TickSize, 0, Brushes.Green, largeFont, TextAlignment.Justify, Brushes.Transparent, Brushes.Transparent, 0);
				Draw.Text(this, "lowText", true, Low[0].ToString(), 1, Low[0] - 2 * TickSize, 0, Brushes.Red, smallFont, TextAlignment.Justify, Brushes.Transparent, Brushes.Transparent, 0);
			}
			// If the close is less than the open, draw the low price with the larger font.
			else if (Close[0] < Open[0])
			{
				Draw.Text(this, "highText", true, High[0].ToString(), 1, High[0] + 2 * TickSize, 0, Brushes.Green, smallFont, TextAlignment.Justify, Brushes.Transparent, Brushes.Transparent, 0);
				Draw.Text(this, "lowText", true, Low[0].ToString(), 1, Low[0] - 2 * TickSize, 0, Brushes.Red, largeFont, TextAlignment.Justify, Brushes.Transparent, Brushes.Transparent, 0);
			}
			// If the closes are equal, draw the prices with the same font.
			else
			{
				Draw.Text(this, "highText", true, High[0].ToString(), 1, High[0] + 2 * TickSize, 0, Brushes.Green, smallFont, TextAlignment.Justify, Brushes.Transparent, Brushes.Transparent, 0);
				Draw.Text(this, "lowText", true, Low[0].ToString(), 1, Low[0] - 2 * TickSize, 0, Brushes.Red, smallFont, TextAlignment.Justify, Brushes.Transparent, Brushes.Transparent, 0);
			}			
		}
		
        #region Properties		
		[NinjaScriptProperty]
		[Display(Name="Large Font", Description="Font Size", Order=1, GroupName="Font")]
		public SimpleFont LargeFont
		{
			get{return largeFont;}
			set{largeFont = value;}
		}
		
		[NinjaScriptProperty]
		[Display(Name="Small Font", Description="Font Size", Order=2, GroupName="Font")]
		public SimpleFont SmallFont
		{
			get{return smallFont;}
			set{smallFont = value;}
		}
        #endregion
    }
}

#region NinjaScript generated code. Neither change nor remove.

namespace NinjaTrader.NinjaScript.Indicators
{
	public partial class Indicator : NinjaTrader.Gui.NinjaScript.IndicatorRenderBase
	{
		private SampleChangeFont[] cacheSampleChangeFont;
		public SampleChangeFont SampleChangeFont(SimpleFont smallFont)
		{
			return SampleChangeFont(Input, smallFont);
		}

		public SampleChangeFont SampleChangeFont(ISeries<double> input, SimpleFont smallFont)
		{
			if (cacheSampleChangeFont != null)
				for (int idx = 0; idx < cacheSampleChangeFont.Length; idx++)
					if (cacheSampleChangeFont[idx] != null && cacheSampleChangeFont[idx].SmallFont == smallFont && cacheSampleChangeFont[idx].EqualsInput(input))
						return cacheSampleChangeFont[idx];
			return CacheIndicator<SampleChangeFont>(new SampleChangeFont(){ SmallFont = smallFont }, input, ref cacheSampleChangeFont);
		}
	}
}

namespace NinjaTrader.NinjaScript.MarketAnalyzerColumns
{
	public partial class MarketAnalyzerColumn : MarketAnalyzerColumnBase
	{
		public Indicators.SampleChangeFont SampleChangeFont(SimpleFont smallFont)
		{
			return indicator.SampleChangeFont(Input, smallFont);
		}

		public Indicators.SampleChangeFont SampleChangeFont(ISeries<double> input , SimpleFont smallFont)
		{
			return indicator.SampleChangeFont(input, smallFont);
		}
	}
}

namespace NinjaTrader.NinjaScript.Strategies
{
	public partial class Strategy : NinjaTrader.Gui.NinjaScript.StrategyRenderBase
	{
		public Indicators.SampleChangeFont SampleChangeFont(SimpleFont smallFont)
		{
			return indicator.SampleChangeFont(Input, smallFont);
		}

		public Indicators.SampleChangeFont SampleChangeFont(ISeries<double> input , SimpleFont smallFont)
		{
			return indicator.SampleChangeFont(input, smallFont);
		}
	}
}

#endregion
