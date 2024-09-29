


NinjaScript \> Language Reference \> Common \> Charts \> ChartControl \> Strategies






















Strategies







| \<\< [Click to Display Table of Contents](chartcontrol_strategies.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Charts](chart.md) \> [ChartControl](chartcontrol.md) \> Strategies | [Previous page](slotspainted.md) [Return to chapter overview](chartcontrol.md) [Next page](timepainted.md) |
| --- | --- |











## Definition


A collection of strategies configured on the chart.


## 


## Property Value


A ChartObjectCollection of StrategyRenderBase objects containing information on all configured strategies on the chart.


## 


## Syntax


\<ChartControl\>.Strategies


## 


## Examples




| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale) {    // Print the number of strategies configured on the chart    if (chartControl.Strategies.Count \> 0)             Print(chartControl.Strategies\[0].Name); } |









