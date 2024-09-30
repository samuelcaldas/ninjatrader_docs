
NinjaScript \> Language Reference \> Common \> Charts \> ChartControl \> TimePainted
TimePainted

| \<\< [Click to Display Table of Contents](timepainted.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [Charts](chart-1.md) \> [ChartControl](chartcontrol-1.md) \> TimePainted | [Previous page](chartcontrol_strategies-1.md) [Return to chapter overview](chartcontrol-1.md) [Next page](chartingextensions-1.md) |
| --- | --- |

## Definition
Indicates the range of time in which bars are painted on the visible chart canvas.
## 
## Property Value
A TimeSpan measuring the difference between the earliest and latest times at which bars are painted on the chart
## 
## Syntax
\<chartControl\>.TimePainted
## 
## Examples
| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale) {    // Print a message if less than three hours' worth of data is painted on the chart canvas    if(chartControl.TimePainted.Hours \< 3)        Print(String.Format("It is recommended to view at least three hours worth of data on your chart with this indicator. You are currently viewing {0}", chartControl.TimePainted)); } |

| Note: TimePainted is intended to be used when Non\-Equidistant (time\-based) bar spacing is enabled on the chart. Otherwise, it will have a value of 0\. |
| --- |

