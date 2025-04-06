



Panel

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\chartbars_panel.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [Charts](chart-1.htm) > [ChartBars](chartbars-1.htm) >  Panel | [Previous page](chartbars_gettimebybaridx-1.htm) [Return to chapter overview](chartbars-1.htm) [Next page](chartbars_properties-1.htm) |

Definition
----------

A zero-based index value that represents the [ChartPanel](chartpanel-1.htm) where the [ChartBars](chartbars-1.htm) reside.

|  |
| --- |
| Note:  This is NOT the same as the [PanelUI](panelui-1.htm) property displays on the Chart's [Data Series](working_with_price_data-1.htm) menu.  A ChartBars.Panel value of 0 represents the first panel on the chart. |

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