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
using NinjaTrader.NinjaScript.DrawingTools;
#endregion

// This namespace holds all indicators and is required. Do not change it.
namespace NinjaTrader.NinjaScript.Indicators
{
	public class SampleDateTimeFunctions : Indicator
	{
		private DateTime 	myDateTime; 									// This variable holds the primary DateTime object we'll be working with.
		private DateTime 	myDateTimePlusSome;								// We'll add the TimeSpan below to the original myDateTime to get this time
		private DateTime 	now; 											// This variable is declared here, but has no value until assigned below.
		private TimeSpan 	threeMinutesTwoSeconds;							// This TimeSpan structure's duration is 3 minutes and 2 seconds.

		protected override void OnStateChange()
		{
			if(State == State.SetDefaults)
			{
				IsOverlay				= false;
				Calculate 				= Calculate.OnPriceChange;
				Name					= "Sample DateTime functions";
				
				threeMinutesTwoSeconds 	= new TimeSpan(0, 3, 2);
			}
			
			else if(State == State.Historical)
			{
			}
		}

		/// <summary>
		/// Called on each bar update event (incoming tick)
		/// </summary>
		protected override void OnBarUpdate()
		{
			if (CurrentBar == 0)
			{
				// This line of code prints a blank line in the output window, and is used to keep the output organized.
				Print(string.Empty);
				
				// Clear the output window, as this is a print-only sample.
				ClearOutputWindow();
				
				/* Set a string that represents the format we'd like to use to print our DateTimes.
				   An extensive list of formatting can be found at http://www.geekzilla.co.uk/View00FF7904-B510-468C-A2C8-F859AA20581F.htm
				   This specific format reads [month/day/year hour:minute:second AM/PM] (with two digits for milliseconds). */
				string format = "MM/dd/yyyy HH:mm:ss tt";
				
				// Specify a date and time in string format to parse.
				string dateTimeToParse = "07/29/09 14:30:00";
				
				/* Try to parse that date and time. The "out" in the arguments means that variable is where the output should go to.
				   DateTime.TryParse returns either true or false, so the below code really means if (true) print "successful" else print "unsuccessful". */
				if (DateTime.TryParse(dateTimeToParse, out myDateTime))
					Print("Parsed successfully:\t" + myDateTime);
				else
					Print("Unable to understand DateTime input.");
				
				// After parsing, print different formats of the same DateTime
				Print(string.Empty);
				Print("different formatting of the same DateTime");
				Print(myDateTime.ToString("yyyy-MM-dd HH:mm:ss"));
				Print(myDateTime.ToString("dddd MMMM dd yyyy, hh:mm:ss tt"));
				Print(myDateTime.ToString("yyyyMMdd HHmmssfff"));
				
				// Here, the print format is taken as the variable we set above.
				Print(myDateTime.ToString(format));

				// It is also possible to access the DateTime structure's properties directly.
				Print(string.Format("{0}/{1}/{2} {3}:{4}:{5}",
					myDateTime.Month,
					myDateTime.Day,
					myDateTime.Year,
					myDateTime.Hour,
					myDateTime.Minute,
					myDateTime.Second));
				
				// Get the current time from PC's clock and save that value to the variable 'now'.
				Print(string.Empty);
				now = DateTime.Now;
				
				// Print that 'now' value
				Print("The time now:\t" + now.ToString(format));
				
				// Add time to the myDateTime DateTime object via a TimeSpan object and save the result in myDateTimePlusSome
				Print(string.Empty);
				
				// Add the TimeSpan object
				myDateTimePlusSome = myDateTime.Add(threeMinutesTwoSeconds);
				
				// Print the current value of myDateTime
				Print("myDateTime = " + myDateTime.ToString(format));
				
				// myDateTimePlusSome is now equal to 07/29/2009 14:33:02 PM.
				Print("myDateTime + 3 minutes and 2 seconds = " + myDateTimePlusSome.ToString(format));
				
				// Add time to the myDateTime DateTime object via the other methods
				Print(string.Empty);
				
				// Print the current value of myDateTime
				Print("myDateTime = " + myDateTime.ToString(format));
				
				// Add 5 minues and 4 seconds to myDateTime
				myDateTime = myDateTime.AddMinutes(5);
				myDateTime = myDateTime.AddSeconds(4);
				
				// myDateTime is now equal to 07/29/2009 14:35:04 PM.
				Print("myDateTime after adding 5 minutes and 4 seconds = " + myDateTime.ToString(format));
				
				/* Compare two DateTime objects, myDateTime and myDateTimePlusSome. The values for each DateTime object are in the comments above.
				   DateTime.Compare returns -1, 0 or 1, depending on the relationship of the two DateTime objects. */
				Print(string.Empty);
				int result = (DateTime.Compare(myDateTime, myDateTimePlusSome));
				string relationship;
				
				if (result < 0)
					relationship = "is earlier than";
				else if (result > 0)
					relationship = "is later than";
				else
					relationship = "is the same time as";
				
				// Print the results.
				Print(string.Format("{0} {1} {2}", myDateTime, relationship, myDateTimePlusSome));
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
		private SampleDateTimeFunctions[] cacheSampleDateTimeFunctions;
		public SampleDateTimeFunctions SampleDateTimeFunctions()
		{
			return SampleDateTimeFunctions(Input);
		}

		public SampleDateTimeFunctions SampleDateTimeFunctions(ISeries<double> input)
		{
			if (cacheSampleDateTimeFunctions != null)
				for (int idx = 0; idx < cacheSampleDateTimeFunctions.Length; idx++)
					if (cacheSampleDateTimeFunctions[idx] != null &&  cacheSampleDateTimeFunctions[idx].EqualsInput(input))
						return cacheSampleDateTimeFunctions[idx];
			return CacheIndicator<SampleDateTimeFunctions>(new SampleDateTimeFunctions(), input, ref cacheSampleDateTimeFunctions);
		}
	}
}

namespace NinjaTrader.NinjaScript.MarketAnalyzerColumns
{
	public partial class MarketAnalyzerColumn : MarketAnalyzerColumnBase
	{
		public Indicators.SampleDateTimeFunctions SampleDateTimeFunctions()
		{
			return indicator.SampleDateTimeFunctions(Input);
		}

		public Indicators.SampleDateTimeFunctions SampleDateTimeFunctions(ISeries<double> input )
		{
			return indicator.SampleDateTimeFunctions(input);
		}
	}
}

namespace NinjaTrader.NinjaScript.Strategies
{
	public partial class Strategy : NinjaTrader.Gui.NinjaScript.StrategyRenderBase
	{
		public Indicators.SampleDateTimeFunctions SampleDateTimeFunctions()
		{
			return indicator.SampleDateTimeFunctions(Input);
		}

		public Indicators.SampleDateTimeFunctions SampleDateTimeFunctions(ISeries<double> input )
		{
			return indicator.SampleDateTimeFunctions(input);
		}
	}
}

#endregion
