
NinjaScript > Language Reference > Drawing Tool > ChartAnchor > CopyDataValues()

CopyDataValues()
| << [Click to Display Table of Contents](copydatavalues.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Drawing Tool](drawing_tools.md) > [ChartAnchor](chartanchor.md) > CopyDataValues() | [Previous page](chartanchor.md) [Return to chapter overview](chartanchor.md) [Next page](displayname.md) |
| --- | --- |
Definition  

Copies the ChartAnchor time and price values from on anchor to another.  This includes the [BarsAgo](barsago.md), [SlotIndex](barindex.md), [Time](time.md), [Price](price.md), and [DrawnOnBar](drawnonbar.md) values.  This method is useful for updating a chart anchor to a recent data point when the user interacts with the drawing chart anchor.  

## Method Return Value
This method does not return a value.
 
## 
## Syntax
<chartAnchor>.CopyDataValues(ChartAnchor toAnchor)
## 
## 
## Method Parameters
| toAnchor | The ChartAnchor to copy |
| --- | --- |

 
## 
## Examples
| ns |
| --- |
| public override void OnMouseMove(ChartControl chartControl, ChartPanel chartPanel, ChartScale chartScale, ChartAnchor dataPoint) {       // if the user is moving the draw object, copy the most recent dataPoint to MyAnchor    if (DrawingState == DrawingState.Moving)               dataPoint.CopyDataValues(Anchor); } |
