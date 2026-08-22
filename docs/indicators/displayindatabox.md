# DisplayInDataBox

## Definition

Determines if plot(s) display in the chart data box.

## Property Value

This property returns true if the indicator plot(s) values display in the chart data box; otherwise, false. Default set to true.

> **Warning:** This property should ONLY bet set from the [[[OnStateChange()](../language_reference/onstatechange.md) method during State.SetDefaults or State.Configure

## Syntax

DisplayInDataBox

## Examples

```csharp
protected override void OnStateChange()
{
    if (State == State.SetDefaults)
    {
        DisplayInDataBox = false;
        AddPlot(Brushes.Orange, "SMA");
    }
}
```
