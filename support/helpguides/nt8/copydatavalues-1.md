
NinjaScript \> Language Reference \> Drawing Tool \> ChartAnchor \> CopyDataValues()

CopyDataValues()
| \<\< [Click to Display Table of Contents](copydatavalues.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Drawing Tool](drawing_tools-1.md) \> [ChartAnchor](chartanchor-1.md) \> CopyDataValues() | [Previous page](chartanchor-1.md) [Return to chapter overview](chartanchor-1.md) [Next page](displayname-1.md) |
| --- | --- |
Definition  

Copies the ChartAnchor time and price values from on anchor to another.  This includes the [BarsAgo](barsago.md), [SlotIndex](barindex-1.md), [Time](time-1.md), [Price](price-1.md), and [DrawnOnBar](drawnonbar-1.md) values.  This method is useful for updating a chart anchor to a recent data point when the user interacts with the drawing chart anchor.  

## Method Return Value
This method does not return a value.
 
## 
## Syntax
\<chartAnchor\>.CopyDataValues(ChartAnchor toAnchor)
## 
## 
## Method Parameters
| toAnchor | The ChartAnchor to copy |
| --- | --- |

 
## 
## Examples
| ns |
| --- |
| public override void OnMouseMove(ChartControl chartControl, ChartPanel chartPanel, ChartScale chartScale, ChartAnchor dataPoint) {       // if the user is moving the draw object, copy the most recent dataPoint to MyAnchor    if (DrawingState \=\= DrawingState.Moving)               dataPoint.CopyDataValues(Anchor); } |
