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
	public class SampleBrushInput : Indicator
	{
		protected override void OnStateChange()
		{
			if (State == State.SetDefaults)
			{
				Description					= @"Reference sample showing how to create user definable brush inputs.";
				Name						= "Sample brush input";
				Calculate					= Calculate.OnBarClose;
				IsOverlay					= true;
				DisplayInDataBox			= true;
				DrawOnPricePanel			= true;
				DrawHorizontalGridLines		= true;
				DrawVerticalGridLines		= true;
				PaintPriceMarkers			= true;
				ScaleJustification			= NinjaTrader.Gui.Chart.ScaleJustification.Right;
				IsSuspendedWhileInactive	= true;
				BorderBrush = Brushes.RoyalBlue;
				FillBrush = Brushes.DodgerBlue;
			}
			else if (State == State.Configure)
			{
			}
		}

		protected override void OnBarUpdate()
		{
			if(CurrentBar < 5)
				return;
			// Use our two user definable brush inputs for the colors of our rectangle.
			Draw.Rectangle(this, "CustomColorsRectangle", true, 0, High[0], 5, Low[5], BorderBrush, FillBrush, 50);
		}
		#region Properties
		// Create our user definable color input
		[XmlIgnore()]
		[Display(Name = "BorderBrush", GroupName = "NinjaScriptParameters", Order = 0)]
		public Brush BorderBrush
		{ get; set; }
		
		// Serialize our Color object
		[Browsable(false)]
		public string BorderBrushSerialize
		{
			get { return Serialize.BrushToString(BorderBrush); }
   			set { BorderBrush = Serialize.StringToBrush(value); }
		}
		
		[XmlIgnore()]
		[Display(Name = "FillBrush", GroupName = "NinjaScriptParameters", Order = 1)]
		public Brush FillBrush
		{ get; set; }
		
		[Browsable(false)]
		public string FillBrushSerialize
		{
			get { return Serialize.BrushToString(FillBrush); }
   			set { FillBrush = Serialize.StringToBrush(value); }
		}
		#endregion
	}
}

#region NinjaScript generated code. Neither change nor remove.

namespace NinjaTrader.NinjaScript.Indicators
{
	public partial class Indicator : NinjaTrader.Gui.NinjaScript.IndicatorRenderBase
	{
		private SampleBrushInput[] cacheSampleBrushInput;
		public SampleBrushInput SampleBrushInput()
		{
			return SampleBrushInput(Input);
		}

		public SampleBrushInput SampleBrushInput(ISeries<double> input)
		{
			if (cacheSampleBrushInput != null)
				for (int idx = 0; idx < cacheSampleBrushInput.Length; idx++)
					if (cacheSampleBrushInput[idx] != null &&  cacheSampleBrushInput[idx].EqualsInput(input))
						return cacheSampleBrushInput[idx];
			return CacheIndicator<SampleBrushInput>(new SampleBrushInput(), input, ref cacheSampleBrushInput);
		}
	}
}

namespace NinjaTrader.NinjaScript.MarketAnalyzerColumns
{
	public partial class MarketAnalyzerColumn : MarketAnalyzerColumnBase
	{
		public Indicators.SampleBrushInput SampleBrushInput()
		{
			return indicator.SampleBrushInput(Input);
		}

		public Indicators.SampleBrushInput SampleBrushInput(ISeries<double> input )
		{
			return indicator.SampleBrushInput(input);
		}
	}
}

namespace NinjaTrader.NinjaScript.Strategies
{
	public partial class Strategy : NinjaTrader.Gui.NinjaScript.StrategyRenderBase
	{
		public Indicators.SampleBrushInput SampleBrushInput()
		{
			return indicator.SampleBrushInput(Input);
		}

		public Indicators.SampleBrushInput SampleBrushInput(ISeries<double> input )
		{
			return indicator.SampleBrushInput(input);
		}
	}
}

#endregion
