# IsTradingHoursBreakLineVisible

## Definition

Plots trading hours break lines on the indicator panel.

> **Note:** The indicator panel's parent chart has a similar property 'Plot session break line' which if set to false, will override the indicator's local setting if true.

## Property Value

This property returns true if trading hours break lines are plotted on the indicator panel; otherwise, false. Default set to true.

> **Warning:** This property should ONLY bet set from the [[[OnStateChange()](../language_reference/onstatechange.md) method during State.SetDefaults or State.Configure

## Syntax

IsTradingHoursBreakLineVisible

## Examples

```csharp
protected override void OnStateChange()
{
    if (State == State.SetDefaults)
    {
        IsTradingHoursBreakLineVisible = true;
        AddPlot(Brushes.Orange, "SMA");
    }
}
```
