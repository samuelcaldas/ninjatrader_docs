# ScaleJustification

## Definition

Determines which scale an indicator will be plotted on.

> **Warning:** This property should ONLY bet set from the [[[OnStateChange()](onstatechange.md) method during State.SetDefaults or State.Configure

## Property Value

This property returns a ScaleJustification value of either:

NinjaTrader.Gui.Charts.ScaleJustification.Left;  
NinjaTrader.Gui.Charts.ScaleJustification.Overlay;  
NinjaTrader.Gui.Charts.ScaleJustification.Right;

## Syntax

ScaleJustification

## Examples

```csharp
protected override void OnStateChange()
{
    if (State == State.SetDefaults)
    {
        Name = "Examples Indicator";
        // force "My Plot" to be plotted on the left scale
        ScaleJustification = ScaleJustification.Left;
    }
    else if (State == State.Configure)
    {
        AddPlot(Brushes.Orange, "My Plot");
    }
}
```
