
NinjaScript \> Language Reference \> Common \> Charts \> ChartBars \> Count
Count
| \<\< [Click to Display Table of Contents](chartbars_count.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Charts](chart.md) \> [ChartBars](chartbars.md) \> Count | [Previous page](chartbars_bars.md) [Return to chapter overview](chartbars.md) [Next page](chartbars_fromindex.md) |
| --- | --- |
## Definition
The total number of [ChartBars](chartbars.md) in the charts primary data series
## 
## Property Value
An int value representing the the total number of bars.
 
## Syntax
ChartBars.Count
 
## Examples
| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale) {    if(ChartBars !\= null)    {      Print("ChartBars contain " \+ ChartBars.Count \+ " bars");      //Output:  ChartBars contain 73 bars     } } |

