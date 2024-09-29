


NinjaScript \> Language Reference \> Drawing Tool \> ChartAnchor \> MoveAnchorY()






















MoveAnchorY()







| \<\< [Click to Display Table of Contents](moveanchory.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Drawing Tool](drawing_tools-1.md) \> [ChartAnchor](chartanchor-1.md) \> MoveAnchorY() | [Previous page](moveanchorx-1.md) [Return to chapter overview](chartanchor-1.md) [Next page](price-1.md) |
| --- | --- |











## Definition


Moves an anchor's y value from start point by a delta point amount.


 


## Method Return Value


This method does not return a value.


 


## Syntax


\<ChartAnchor\>.MoveAnchorY(Point startPoint, Point deltaPoint, ChartControl chartControl, ChartScale chartScale)


## 


## Method Parameters




| startPoint | The chart anchor's original starting point value |
| --- | --- |
| deltaPoint | The chart anchor's new point value to be updated |
| chartControl | A ChartControl representing the x\-axis |
| chartScale | A ChartScale representing the y\-axis |



## 


## 


## Examples




| ns |
| --- |
| //move only the chart anchors Y (price) value MyAnchor.MoveAnchorY(lastPoint, newPoint, chartControl, chartPanel, chartScale); |









