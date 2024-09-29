


NinjaScript \> Language Reference \> Common \> Charts \> ChartBars \> Bars






















Bars







| \<\< [Click to Display Table of Contents](chartbars_bars.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [Charts](chart-1.md) \> [ChartBars](chartbars-1.md) \> Bars | [Previous page](chartbars-1.md) [Return to chapter overview](chartbars-1.md) [Next page](chartbars_count-1.md) |
| --- | --- |











## Definition


Represents the data returned from the historical data repository in relation to the primary [ChartBars](chartbars-1.md) object configured on the chart.  See also [Bars](bars-1.md)


## 


## Property Value


A [Bars](bars-1.md) object


 


## Syntax


ChartBars.Bars


## 


## Examples




| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale) {    if(ChartBars !\= null \&\& ChartBars.Bars !\= null)    {      Print("The configured bars period type represented on the chart is" \+ ChartBars.Bars.BarsPeriod.BarsPeriodType);    } } |









