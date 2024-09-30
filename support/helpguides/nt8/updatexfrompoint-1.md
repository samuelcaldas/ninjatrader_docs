
NinjaScript \> Language Reference \> Drawing Tool \> ChartAnchor \> UpdateXFromPoint()
UpdateXFromPoint()
| \<\< [Click to Display Table of Contents](updatexfrompoint.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Drawing Tool](drawing_tools-1.md) \> [ChartAnchor](chartanchor-1.md) \> UpdateXFromPoint() | [Previous page](updatefrompoint-1.md) [Return to chapter overview](chartanchor-1.md) [Next page](updateyfrompoint-1.md) |
| --- | --- |
## Definition
Updates an anchor's X value from a given point (in device pixels).
 
## Method Return Value
This method does not return a value.
## 
## Syntax
\<ChartAnchor\>.UpdateXFromPoint(Point point, ChartControl chartControl, ChartScale chartScale)
## 
## Method Parameters
| point | The chart anchor's point value to be updated |
| --- | --- |
| chartControl | A ChartControl representing the x\-axis |
| chartScale | A ChartScale representing the y\-axis |

## Examples
| ns |
| --- |
| //set the chart anchors x point value MyAnchor.UpdateXFromPoint(point, chartControl, chartScale); |
