


NinjaScript \> Language Reference \> Common \> Charts \> ChartControl \> BarsArray






















BarsArray







| \<\< [Click to Display Table of Contents](chartcontrol_barsarray.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Charts](chart.md) \> [ChartControl](chartcontrol.md) \> BarsArray | [Previous page](barmarginleft.md) [Return to chapter overview](chartcontrol.md) [Next page](barspacingtype.md) |
| --- | --- |











## Definition


Provides a collection of [ChartBars](chartbars.md) objects currently configured on the chart. 


## 


## Property Value


An [ObservableCollection](https://msdn.microsoft.com/en-us/library/ms668604(v=vs.110).aspx) of ChartBars objects


## 


## Syntax


\<ChartControl\>.BarsArray


## 


## Examples




| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale) {    // Instantiate a new \<ChartControl\>.BarsArray collection    System.Collections.ObjectModel.ObservableCollection\<ChartBars\> myChartBars \= chartControl.BarsArray;      // Print the number of bars in each Bars object within the \<ChartControl\>.BarsArray collection    foreach(ChartBars bars in myChartBars)    {        Print(bars.Bars.Count);    } } |









