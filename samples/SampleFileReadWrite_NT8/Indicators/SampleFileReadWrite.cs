// 
// Copyright (C) 2007, NinjaTrader LLC <www.ninjatrader.com>.
// NinjaTrader reserves the right to modify or overwrite this NinjaScript component with each release.
//
#region Using declarations
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Xml.Serialization;
#endregion

// Add this to your declarations to use StreamWriter and StreamReader
using System.IO;

// This namespace holds all indicators and is required. Do not change it.
namespace NinjaTrader.NinjaScript.Indicators
{
    public class SampleFileReadWrite : Indicator
    {
        #region Variables
		private int		date;
		private double	currentOpen;
		private double	currentHigh;
		private double	currentLow;
		private double	currentClose;
		private bool	currentOpenSaved;
		private bool	currentLowSaved;
		
		// This sets the path in which the text file will be created.
		private string	path;
        #endregion

        protected override void OnStateChange()
        {
			if(State == State.SetDefaults)
			{
	            Calculate = Calculate.OnBarClose;
	            IsOverlay			= false;
				Name				= "Sample file read write";
				date				= 0;
				currentOpen			= 0;
				currentHigh			= 0;
				currentLow			= 0;
				currentClose		= 0;
				currentOpenSaved 	= false;
				currentLowSaved		= false;
				path				= NinjaTrader.Core.Globals.UserDataDir + "SampleFileReadWrite-MyTestFile.txt";				
			}
			else if(State == State.Historical)
			{
				return;
			}
        }

        protected override void OnBarUpdate()
        {
			// This is the output string that is written to the text file. 'Environment.NewLine' feeds the file to a new line for further writing.
			string ohlc = ToDay(Time[0]) + " " + Open[0] + " " + High[0] + " " + Low[0] + " " + Close[0] + Environment.NewLine;
			
			/* Creates the text file at the location determined in 'path' and puts the line 'ohlc' in.
			If file already exists it will append the line 'ohlc' onto the end. */
			File.AppendAllText(path, ohlc);
		
			// Opens the text file and reads all lines into a string. It will then close the file.
			string readText = File.ReadAllText(path);
			
			/* Splits the line at every white space and new line. Places each split into the string array.
			' ' represents a space, '\r' represents carriage returns, '\n' represents line feeds 
			We skip the newlines (empty entries) with StringSplitOptions.RemoveEmptyEntries
			*/
			string[] split = readText.Split(new char[] {' ', '\r', '\n'}, StringSplitOptions.RemoveEmptyEntries);
			
			// Creates a counter that will mark which string from the split array we are dealing with
			int splitCounter = 0;
			
			// For every string inside the newly created string array...
			foreach (string s in split)
			{
				splitCounter++;
				
				// First string = Date of the OHLC data on the following 4 strings
				if (splitCounter == 1)
					date = int.Parse(s);
				
				// Check if the date of the data from file is the same as the date of the current bar
				if (ToDay(Time[0]) == date)
				{
					// Saves the first Open value of the current date
					if (splitCounter == 2 && currentOpenSaved == false)
					{
						currentOpen = double.Parse(s);
						
						// Unnecessary to save any other Open value's because they aren't the Open for the current date
						currentOpenSaved = true;
					}
					
					// Saves the High value of the current date. Overwrites old values if new value is higher
					else if (splitCounter == 3 && double.Parse(s) > currentHigh)
						currentHigh = double.Parse(s);

					// Saves the Low value of the current date
					else if (splitCounter == 4)
					{
						// Overwrites old values if new value is lower
						if (double.Parse(s) < currentLow)
							currentLow = double.Parse(s);
						
						// Initializes the first Low value because currentLow is defaulted at 0 and nothing will be lower than that
						else if (currentLowSaved == false)
						{
							currentLow = double.Parse(s);
							currentLowSaved = true;
						}
					}
					
					// Saves the Close value of the current date.
					else if (splitCounter == 5)
						currentClose = double.Parse(s);
				}
				
				// Resets the split counter for the next line read from the file
				if (splitCounter == 5)
					splitCounter = 0;
				
				// Print to the Output Window the day's OHLC as calculated from the text file
				Print("Current Day OHLC: " + currentOpen + " " + currentHigh + " " + currentLow + " " + currentClose);
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
		private SampleFileReadWrite[] cacheSampleFileReadWrite;
		public SampleFileReadWrite SampleFileReadWrite()
		{
			return SampleFileReadWrite(Input);
		}

		public SampleFileReadWrite SampleFileReadWrite(ISeries<double> input)
		{
			if (cacheSampleFileReadWrite != null)
				for (int idx = 0; idx < cacheSampleFileReadWrite.Length; idx++)
					if (cacheSampleFileReadWrite[idx] != null &&  cacheSampleFileReadWrite[idx].EqualsInput(input))
						return cacheSampleFileReadWrite[idx];
			return CacheIndicator<SampleFileReadWrite>(new SampleFileReadWrite(), input, ref cacheSampleFileReadWrite);
		}
	}
}

namespace NinjaTrader.NinjaScript.MarketAnalyzerColumns
{
	public partial class MarketAnalyzerColumn : MarketAnalyzerColumnBase
	{
		public Indicators.SampleFileReadWrite SampleFileReadWrite()
		{
			return indicator.SampleFileReadWrite(Input);
		}

		public Indicators.SampleFileReadWrite SampleFileReadWrite(ISeries<double> input )
		{
			return indicator.SampleFileReadWrite(input);
		}
	}
}

namespace NinjaTrader.NinjaScript.Strategies
{
	public partial class Strategy : NinjaTrader.Gui.NinjaScript.StrategyRenderBase
	{
		public Indicators.SampleFileReadWrite SampleFileReadWrite()
		{
			return indicator.SampleFileReadWrite(Input);
		}

		public Indicators.SampleFileReadWrite SampleFileReadWrite(ISeries<double> input )
		{
			return indicator.SampleFileReadWrite(input);
		}
	}
}

#endregion
