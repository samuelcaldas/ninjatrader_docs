


NinjaScript \> Language Reference \> Common \> Bars \> GetTime()






















GetTime()







| \<\< [Click to Display Table of Contents](gettime.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [Bars](bars-1.md) \> GetTime() | [Previous page](getsessionendtime-1.md) [Return to chapter overview](bars-1.md) [Next page](getvolume-1.md) |
| --- | --- |











## Definition


Returns the time stamp at the current bar index value.


 




| Note: This method will return what is displayed in the chart's data box.  For formatting purposes, the value returned is NOT guaranteed be equal to the [TimeSeries](timeseries-1.md) value.  If you are using daily bars and need the session end time, you should use [Bars.GetSessionEndTime()](getsessionendtime-1.md) instead. |
| --- |



 


 


## Method Return Value


A DateTime structure that represents the time stamp at the desired bar index.


## 


## Syntax


Bars.GetTime(int index)


 


## Parameters




| index | An int representing an absolute bar index value |
| --- | --- |



 


 


## Examples




| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale) {    base.OnRender(chartControl, chartScale);    // loop through only the rendered bars on the chart    for(int barIndex \= ChartBars.FromIndex; barIndex \<\= ChartBars.ToIndex; barIndex\+\+)    {      // get the time stamp at the selected bar index value      DateTime timeValue \= Bars.GetTime(barIndex);      Print("Bar \#" \+ barIndex \+ " time stamp is " \+ timeValue);    } } |









