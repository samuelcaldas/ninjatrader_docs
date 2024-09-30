
NinjaScript > Language Reference > Common > Charts > ChartBars > Panel

Panel
| << [Click to Display Table of Contents](chartbars_panel.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [Charts](chart-1.md) > [ChartBars](chartbars-1.md) > Panel | [Previous page](chartbars_gettimebybaridx-1.md) [Return to chapter overview](chartbars-1.md) [Next page](chartbars_properties-1.md) |
| --- | --- |
## Definition
A zero-based index value that represents the [ChartPanel](chartpanel-1.md) where the [ChartBars](chartbars-1.md) reside.
 
| Note:  This is NOT the same as the [PanelUI](panelui-1.md) property displays on the Chart's [Data Series](working_with_price_data-1.md) menu.  A ChartBars.Panel value of 0 represents the first panel on the chart. |
| --- |

## 
## 
## Property Value
An int indicating the panel of the ChartBars
## 
## Syntax
Bars.Panel
 
## Examples
| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale) {    Print("ChartBars reside on panel index: " + ChartBars.Panel);    // Output:  ChartBars reside on panel index: 0          } |
