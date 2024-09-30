
NinjaScript \> Language Reference \> Common \> Analytical \> GetCurrentAskVolume()
GetCurrentAskVolume()
| \<\< [Click to Display Table of Contents](getcurrentaskvolume.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Analytical](market_data.md) \> GetCurrentAskVolume() | [Previous page](getcurrentask.md) [Return to chapter overview](market_data.md) [Next page](getcurrentbid.md) |
| --- | --- |
## Definition
Returns the current real\-time ask volume.
## 
| Notes:  1\. When accessed during State.Historical, the [Volume](volume.md) of the evaluated bar series is substituted.  To access historical Ask Volumes, please see [Developing for Tick Replay](developing_for__tick_replay.md). 2\. The GetCurrentAskVolume() method runs on the bar series currently updating determined by the [BarsInProgress](barsinprogress.md) property.  For [multi\-instrument](multi-time_frame__instruments.md) scripts, an additional int "barsSeriesIndex" parameter can be supplied which forces the method to run on an supplementary bar series. |
| --- |
## 
## 
## Method Return Value
A long value representing the current ask volume.
 
Syntax  

GetCurrentAskVolume()  

GetCurrentAskVolume(int barsSeriesIndex)
 
## Parameters
| barsSeriesIndex | An int value determining the bar series the method runs. Note:  This optional parameter is reserved for multi\-instrument scripts |
| --- | --- |
## 
## 
## Examples
| ns |
| --- |
| protected override void OnBarUpdate() {    long currentAskVolume \= GetCurrentAskVolume();    Print("The Current Ask volume is: " \+ currentAskVolume);    //The Current Ask volume is: 158          } |

| ns |
| --- |
| protected override void OnStateChange() {          if (State \=\= State.SetDefaults)    {      Name \= "Examples Indicator";       }    if (State \=\= State.Configure)    {      //Add MSFT as our additional data series      AddDataSeries("MSFT", BarsPeriodType.Minute, 1);    } }      protected override void OnBarUpdate() {             if(BarsInProgress \=\= 0)    {      long currentAskVolume \= GetCurrentAskVolume(0);      Print("The Current Ask volume is: " \+ currentAskVolume);      //The Current Ask volume is: 346    }        if(BarsInProgress \=\= 1)    {      long msftAskVolume \= GetCurrentAskVolume(1);      Print("MSFT's Current Ask volume is: " \+ msftAskVolume);      //MSFT's Current Ask volume is: 1548    }          } |

