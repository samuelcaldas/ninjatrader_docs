// 
// Copyright (C) 2007, NinjaTrader LLC <www.ninjatrader.com>.
// NinjaTrader reserves the right to modify or overwrite this NinjaScript component with each release.
//
#region Using declarations
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Xml.Serialization;
using NinjaTrader.Cbi;
using NinjaTrader.Data;
using NinjaTrader.Gui.Chart;
#endregion

// This namespace holds all indicators and is required. Do not change it.
namespace NinjaTrader.NinjaScript.Indicators
{
    public class SampleStringFunctions : Indicator
    {       
        protected override void OnStateChange()
        {
			if(State == State.SetDefaults)
			{
				Calculate				= Calculate.OnPriceChange;
           	 	IsOverlay				= false;
				Name					= "Sample string functions";
			}
        }

        /// <summary>
        /// Called on each bar update event (incoming tick)
        /// </summary>
        protected override void OnBarUpdate()
        {			
        	if (CurrentBar == 0)
			{				
				// This command clears all data from the output window.
				ClearOutputWindow();
				
				// This command will just print a blank line in the output window.
				Print("");
			
				
				/* C# requires certain characters to be "escaped". An escape character is used to tell a computer program
				   the character following it has a different meaning than usual. For example, if you wanted to print quotes in a string, you couldn't do:
				   Print("Joe said, "Hey Bob!""); because when the program reached the second ", it would read that as the end of the string and give an error.
				   Instead, you would escape the double quotes with a backslash "\" like this: Print("Joe said, \"Hey Bob!\"");
				   In the example below, \ is a character that needs an escape character preceding it, resulting in \\.
				   Another option would be to specify the string as literal, with the @ sign-useful for specifying directories.
				   The two strings below will print the exact same output. */
				string directory = @"C:\NinjaTrader 8\bin";
				string directory2 = "C:\\NinjaTrader 8\\bin";
				Print(directory);
				Print(directory2);
				
				
				// Print another blank line
				Print("");
				
				
				// Split a string at each space using the following string.
				string s = "NinjaTrader is a trading platform.";
				
				// To define a single character, it is necessary to use single quotes (') instead of double quotes (").
				char aSpace = ' ';
				
				// Create a string array and fill it with the words that come from from splitting string s at each space.
				string[] words = s.Split(aSpace);
				
				// Print each element (word) from the array (words).
				foreach (string word in words)
					Print(word);
				
				
				// Print another blank line
				Print("");

				
				// Finding a string
				Print("Find the position of \"needle\" in the phrase: \"Like finding a needle in a haystack.\"");
				string phrase = "Like finding a needle in a haystack.";
				string whatToFind = "needle";
				
				// string.IndexOf will return the position of the string by character. This example will return 15 because "needle" starts at the 15th character in the string.
				int idx = phrase.IndexOf(whatToFind);
				Print("Index of \"needle\": "  + idx);

				
				// Replacing a string, we'll use the phrase above "Like finding a needle in a haystack."
				Print("");
				Print("From the phrase above, replace \"haystack\" with \"some big field\".");
				
				// string.Replace takes the string to find as the first argument and the string to replace with as the second argument.
				phrase = phrase.Replace("haystack", "some big field");
				Print(phrase);
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
		private SampleStringFunctions[] cacheSampleStringFunctions;
		public SampleStringFunctions SampleStringFunctions()
		{
			return SampleStringFunctions(Input);
		}

		public SampleStringFunctions SampleStringFunctions(ISeries<double> input)
		{
			if (cacheSampleStringFunctions != null)
				for (int idx = 0; idx < cacheSampleStringFunctions.Length; idx++)
					if (cacheSampleStringFunctions[idx] != null &&  cacheSampleStringFunctions[idx].EqualsInput(input))
						return cacheSampleStringFunctions[idx];
			return CacheIndicator<SampleStringFunctions>(new SampleStringFunctions(), input, ref cacheSampleStringFunctions);
		}
	}
}

namespace NinjaTrader.NinjaScript.MarketAnalyzerColumns
{
	public partial class MarketAnalyzerColumn : MarketAnalyzerColumnBase
	{
		public Indicators.SampleStringFunctions SampleStringFunctions()
		{
			return indicator.SampleStringFunctions(Input);
		}

		public Indicators.SampleStringFunctions SampleStringFunctions(ISeries<double> input )
		{
			return indicator.SampleStringFunctions(input);
		}
	}
}

namespace NinjaTrader.NinjaScript.Strategies
{
	public partial class Strategy : NinjaTrader.Gui.NinjaScript.StrategyRenderBase
	{
		public Indicators.SampleStringFunctions SampleStringFunctions()
		{
			return indicator.SampleStringFunctions(Input);
		}

		public Indicators.SampleStringFunctions SampleStringFunctions(ISeries<double> input )
		{
			return indicator.SampleStringFunctions(input);
		}
	}
}

#endregion
