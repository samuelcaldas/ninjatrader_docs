



IsStayInDrawMode

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\isstayindrawmode.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [Charts](chart-1.htm) > [ChartControl](chartcontrol-1.htm) >  IsStayInDrawMode | [Previous page](isscrollarrowvisible-1.htm) [Return to chapter overview](chartcontrol-1.htm) [Next page](isyaxisdisplayedleft-1.htm) |

Definition
----------

Indicates [Stay in Draw Mode](working_with_drawing_tools__ob-1.htm) is currently enabled on the chart.

Property Value
--------------

A bool value. When True, indicates that Stay in Draw Mode is enabled on the chart; otherwise False.

Syntax
------

<ChartControl>.IsStayInDrawMode

Examples
--------

| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale)  {     // Print a message if Stay in Draw Mode is enabled     if(chartControl.IsStayInDrawMode);         Print("Stay in Draw Mode is currently enabled");  } |