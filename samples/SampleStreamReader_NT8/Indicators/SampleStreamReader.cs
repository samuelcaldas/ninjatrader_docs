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

// Add this to your declarations to use StreamReader
using System.IO;

// This namespace holds all indicators and is required. Do not change it.
namespace NinjaTrader.NinjaScript.Indicators
{
    public class SampleStreamReader : Indicator
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
		private string path;
		
		// Creates a StreamReader object
		private StreamReader sr;
        #endregion

        protected override void OnStateChange()
        {
			if(State == State.SetDefaults)
			{
				Calculate			= Calculate.OnBarClose;
				Name				= "Sample stream reader";
				
				date				= 0;
				currentOpen			= 0;
				currentHigh			= 0;
				currentLow			= 0;
				currentClose		= 0;
				currentOpenSaved 	= false;
				currentLowSaved 	= false;
				path 				= NinjaTrader.Core.Globals.UserDataDir + "MyTestFile.txt";
			}
			else if(State == State.Historical)
			{
				return;
			}
			else if(State == State.Terminated)
			{
				// Necessary to call in order to clean up resources used by the StreamReader object		
				// Disposes resources used by the StreamReader
				if (sr != null)
				{
					sr.Dispose();
					sr = null;
				}
			}
        }

        protected override void OnBarUpdate()
        {
			// Checks to see if the file exists
			if (!File.Exists(path))
			{
				// If file does not exist, let the user know
				Print("File does not exist.");
				return;
			}
			
			/* The try-catch block is used for error handling.
			In this case it is used to ensure you only have one stream object operating on the same file at any given moment. */
			try
			{
				// Sets the file the StreamReader will read from
				sr = new System.IO.StreamReader(path);

				string line;
				
				// Read lines and calculate the current day's OHLC from the file. While loop will go through the whole file.
				while ((line = sr.ReadLine()) != null) 
				{
					// Splits the line at every white space. Places each split into the string array
					string[] split = line.Split(new char[] {','});
					
					// Creates a counter that will mark which string from the split array we are dealing with
					int splitCounter = 0;
					
					// For every string inside the newly created string array...
					foreach (string s in split)
					{
						splitCounter++;
						
						// First string = Date of the OHLC data on the following 4 strings
						if (splitCounter == 1)
							date = ToDay(DateTime.Parse(s));
						
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
					}
				}
				Print("Current Day OHLC: " + currentOpen + " " + currentHigh + " " + currentLow + " " + currentClose);
			}
			catch (Exception e)
			{
				// Outputs the error to the log
				Log("You cannot write and read from the same file at the same time. Please remove SampleStreamWriter.", NinjaTrader.Cbi.LogLevel.Error);
				Print(e.ToString());
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
		private SampleStreamReader[] cacheSampleStreamReader;
		public SampleStreamReader SampleStreamReader()
		{
			return SampleStreamReader(Input);
		}

		public SampleStreamReader SampleStreamReader(ISeries<double> input)
		{
			if (cacheSampleStreamReader != null)
				for (int idx = 0; idx < cacheSampleStreamReader.Length; idx++)
					if (cacheSampleStreamReader[idx] != null &&  cacheSampleStreamReader[idx].EqualsInput(input))
						return cacheSampleStreamReader[idx];
			return CacheIndicator<SampleStreamReader>(new SampleStreamReader(), input, ref cacheSampleStreamReader);
		}
	}
}

namespace NinjaTrader.NinjaScript.MarketAnalyzerColumns
{
	public partial class MarketAnalyzerColumn : MarketAnalyzerColumnBase
	{
		public Indicators.SampleStreamReader SampleStreamReader()
		{
			return indicator.SampleStreamReader(Input);
		}

		public Indicators.SampleStreamReader SampleStreamReader(ISeries<double> input )
		{
			return indicator.SampleStreamReader(input);
		}
	}
}

namespace NinjaTrader.NinjaScript.Strategies
{
	public partial class Strategy : NinjaTrader.Gui.NinjaScript.StrategyRenderBase
	{
		public Indicators.SampleStreamReader SampleStreamReader()
		{
			return indicator.SampleStreamReader(Input);
		}

		public Indicators.SampleStreamReader SampleStreamReader(ISeries<double> input )
		{
			return indicator.SampleStreamReader(input);
		}
	}
}

#endregion
