
NinjaScript \> Language Reference \> Common \> Charts \> ChartControl \> IsScrollArrowVisible

IsScrollArrowVisible

| \<\< [Click to Display Table of Contents](isscrollarrowvisible.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [Charts](chart-1.md) \> [ChartControl](chartcontrol-1.md) \> IsScrollArrowVisible | [Previous page](chartcontrol_indicators-1.md) [Return to chapter overview](chartcontrol-1.md) [Next page](isstayindrawmode-1.md) |
| --- | --- |
## Definition
Indicates the time\-axis scroll arrow is visible in the top\-right corner of the chart.
## 
## Property Value
A bool value. When True, indicates that the scroll arrow is visible on the chart; otherwise False.
## 
## Syntax
\<ChartControl\>.IsScrollArrowVisible
## 
## Examples

| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale) {    // Print a message if the scroll arrow is visible on the chart    if(chartControl.IsScrollArrowVisible);        Print("The chart is currently not set to auto\-scroll. Click the scroll arrow to return to auto\-scrolling"); } |

Based on the image below, IsScrollArrowVisible confirms that the scroll arrow is currently visible on the chart.
 
![ChartControl_IsScrollArrowVisible](chartcontrol_isscrollarrowvisible.png)
