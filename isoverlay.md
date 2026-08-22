# IsOverlay

## Definition

Determines if indicator plot(s) are drawn on the chart panel over top of price.  Setting this value to true will also allow an Indicator to be used as a [SuperDOM Indicator](working_with_indicators_superdom.md).

## Property Value

This property returns true if any indicator plot(s) are drawn on the chart panel; otherwise, false. Default set to false.

> **Warning:** This property should ONLY bet set from the [OnStateChange()](onstatechange.md) method during State.SetDefaults

## Syntax

IsOverlay

## Examples

```csharp
protected override void OnStateChange()
{
    if (State == State.SetDefaults)
    {
        IsOverlay = true; // Indicator plots are drawn on the chart panel on top of price
        AddPlot(Brushes.Orange, "SMA");
    }
}
```
