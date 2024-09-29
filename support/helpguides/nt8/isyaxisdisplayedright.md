


NinjaScript \> Language Reference \> Common \> Charts \> ChartControl \> IsYAxisDisplayedRight






















IsYAxisDisplayedRight







| \<\< [Click to Display Table of Contents](isyaxisdisplayedright.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Charts](chart.md) \> [ChartControl](chartcontrol.md) \> IsYAxisDisplayedRight | [Previous page](isyaxisdisplayedoverlay.md) [Return to chapter overview](chartcontrol.md) [Next page](lastslotpainted.md) |
| --- | --- |











## Definition


Indicates the y\-axis displays (in any chart panel) to the right side of the chart.


## 


## Property Value


A boolean value. When True, indicates that the y\-axis displays to the right of the chart canvas; otherwise False.


## 


## Syntax


\<ChartControl\>.IsYAxisDisplayedRight


## 


## Examples




| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale) {    // Print the value of IsYAxisDisplayedRight    Print("Y\-Axis visible to the right of the chart canvas? " \+ chartControl.IsYAxisDisplayedRight); } |



 


 


Based on the image below, IsYAxisDisplayedRight confirms that the y\-axis is not displayed to the right of the chart canvas.


 


![ChartControl_IsYAxisDisplayedRight](chartcontrol_isyaxisdisplayedright.png)








