# Time

## Definition

Determines date/time value the chart anchor is drawn.

## Property Value

An DateTime value representing a time value

## Syntax

<ChartAnchor>.Time

## Examples

![Ns](../images/ns.png)

```csharp
public override void OnMouseDown(ChartControl chartControl, ChartPanel chartPanel, ChartScale chartScale, Point point)
{
    Print(MyAnchor.Time); // prints the X axis datetime of the chart anchor
    // 8/26/2014 6:55:00 PM
}
```