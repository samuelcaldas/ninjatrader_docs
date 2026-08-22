# CopyDataValues()

Definition  
Copies the ChartAnchor time and price values from on anchor to another.  This includes the [[[BarsAgo](../ninjascript/barsago.md), [[[SlotIndex](barindex.md), [[[Time](time.md), [[[Price](price.md), and [[[DrawnOnBar](drawnonbar.md) values.  This method is useful for updating a chart anchor to a recent data point when the user interacts with the drawing chart anchor.

## Method Return Value

This method does not return a value.

## Syntax

<chartAnchor>.CopyDataValues(ChartAnchor toAnchor)

## Method Parameters

|  |  |
| --- | --- |
| toAnchor | The ChartAnchor to copy |

## Examples

```csharp
public override void OnMouseMove(ChartControl chartControl, ChartPanel chartPanel, ChartScale chartScale, ChartAnchor dataPoint)
{
    // if the user is moving the draw object, copy the most recent dataPoint to MyAnchor
    if (DrawingState == DrawingState.Moving)
    dataPoint.CopyDataValues(Anchor);
}
```
