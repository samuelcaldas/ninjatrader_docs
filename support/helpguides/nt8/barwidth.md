



BarWidth

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](barwidth.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Chart Style](chart_style.htm) >  BarWidth | [Previous page](chart_style.htm) [Return to chapter overview](chart_style.htm) [Next page](barwidthui.htm) |

Definition
----------

The painted width of a ChartStyle bar.  This value will updated as the ChartControl is resized.

Property Value
--------------

A double value representing the current width the chart bars

Syntax
------

BarWidth

 

Examples
--------

| ns |
| --- |
| protected override void OnStateChange()  {     if (State == State.SetDefaults)     {       Name             = "Example ChartStyle";                ChartStyleType   = (ChartStyleType) 52;       BarWidth         = 1;     }  } |