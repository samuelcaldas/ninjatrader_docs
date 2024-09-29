


NinjaScript \> Language Reference \> Drawing Tool \> ChartAnchor \> UpdateFromPoint()






















UpdateFromPoint()







| \<\< [Click to Display Table of Contents](updatefrompoint.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Drawing Tool](drawing_tools.md) \> [ChartAnchor](chartanchor.md) \> UpdateFromPoint() | [Previous page](time.md) [Return to chapter overview](chartanchor.md) [Next page](updatexfrompoint.md) |
| --- | --- |











## Definition


Updates an anchor's x and y values from a given point (in device pixels).


 


## Method Return Value


This method does not return a value.


## 


## Syntax


\<ChartAnchor\>.UpdateFromPoint(Point point, ChartControl chartControl, ChartScale chartScale)


## 


## Method Parameters




| point | The chart anchor's point value to be updated |
| --- | --- |
| chartControl | A ChartControl representing the x\-axis |
| chartScale | A ChartScale representing the y\-axis |



 


 


## Examples




| ns |
| --- |
| //set the chart anchors x and y point value MyAnchor.UpdateFromPoint(point, chartControl, chartScale); |









