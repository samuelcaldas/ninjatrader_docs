# DrawVerticalGridLines

## Definition

Plots vertical grid lines on the indicator panel.

> **Note:** The indicator panel's parent chart has a similar option 'Grid line - vertical  which if Visible property set to false, will override the indicator's local setting if true.

## Property Value

This property returns true if vertical grid lines are plotted on the indicator panel; otherwise, false. Default set to true.

> **Warning:** This property should ONLY bet set from the [OnStateChange()](onstatechange.md) method during State.SetDefaults or State.Configure

## Syntax

DrawVerticalGridLines

## Examples

```csharp
protected override void OnStateChange()
{
    if (State == State.SetDefaults)
    {
        DrawVerticalGridLines = false; // Vertical grid lines will not plot on the indicator panel
        AddPlot(Brushes.Orange, "SMA");
    }
}
```
