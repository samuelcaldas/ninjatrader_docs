// Copyright (C) 2018, NinjaTrader LLC <www.ninjatrader.com>.
// NinjaTrader reserves the right to modify or overwrite this NinjaScript component with each release.

#region Using declarations
using System;
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

// Add this to the declarations. It allows for the use of ArrayLists. (Used in the Level II book creation process.)
using System.Collections.Generic;

//This namespace holds Indicators in this folder and is required. Do not change it. 
namespace NinjaTrader.NinjaScript.Indicators
{
	public class SampleCustomEvents : Indicator
	{
		private	List<LadderRow>		askRows	= new List<LadderRow>();
		private	List<LadderRow>		bidRows	= new List<LadderRow>();
		
		private bool firstAskEvent	= true;
		private bool firstBidEvent	= true;
		
		// Declare the WPF dispatcher timer
		private System.Timers.Timer myTimer;
		
		protected override void OnStateChange()
		{
			if (State == State.SetDefaults)
			{
				Description					= @"Using custom events to output the current Level II data book.";
				Name						= "Sample custom events";
				Calculate					= Calculate.OnBarClose;
				IsOverlay					= true;
				DisplayInDataBox			= true;
				DrawOnPricePanel			= true;
				DrawHorizontalGridLines		= true;
				DrawVerticalGridLines		= true;
				PaintPriceMarkers			= true;
				IsDataSeriesRequired		= true;
				ScaleJustification			= NinjaTrader.Gui.Chart.ScaleJustification.Right;
				//Uncomment the below line if you wish to take advantage of CPU savings by suspending the indicator
				//when it is not in use. You should only do this if your indicator is not reliant on processing in
				//real-time and would process the same historically vs. real-time since all indicator functionality
				//will be paused when suspended (including alerts and outputs).
				//For more information, please see the Help Guide on IsSuspendedWhileInactive
				//IsSuspendedWhileInactive	= true;
			}
			else if (State == State.DataLoaded)
			{
				// Instantiates the timer and sets the interval to 1 seconds.
				myTimer = new System.Timers.Timer(1000);
		  		myTimer.Elapsed += TimerEventProcessor;
				myTimer.Enabled = true;
			}
			else if (State == State.Terminated)
			{
		  		// Stops the timer and removes the timer event handler
				if (myTimer != null)
				{
			  		myTimer.Enabled = false;
			  		myTimer.Elapsed -= TimerEventProcessor;
					myTimer = null;
				}
			}
		}
		
		// This collapsed section contains code to generate your own Level II book as shown in the SampleMarketDepth reference.
		#region Level II Book
		/// <summary>
		/// This class holds a row of the bid or ask ladder.
		/// </summary>
		private class LadderRow
		{
			public	string	MarketMaker;			// relevant for stocks only
			public	double	Price;
			public	long	Volume;

			public LadderRow(double myPrice, long myVolume, string myMarketMaker)
			{
				MarketMaker	= myMarketMaker;
				Price		= myPrice;
				Volume		= myVolume;
			}
		}
		
		protected override void OnMarketDepth(MarketDepthEventArgs e)
		{
			List<LadderRow> rows = null;

			// Checks to see if the Market Data is of the Ask type
			if (e.MarketDataType == MarketDataType.Ask)
			{
				rows = askRows;
				
				// Due to race conditions, it is possible the first event is an Update operation instead of an Insert. When this happens, populate your Lists via e.MarketDepth first.
				if (firstAskEvent)
				{
					if (e.Operation == Operation.Update)
					{
						// Lock the MarketDepth collection to prevent modification to the collection while we are still processing it
						lock (e.Instrument.MarketDepth.Asks)
						{
							for (int idx = 0; idx < e.Instrument.MarketDepth.Asks.Count; idx++)
								rows.Add(new LadderRow(e.Instrument.MarketDepth.Asks[idx].Price, e.Instrument.MarketDepth.Asks[idx].Volume, e.Instrument.MarketDepth.Asks[idx].MarketMaker));
						}
					}
					firstAskEvent = false;
				}
			}
			
			// Checks to see if the Market Data is of the Bid type
			else if (e.MarketDataType == MarketDataType.Bid)
			{
				rows = bidRows;
				
				// Due to race conditions, it is possible the first event is an Update operation instead of an Insert. When this happens, populate your Lists via e.MarketDepth first.
				if (firstBidEvent)
				{
					if (e.Operation == Operation.Update)
					{
						// Lock the MarketDepth collection to prevent modification to the collection while we are still processing it
						lock (e.Instrument.MarketDepth.Bids)
						{
							for (int idx = 0; idx < e.Instrument.MarketDepth.Bids.Count; idx++)
								rows.Add(new LadderRow(e.Instrument.MarketDepth.Bids[idx].Price, e.Instrument.MarketDepth.Bids[idx].Volume, e.Instrument.MarketDepth.Bids[idx].MarketMaker));
						}
					}
					firstBidEvent = false;
				}
			}

			if (rows == null)
				return;

			// Checks to see if the action taken was an insertion into the ladder
			if (e.Operation == Operation.Add)
			{
				// Add a new row at the end if the designated position is greater than our current ladder size
				if (e.Position >= rows.Count)
					rows.Add(new LadderRow(e.Price, e.Volume, e.MarketMaker));
				
				// Insert a new row into our ladder at the designated position
				else
					rows.Insert(e.Position, new LadderRow(e.Price, e.Volume, e.MarketMaker));
			}
			
			/* Checks to see if the action taken was a removal of itself from the ladder
			Note: Due to the multi threaded architecture of the NT core, race conditions could occur
			-> check if e.Position is within valid range */
			else if (e.Operation == Operation.Remove && e.Position < rows.Count)
				rows.RemoveAt(e.Position);
			
			/* Checks to see if the action taken was to update a data already on the ladder
			Note: Due to the multi threaded architecture of the NT core, race conditions could occur
			-> check if e.Position is within valid range */
			else if (e.Operation == Operation.Update && e.Position < rows.Count)
			{
				rows[e.Position].MarketMaker	= e.MarketMaker;
				rows[e.Position].Price			= e.Price;
				rows[e.Position].Volume			= e.Volume;
			}
		}
		#endregion

		protected override void OnBarUpdate()
		{
			// Your custom OnBarUpdate logic would be placed in here
		}
		
		// Timer's elapsed event handler. Called at every tick of 1000ms.
		private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
		{
			/* Important to use the TriggerCustomEvent() to ensure that NinjaScript indexes and pointers are correctly set.
			Do not process your code here. Process your code in the MyCustomHandler method. */
			TriggerCustomEvent(MyCustomHandler, 0, myTimer.Interval);
		}
		
		private void MyCustomHandler(object state)
		{
			// Informs us of when the event was triggered and of our Timer settings
			Print("\tTime: " + DateTime.Now);
			Print("\tTimer Interval: " + state.ToString() + "ms");
			
			// Prints the L2 Ask Book we created. Cycles through the whole List and prints the contained objects.
			Print("Ask Book: ");
			for (int idx = 0; idx < askRows.Count; idx++)
				Print("Ask Price=" + askRows[idx].Price + " Volume=" + askRows[idx].Volume + " Position=" + idx);
			
			// Prints the L2 Bid Book we created. Cycles through the whole List and prints the contained objects.
			Print("Bid Book: ");
			for (int idx = 0; idx < bidRows.Count; idx++)
				Print("Bid Price=" + bidRows[idx].Price + " Volume=" + bidRows[idx].Volume + " Position=" + idx);
		}

	}
}

#region NinjaScript generated code. Neither change nor remove.

namespace NinjaTrader.NinjaScript.Indicators
{
	public partial class Indicator : NinjaTrader.Gui.NinjaScript.IndicatorRenderBase
	{
		private SampleCustomEvents[] cacheSampleCustomEvents;
		public SampleCustomEvents SampleCustomEvents()
		{
			return SampleCustomEvents(Input);
		}

		public SampleCustomEvents SampleCustomEvents(ISeries<double> input)
		{
			if (cacheSampleCustomEvents != null)
				for (int idx = 0; idx < cacheSampleCustomEvents.Length; idx++)
					if (cacheSampleCustomEvents[idx] != null &&  cacheSampleCustomEvents[idx].EqualsInput(input))
						return cacheSampleCustomEvents[idx];
			return CacheIndicator<SampleCustomEvents>(new SampleCustomEvents(), input, ref cacheSampleCustomEvents);
		}
	}
}

namespace NinjaTrader.NinjaScript.MarketAnalyzerColumns
{
	public partial class MarketAnalyzerColumn : MarketAnalyzerColumnBase
	{
		public Indicators.SampleCustomEvents SampleCustomEvents()
		{
			return indicator.SampleCustomEvents(Input);
		}

		public Indicators.SampleCustomEvents SampleCustomEvents(ISeries<double> input )
		{
			return indicator.SampleCustomEvents(input);
		}
	}
}

namespace NinjaTrader.NinjaScript.Strategies
{
	public partial class Strategy : NinjaTrader.Gui.NinjaScript.StrategyRenderBase
	{
		public Indicators.SampleCustomEvents SampleCustomEvents()
		{
			return indicator.SampleCustomEvents(Input);
		}

		public Indicators.SampleCustomEvents SampleCustomEvents(ISeries<double> input )
		{
			return indicator.SampleCustomEvents(input);
		}
	}
}

#endregion
