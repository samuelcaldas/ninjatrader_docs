


NinjaScript \> Language Reference \> Common \> Charts \> ChartPanel \> MaxValue






















MaxValue







| \<\< [Click to Display Table of Contents](maxvalue_chartpanel.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Charts](chart.md) \> [ChartPanel](chartpanel.md) \> MaxValue | [Previous page](isyaxisdisplayedright_chartpanel.md) [Return to chapter overview](chartpanel.md) [Next page](minvalue_chartpanel.md) |
| --- | --- |











## Definition


Indicates the maximum Y value of objects within the chart panel, based on the current y\-axis scale. The scale of the y\-axis is dependent upon the values of objects in the panel which have Auto Scale enabled.


## 


## Property Value


A double representing the maximum Y value in the panel's vertical scale


 


## Syntax


ChartPanel.MaxValue


## 


## Example




| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale) {    base.OnRender(chartControl, chartScale);      // Print the minimum and maximum Y values for objects in the panel    Print(String.Format("Min value: {0}, Max value: {1}",ChartPanel.MinValue, ChartPanel.MaxValue)); } |









