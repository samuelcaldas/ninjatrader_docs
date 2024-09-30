
NinjaScript \> Language Reference \> Drawing Tool \> ChartAnchor \> UpdateXFromPoint()
UpdateXFromPoint()
| \<\< [Click to Display Table of Contents](updatexfrompoint.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Drawing Tool](drawing_tools.md) \> [ChartAnchor](chartanchor.md) \> UpdateXFromPoint() | [Previous page](updatefrompoint.md) [Return to chapter overview](chartanchor.md) [Next page](updateyfrompoint.md) |
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
