



GetCurrentBid()

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\getcurrentbid.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [Analytical](market_data-1.htm) >  GetCurrentBid() | [Previous page](getcurrentaskvolume-1.htm) [Return to chapter overview](market_data-1.htm) [Next page](getcurrentbidvolume-1.htm) |

Definition
----------

Returns the current real-time bid price.

|  |
| --- |
| Notes:  1. When accessed during State.Historical, the [Close](close-1.htm) price of the evaluated bar is substituted.  To access historical bid prices, please see [Developing for Tick Replay](developing_for__tick_replay-1.htm).  2. The GetCurrentBid() method runs on the bar series currently updating determined by the [BarsInProgress](barsinprogress-1.htm) property.  For [multi-instrument](multi-time_frame__instruments-1.htm) scripts, an additional int "barsSeriesIndex" parameter can be supplied which forces the method to run on an supplementary bar series. |

Method Return Value
-------------------

A double value representing the current bid price.

Syntax  
GetCurrentBid()  
GetCurrentBid(int barsSeriesIndex)

 

Parameters
----------

|  |  |
| --- | --- |
| barsSeriesIndex | An int value determining the bar series the method runs. Note:  This optional parameter is reserved for multi-instrument scripts |

Examples
--------

| ns |
| --- |
| protected override void OnBarUpdate()  {     // Ensure we do not call GetCurrentBid() on historical data     if (State == State.Historical)       return;        double currentBid = GetCurrentBid();     Print("The Current Bid price is: " + currentBid);     // The Current Bid price is: 1924.75  } |

 

 

| ns |
| --- |
| protected override void OnStateChange()  {     if (State == State.SetDefaults)     {       Name = "Example's Indicator";     }     if (State == State.Configure)     {       //Add MSFT as our additional data series       AddDataSeries("MSFT", BarsPeriodType.Minute, 1);     }  }     protected override void OnBarUpdate()  {     // Ensure we do not call GetCurrentBid() on historical data     if (State == State.Historical)       return;        if (BarsInProgress == 0)     {       double primaryBid = GetCurrentBid(0);       Print("The Primary Bid price is: " + primaryBid);       // The Primary Bid price is: 1924.75     }        if (BarsInProgress == 1)     {       double msftBid = GetCurrentBid(1);       Print("MSFT's Current Bid price is: " + msftBid);       // MSFT's Current Bid is: 43.63     }  } |