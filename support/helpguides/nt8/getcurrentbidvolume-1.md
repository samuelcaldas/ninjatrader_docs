﻿
NinjaScript > Language Reference > Common > Analytical > GetCurrentBidVolume()
GetCurrentBidVolume()
| << [Click to Display Table of Contents](getcurrentbidvolume.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [Analytical](market_data-1.md) > GetCurrentBidVolume() | [Previous page](getcurrentbid-1.md) [Return to chapter overview](market_data-1.md) [Next page](getmedian-1.md) |
| --- | --- |
## Definition
Returns the current real-time bid volume.
## 
| Notes:  1. When accessed during State.Historical, the [Volume](volume-1.md) of the evaluated bar series is substituted.  To access historical Bid Volumes, please see [Developing for Tick Replay](developing_for__tick_replay-1.md). 2. The GetCurrentBidVolume() method runs on the bar series currently updating determined by the [BarsInProgress](barsinprogress-1.md) property.  For [multi-instrument](multi-time_frame__instruments-1.md) scripts, an additional int "barsSeriesIndex" parameter can be supplied which forces the method to run on an supplementary bar series. |
| --- |
## 
## 
## Method Return Value
A long value representing the current bid volume.
 
Syntax  

GetCurrentBidVolume()  

GetCurrentBidVolume(int barsSeriesIndex)
 
## Parameters
| barsSeriesIndex | An int value determining the bar series the method runs. Note:  This optional parameter is reserved for multi-instrument scripts |
| --- | --- |
## 
## 
## Examples
| ns |
| --- |
| protected override void OnBarUpdate() {    long currentBidVolume = GetCurrentBidVolume();    Print("The Current Bid volume is: " + currentBidVolume);    //The Current Bid volume is: 158          } |

| ns |
| --- |
| protected override void OnStateChange() {          if (State == State.SetDefaults)    {      Name = "Examples Indicator";       }    if (State == State.Configure)    {      //Add MSFT as our additional data series      AddDataSeries("MSFT", BarsPeriodType.Minute, 1);    } }      protected override void OnBarUpdate() {             if(BarsInProgress == 0)    {      long currentBidVolume = GetCurrentBidVolume(0);      Print("The Current Bid volume is: " + currentBidVolume);      //The Current Bid volume is: 346    }        if(BarsInProgress == 1)    {      long msftBidVolume = GetCurrentBidVolume(1);      Print("MSFT's Current Bid volume is: " + msftBidVolume);      //MSFT's Current Bid volume is: 1548    }          } |

