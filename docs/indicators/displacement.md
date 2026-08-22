# Displacement

## Definition

An offset value that shifts the visually displayed value of an indicator.

## Property Value

An int value that represents the number of bars ago to offset with.

## Syntax

Displacement

## Examples

![Ns](../images/ns.png)

```csharp
protected override void OnStateChange()
{
    if (State == State.SetDefaults)
    {
        Displacement = 2; // Plots the indicator value from 2 bars ago on the current bar
        AddPlot(Brushes.Orange, "SMA");
    }
}
```