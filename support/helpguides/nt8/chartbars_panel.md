



Panel

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](chartbars_panel.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Common](common.htm) > [Charts](chart.htm) > [ChartBars](chartbars.htm) >  Panel | [Previous page](chartbars_gettimebybaridx.htm) [Return to chapter overview](chartbars.htm) [Next page](chartbars_properties.htm) |

Definition
----------

A zero-based index value that represents the [ChartPanel](chartpanel.htm) where the [ChartBars](chartbars.htm) reside.

|  |
| --- |
| Note:  This is NOT the same as the [PanelUI](panelui.htm) property displays on the Chart's [Data Series](working_with_price_data.htm) menu.  A ChartBars.Panel value of 0 represents the first panel on the chart. |

Property Value
--------------

An int indicating the panel of the ChartBars

Syntax
------

Bars.Panel

 

Examples
--------

| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale)  {     Print("ChartBars reside on panel index: " + ChartBars.Panel);     // Output:  ChartBars reside on panel index: 0           } |