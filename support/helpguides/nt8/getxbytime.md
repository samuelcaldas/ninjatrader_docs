


NinjaScript \> Language Reference \> Common \> Charts \> ChartControl \> GetXByTime()






















GetXByTime()







| \<\< [Click to Display Table of Contents](getxbytime.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Charts](chart.md) \> [ChartControl](chartcontrol.md) \> GetXByTime() | [Previous page](getxbybarindex.md) [Return to chapter overview](chartcontrol.md) [Next page](chartcontrol_indicators.md) |
| --- | --- |











## Definition


Returns the chart\-canvas x\-coordinate of the slot index of the primary [Bars](bars.md) object corresponding to a specified time. 


 




| Note: Since the time correlates with a specific bar index, and since bars move on the chart canvas as new bars are painted, the value returned by GetXByTime() can be expected to change as new bars are painted on the chart, or as the chart is scrolled backward or forward on the x\-axis. |
| --- |



 


 


## Method Return Value


An int representing a chart\-canvas x\-coordinate


## 


## Syntax


\<ChartControl\>.GetXByTime(DateTime time)


## 


## Method Parameters




| time | A [DateTime](https://msdn.microsoft.com/en-us/library/system.datetime(v=vs.110).aspx) object used to determine an x\-coordinate |
| --- | --- |



 


## 


## Examples




| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale) {    DateTime timeToCheck \= new DateTime(2017, 8, 6, 11, 0, 0);      // Find the chart\-canvas x\-coordinate of the bar at the specified time     int xCoordinate \= chartControl.GetXByTime(timeToCheck);      // Print the x\-coordinate value    Print(xCoordinate); } |









