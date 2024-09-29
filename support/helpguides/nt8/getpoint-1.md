


NinjaScript \> Language Reference \> Drawing Tool \> ChartAnchor \> GetPoint()






















GetPoint()







| \<\< [Click to Display Table of Contents](getpoint.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Drawing Tool](drawing_tools-1.md) \> [ChartAnchor](chartanchor-1.md) \> GetPoint() | [Previous page](drawnonbar-1.md) [Return to chapter overview](chartanchor-1.md) [Next page](isbrowsable-1.md) |
| --- | --- |











## Definition


Returns a chart anchor's data point in device pixels


 


## Method Return Value


A [Point](https://msdn.microsoft.com/en-us/library/system.drawing.point%28v=vs.110%29.aspx) structure; a point value in device pixels for a chart's given panel \& scale 


## 


## Syntax


\<chartAnchor\>.GetPoint(ChartControl chartControl, ChartPanel chartPanel, ChartScale, \[bool pixelAlign])


## 


## Method Parameters




| chartControl | A [ChartControl](chartcontrol-1.md) representing the x\-axis |
| --- | --- |
| chartPanel | A [ChartPanel](chartpanel-1.md) representing the a panel of the chart |
| chartScale | A [ChartScale](chartscale-1.md) representing the y\-axis |
| pixelAlign | An optional bool determining if the data point should be rounded to closest .5 pixel point |



 


## 


## Examples




| ns |
| --- |
| //gets the chart anchors data points Point anchorPoint \= MyAnchor.GetPoint(chartControl, chartPanel, chartScale); |









