


NinjaScript \> Language Reference \> Common \> Charts \> ChartControl \> IsStayInDrawMode






















IsStayInDrawMode







| \<\< [Click to Display Table of Contents](isstayindrawmode.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [Charts](chart-1.md) \> [ChartControl](chartcontrol-1.md) \> IsStayInDrawMode | [Previous page](isscrollarrowvisible-1.md) [Return to chapter overview](chartcontrol-1.md) [Next page](isyaxisdisplayedleft-1.md) |
| --- | --- |











## Definition


Indicates [Stay in Draw Mode](working_with_drawing_tools__ob-1.md) is currently enabled on the chart.


## 


## Property Value


A bool value. When True, indicates that Stay in Draw Mode is enabled on the chart; otherwise False.


## 


## Syntax


\<ChartControl\>.IsStayInDrawMode 


## 


## Examples




| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale) {    // Print a message if Stay in Draw Mode is enabled    if(chartControl.IsStayInDrawMode);        Print("Stay in Draw Mode is currently enabled"); } |









