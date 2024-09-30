
NinjaScript > Language Reference > Common > Charts > ChartBars > Bars
Bars
| << [Click to Display Table of Contents](chartbars_bars.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > [Charts](chart.md) > [ChartBars](chartbars.md) > Bars | [Previous page](chartbars.md) [Return to chapter overview](chartbars.md) [Next page](chartbars_count.md) |
| --- | --- |
## Definition
Represents the data returned from the historical data repository in relation to the primary [ChartBars](chartbars.md) object configured on the chart.  See also [Bars](bars.md)
## 
## Property Value
A [Bars](bars.md) object
 
## Syntax
ChartBars.Bars
## 
## Examples
| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale) {    if(ChartBars != null && ChartBars.Bars != null)    {      Print("The configured bars period type represented on the chart is" + ChartBars.Bars.BarsPeriod.BarsPeriodType);    } } |

