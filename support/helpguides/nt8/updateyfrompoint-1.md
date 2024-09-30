
NinjaScript \> Language Reference \> Drawing Tool \> ChartAnchor \> UpdateYFromPoint()
UpdateYFromPoint()
| \<\< [Click to Display Table of Contents](updateyfrompoint.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Drawing Tool](drawing_tools-1.md) \> [ChartAnchor](chartanchor-1.md) \> UpdateYFromPoint() | [Previous page](updatexfrompoint-1.md) [Return to chapter overview](chartanchor-1.md) [Next page](converttoverticalpixels-1.md) |
| --- | --- |
## Definition
Updates an anchor's Y value from a given point (in device pixels).
 
## Method Return Value
This method does not return a value.
 
## Syntax
\<ChartAnchor\>.UpdateYFromPoint(Point point, ChartScale chartScale)
## 
## Method Parameters
| point | The chart anchor's point value to be updated |
| --- | --- |
| chartScale | A ChartScale representing the y\-axis |

## Examples
| ns |
| --- |
| //set the chart anchors x point value MyAnchor.UpdateYFromPoint(point, chartScale); |
