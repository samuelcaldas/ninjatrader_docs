


NinjaScript \> Language Reference \> Common \> Charts \> ChartControl \> GetTimeByX()






















GetTimeByX()







| \<\< [Click to Display Table of Contents](gettimebyx.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [Charts](chart-1.md) \> [ChartControl](chartcontrol-1.md) \> GetTimeByX() | [Previous page](gettimebyslotindex-1.md) [Return to chapter overview](chartcontrol-1.md) [Next page](getxbybarindex-1.md) |
| --- | --- |











## Definition


Returns a time value related to the primary [Bars](bars-1.md)' slot index at a specified x\-coordinate relative to the ChartControl.


 




| Note:  Since the time is based upon a coordinate of the chart canvas, the value returned by GetTimeByX() can be expected to change as new bars are painted on the chart, or as the chart is scrolled backward or forward on the x\-axis. |
| --- |



 


 


## Method Return Value


A [DateTime](https://msdn.microsoft.com/en-us/library/system.datetime(v=vs.110).aspx) object corresponding to a slot index at a specified x\-coordinate


## 


## Syntax
\<ChartControl\>.GetTimeByX(int x)


 


## 


## Method Parameters




| x | The x\-coordinate used to find a time value |
| --- | --- |



 


## 


## Example




| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale) {    // Find the timestamp of the bar at x\-coordinate 100    DateTime slotTime \= chartControl.GetTimeByX(100);      // Print the date of slotTime    Print(slotTime); } |









