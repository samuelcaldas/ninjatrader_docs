
NinjaScript > Language Reference > Common > Charts > ChartControl > Strategies
Strategies
| << [Click to Display Table of Contents](chartcontrol_strategies.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [Charts](chart-1.md) > [ChartControl](chartcontrol-1.md) > Strategies | [Previous page](slotspainted-1.md) [Return to chapter overview](chartcontrol-1.md) [Next page](timepainted-1.md) |
| --- | --- |
## Definition
A collection of strategies configured on the chart.
## 
## Property Value
A ChartObjectCollection of StrategyRenderBase objects containing information on all configured strategies on the chart.
## 
## Syntax
<ChartControl>.Strategies
## 
## Examples
| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale) {    // Print the number of strategies configured on the chart    if (chartControl.Strategies.Count > 0)             Print(chartControl.Strategies[0].Name); } |

