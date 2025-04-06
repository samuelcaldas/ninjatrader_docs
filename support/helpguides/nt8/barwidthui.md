



BarWidthUI

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](barwidthui.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Chart Style](chart_style.htm) >  BarWidthUI | [Previous page](barwidth.htm) [Return to chapter overview](chart_style.htm) [Next page](chartstyletype.htm) |

Definition
----------

The Bar width value which displays on the UI.  This value will be rounded from the internal [BarWidth](barwidth.htm) property which is updated as the ChartControl is resized

Property Value
--------------

A int value representing the width of the chart bars which can be set by a user.

Syntax
------

BarWidthUI

 

Examples
--------

| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale, ChartBars chartBars)  {          int barWidth = GetBarPaintWidth(BarWidthUI);     } |