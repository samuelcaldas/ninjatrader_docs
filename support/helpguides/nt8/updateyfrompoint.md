
NinjaScript \> Language Reference \> Drawing Tool \> ChartAnchor \> UpdateYFromPoint()
UpdateYFromPoint()
| \<\< [Click to Display Table of Contents](updateyfrompoint.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Drawing Tool](drawing_tools.md) \> [ChartAnchor](chartanchor.md) \> UpdateYFromPoint() | [Previous page](updatexfrompoint.md) [Return to chapter overview](chartanchor.md) [Next page](converttoverticalpixels.md) |
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
