


NinjaScript \> Language Reference \> Common \> Charts \> ChartBars \> Count






















Count







| \<\< [Click to Display Table of Contents](chartbars_count.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [Charts](chart-1.md) \> [ChartBars](chartbars-1.md) \> Count | [Previous page](chartbars_bars-1.md) [Return to chapter overview](chartbars-1.md) [Next page](chartbars_fromindex-1.md) |
| --- | --- |











## Definition


The total number of [ChartBars](chartbars-1.md) in the charts primary data series


## 


## Property Value


An int value representing the the total number of bars.


 


## Syntax


ChartBars.Count


 


## Examples




| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale) {    if(ChartBars !\= null)    {      Print("ChartBars contain " \+ ChartBars.Count \+ " bars");      //Output:  ChartBars contain 73 bars     } } |









