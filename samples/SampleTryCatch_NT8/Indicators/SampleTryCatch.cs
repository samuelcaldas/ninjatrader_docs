// 
// Copyright (C) 2015, NinjaTrader LLC <www.ninjatrader.com>.
// NinjaTrader reserves the right to modify or overwrite this NinjaScript component with each release.
//
#region Using declarations
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Xml.Serialization;
#endregion

// This namespace holds all indicators and is required. Do not change it.
namespace NinjaTrader.NinjaScript.Indicators
{
    public class SampleTryCatch : Indicator
    {
        protected override void OnStateChange()
        {
			if(State == State.SetDefaults)
			{
				AddPlot(Brushes.Orange, "Moving Average");
           	 	Calculate				= Calculate.OnBarClose;
				Name					= "Sample try/catch";
            	IsOverlay				= true;		
			}
			
			else if(State == State.Historical)
			{}
        }

        protected override void OnBarUpdate()
        {
			/* This is the block where we put any code we need to debug into. A general tactic would be to start with a large try-catch block and slowly move
			code segments out of the try-catch block until you have isolated the problem down to a single segment. Another commonly used tactic would be to
			nest try-catch blocks within each other. This nesting would all have different log and output commands from their catch blocks; effectively allowing
			you to determine the source of the bug in your code. */
			
			try
			{
				// NOTE: The code in this segment is faulty on purpose to demonstrate how to demonstrate how a try-block catch can be useful.
				
				int period = 10;
				double closeSum = 0;
				while (period > 0)
				{
					/* The error is in this line. On the first bar of the chart we will not have enough bars to go back 10 bars. Trying to reference
					Close[period] will normally cause our indicator to fail all together, but since we have it inside our try-catch block we are able
					to isolate the error and handle it in the catch block instead of completely halting our indicator. */
					closeSum += Close[period];
					period--;
				}
				
				Value[0] = closeSum / 10;
			}
			
			// This is the block where we handle the caught exception.
			catch (Exception e)
			{
				// In case the indicator has already been Terminated, you can safely ignore errors
				if (State >= State.Terminated)
					return;

				/* With our caught exception we are able to generate log entries that go to the Control Center logs and also print more detailed information
				about the error to the Output Window. */
				
				// Submits an entry into the Control Center logs to inform the user of an error				
				Log("SampleTryCatch Error: Please check your indicator for errors.", NinjaTrader.Cbi.LogLevel.Warning);
				
				// Prints the caught exception in the Output Window
				Print(Time[0] + " " + e.ToString());
			}
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
		private SampleTryCatch[] cacheSampleTryCatch;
		public SampleTryCatch SampleTryCatch()
		{
			return SampleTryCatch(Input);
		}

		public SampleTryCatch SampleTryCatch(ISeries<double> input)
		{
			if (cacheSampleTryCatch != null)
				for (int idx = 0; idx < cacheSampleTryCatch.Length; idx++)
					if (cacheSampleTryCatch[idx] != null &&  cacheSampleTryCatch[idx].EqualsInput(input))
						return cacheSampleTryCatch[idx];
			return CacheIndicator<SampleTryCatch>(new SampleTryCatch(), input, ref cacheSampleTryCatch);
		}
	}
}

namespace NinjaTrader.NinjaScript.MarketAnalyzerColumns
{
	public partial class MarketAnalyzerColumn : MarketAnalyzerColumnBase
	{
		public Indicators.SampleTryCatch SampleTryCatch()
		{
			return indicator.SampleTryCatch(Input);
		}

		public Indicators.SampleTryCatch SampleTryCatch(ISeries<double> input )
		{
			return indicator.SampleTryCatch(input);
		}
	}
}

namespace NinjaTrader.NinjaScript.Strategies
{
	public partial class Strategy : NinjaTrader.Gui.NinjaScript.StrategyRenderBase
	{
		public Indicators.SampleTryCatch SampleTryCatch()
		{
			return indicator.SampleTryCatch(Input);
		}

		public Indicators.SampleTryCatch SampleTryCatch(ISeries<double> input )
		{
			return indicator.SampleTryCatch(input);
		}
	}
}

#endregion
