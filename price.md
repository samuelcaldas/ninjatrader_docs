# Price

## Definition

Determines price value the chart anchor is drawn.

## Property Value

An double value representing a price value

## Syntax

<ChartAnchor>.Price

## Examples

```csharp
public override void OnMouseDown(ChartControl chartControl, ChartPanel chartPanel, ChartScale chartScale, Point point)
{
    Print(MyAnchor.Price); // prints the Y axis data point of the chart anchor
    // 1999.25
}
```
