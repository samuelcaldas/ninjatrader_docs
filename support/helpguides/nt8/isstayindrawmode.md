


NinjaScript \> Language Reference \> Common \> Charts \> ChartControl \> IsStayInDrawMode






















IsStayInDrawMode







| \<\< [Click to Display Table of Contents](isstayindrawmode.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Charts](chart.md) \> [ChartControl](chartcontrol.md) \> IsStayInDrawMode | [Previous page](isscrollarrowvisible.md) [Return to chapter overview](chartcontrol.md) [Next page](isyaxisdisplayedleft.md) |
| --- | --- |











## Definition


Indicates [Stay in Draw Mode](working_with_drawing_tools__ob.md) is currently enabled on the chart.


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









