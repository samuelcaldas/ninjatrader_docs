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

// This namespace holds all indicators and is required. Do not change it.
namespace NinjaTrader.NinjaScript.Indicators
{
	public class SampleLevel2Book : Indicator
    {
		private	List<LadderRow>	askRows	    = new List<LadderRow>(10);
		private	List<LadderRow>	bidRows	    = new List<LadderRow>(10);
		
		private bool firstAskEvent	        = true;
		private bool firstBidEvent	        = true;

        private class LadderRow
        {
            public	string	MarketMaker; // relevant for stocks only
            public	double	Price;
            public	long	Volume;
        }

        protected override void OnStateChange()
        {
			if(State == State.SetDefaults)
			{
	            Description					= @"Sample Getting the depth of market";
				Name                        = "Sample level2 book";
				Calculate					= Calculate.OnEachTick;
				IsOverlay					= false;
				DisplayInDataBox			= true;
				DrawOnPricePanel			= false;
				DrawHorizontalGridLines		= true;
				DrawVerticalGridLines		= true;
				PaintPriceMarkers			= true;
				ScaleJustification			= ScaleJustification.Right;
			}
			
			else if(State == State.Historical)
			{
				// Since the L2 data is only stored on real-time bars, there is no need to print L2 books on historical data
				return;
			}
        }

        protected override void OnBarUpdate()
        {
			//When the Close price crosses over the SMA, print the L2 books.
			if (CrossAbove(Close, SMA(5), 1))
			{
                ClearOutputWindow();
				// Prints the L2 Ask Book we created. Cycles through the whole List and prints the contained objects.
				Print("Ask Book");
				for (int idx = 0; idx < askRows.Count; idx++)
					Print("Ask Price=" + askRows[idx].Price + " Volume=" + askRows[idx].Volume + " Position=" + idx);
				
				// Prints the L2 Bid Book we created. Cycles through the whole List and prints the contained objects.
				Print("Bid Book");
				for (int idx = 0; idx < bidRows.Count; idx++)
					Print("Bid Price=" + bidRows[idx].Price + " Volume=" + bidRows[idx].Volume + " Position=" + idx);
			}
        }

        protected override void OnMarketDepth(MarketDepthEventArgs e)
        {
			// protect e.Instrument.MarketDepth.Asks and e.Instrument.MarketDepth.Bids against in-flight changes
			lock (e.Instrument.SyncMarketDepth)
			{
	            List<LadderRow> rows	= (e.MarketDataType == MarketDataType.Ask ? askRows: bidRows);
				LadderRow row			= new LadderRow { MarketMaker = e.MarketMaker, Price = e.Price, Volume = e.Volume };

	            if (e.Operation == Operation.Add || (e.Operation == Operation.Update && (rows.Count == 0 || rows.Count <= e.Position)))
				{
					if (rows.Count <= e.Position)
						rows.Add(row);
					else
						rows.Insert(e.Position, row);
				}
	            else if (e.Operation == Operation.Remove && rows.Count > e.Position)
				{
	                rows.RemoveAt(e.Position);
				}
	            else if (e.Operation == Operation.Update)
	            {
					if (rows[e.Position] == null)
					{
						rows[e.Position] = row;
					}
					else
					{
						rows[e.Position].MarketMaker	= e.MarketMaker;
						rows[e.Position].Price			= e.Price;
						rows[e.Position].Volume			= e.Volume;
					}
	            }
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
		private SampleLevel2Book[] cacheSampleLevel2Book;
		public SampleLevel2Book SampleLevel2Book()
		{
			return SampleLevel2Book(Input);
		}

		public SampleLevel2Book SampleLevel2Book(ISeries<double> input)
		{
			if (cacheSampleLevel2Book != null)
				for (int idx = 0; idx < cacheSampleLevel2Book.Length; idx++)
					if (cacheSampleLevel2Book[idx] != null &&  cacheSampleLevel2Book[idx].EqualsInput(input))
						return cacheSampleLevel2Book[idx];
			return CacheIndicator<SampleLevel2Book>(new SampleLevel2Book(), input, ref cacheSampleLevel2Book);
		}
	}
}

namespace NinjaTrader.NinjaScript.MarketAnalyzerColumns
{
	public partial class MarketAnalyzerColumn : MarketAnalyzerColumnBase
	{
		public Indicators.SampleLevel2Book SampleLevel2Book()
		{
			return indicator.SampleLevel2Book(Input);
		}

		public Indicators.SampleLevel2Book SampleLevel2Book(ISeries<double> input )
		{
			return indicator.SampleLevel2Book(input);
		}
	}
}

namespace NinjaTrader.NinjaScript.Strategies
{
	public partial class Strategy : NinjaTrader.Gui.NinjaScript.StrategyRenderBase
	{
		public Indicators.SampleLevel2Book SampleLevel2Book()
		{
			return indicator.SampleLevel2Book(Input);
		}

		public Indicators.SampleLevel2Book SampleLevel2Book(ISeries<double> input )
		{
			return indicator.SampleLevel2Book(input);
		}
	}
}

#endregion
