
NinjaScript > Language Reference > Common > Charts > ChartControl > BarsPeriod

BarsPeriod
| << [Click to Display Table of Contents](chartcontrol_barsperiod.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [Charts](chart-1.md) > [ChartControl](chartcontrol-1.md) > BarsPeriod | [Previous page](barspacingtype-1.md) [Return to chapter overview](chartcontrol-1.md) [Next page](chartcontrol_barwidth-1.md) |
| --- | --- |
## Definition
Provides the period (interval) used for the primary [Bars](bars-1.md) object on the chart.
## 
## Property Value
A NinjaTrader.Data.BarsPeriod object containing information on the period used by the Bars object on the chart.
## 
## Syntax
<ChartControl>.BarsPeriod
## 
## Examples
| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale) {    BarsPeriod period = chartControl.BarsPeriod;      // Print the period (interval) of the Bars object on the chart    Print(period); } |

Based on the image below, BarsPeriod confirms that the primary Bars object on the chart is configured to a 5-minute interval.
 
![ChartControl_BarsPeriod](chartcontrol_barsperiod.png)
