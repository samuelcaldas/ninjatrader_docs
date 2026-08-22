# BarWidth

## Definition

The painted width of a ChartStyle bar.  This value will updated as the ChartControl is resized.

## Property Value

A double value representing the current width the chart bars

## Syntax

BarWidth

 

## Examples

![Ns](../images/ns.png)

```csharp
protected override void OnStateChange()
{
    if (State == State.SetDefaults)
    {
        Name
        = "Example ChartStyle";
        ChartStyleType
        = (ChartStyleType) 52;
        BarWidth
        = 1;
    }
}
```