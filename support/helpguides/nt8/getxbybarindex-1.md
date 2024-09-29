


NinjaScript \> Language Reference \> Common \> Charts \> ChartControl \> GetXByBarIndex()






















GetXByBarIndex()







| \<\< [Click to Display Table of Contents](getxbybarindex.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [Charts](chart-1.md) \> [ChartControl](chartcontrol-1.md) \> GetXByBarIndex() | [Previous page](gettimebyx-1.md) [Return to chapter overview](chartcontrol-1.md) [Next page](getxbytime-1.md) |
| --- | --- |











## Definition


Returns the chart\-canvas x\-coordinate of the bar at a specified index of a specified [ChartBars](chartbars-1.md) object on the chart. 


 




| Note:  Since the index is based upon bars that move across the chart canvas as new bars are painted, the value returned by GetXByBarIndex() can be expected to change as new bars are painted on the chart, or as the chart is scrolled backward or forward on the x\-axis. |
| --- |



 


 


## Method Return Value


An int representing a chart\-canvas x\-coordinate


## 


## Syntax


\<ChartControl\>.GetXByBarIndex(ChartBars chartBars, int barIndex)


## 


## Method Parameters




| chartBars | The [ChartBars](chartbars-1.md) object to check |
| --- | --- |
| barIndex | The slot index used to determine an x\-coordinate |



 


## 


## Examples




| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale) {    double xCoordinate \= chartControl.GetXByBarIndex(ChartBars, 100);      // Print the x\-coordinate value    Print(xCoordinate); } |









