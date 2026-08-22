# BarsArray

## Definition

Provides a collection of [ChartBars](chartbars.md) objects currently configured on the chart.

## Property Value

An [ObservableCollection](https://msdn.microsoft.com/en-us/library/ms668604(v=vs.110).aspx) of ChartBars objects

## Syntax

<ChartControl>.BarsArray

## Examples

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
    // Instantiate a new <ChartControl>.BarsArray collection
    System.Collections.ObjectModel.ObservableCollection<ChartBars> myChartBars = chartControl.BarsArray;
    // Print the number of bars in each Bars object within the <ChartControl>.BarsArray collection
    foreach(ChartBars bars in myChartBars)
    {
        Print(bars.Bars.Count);
    }
}
```
