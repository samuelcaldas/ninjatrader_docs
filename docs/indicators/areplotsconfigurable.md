# ArePlotsConfigurable

## Definition

Determines if the plot(s) used in an indicator are configurable within the indicator dialog window.

## Property Value

A bool which returns true if any indicator plot(s) are configurable; otherwise, false. Default set to true.

## Syntax

ArePlotsConfigurable

## Examples

![Ns](../images/ns.png)

```csharp
protected override void OnStateChange()
{
    if (State == State.SetDefaults)
    {
        AddPlot(Brushes.Orange, "SMA");
        ArePlotsConfigurable = false; // Plots are not configurable in the indicator dialog
    }
}
```