# Strategies

## Definition

A collection of strategies configured on the chart.

## Property Value

A ChartObjectCollection of StrategyRenderBase objects containing information on all configured strategies on the chart.

## Syntax

<ChartControl>.Strategies

## Examples

![Ns](../images/ns.png)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
    // Print the number of strategies configured on the chart
    if (chartControl.Strategies.Count > 0)
    Print(chartControl.Strategies[0].Name);
}
```