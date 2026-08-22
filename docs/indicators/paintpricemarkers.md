# PaintPriceMarkers

## Definition

If true, any indicator plot values display price markers in the y-axis.

## Property Value

This property returns true if the indicator plot values display in the y-axis; otherwise, false. Default set to true.

> **Warning:** This property should ONLY bet set from the [[[OnStateChange()](../language_reference/onstatechange.md) method during State.SetDefaults or State.Configure

## Syntax

PaintPriceMarkers

## Examples

```csharp
protected override void OnStateChange()
{
    if (State == State.SetDefaults)
    {
        PaintPriceMarkers = true; // Indicator plots values display in the y-axis
        AddPlot(Brushes.Orange, "SMA");
    }
}
```
