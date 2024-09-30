
NinjaScript > Language Reference > Common > Charts > ChartScale > PanelIndex
PanelIndex
| << [Click to Display Table of Contents](panelindex.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > [Charts](chart.md) > [ChartScale](chartscale.md) > PanelIndex | [Previous page](chartscale_minvalue.md) [Return to chapter overview](chartscale.md) [Next page](chartscale_properties.md) |
| --- | --- |
## Definition
The panel on which the chart scale resides.  
## 
| Note:  This value is NOT the same value as the indicator's [PanelUI](panelui.md). PanelIndex will provide the actual indexed value of the chart panel used for this chart scale. |
| --- |

## 
## 
## Property Value
An int value representing the panel as an index value which starts at 0 and will increment for each panel configured on the chart.  This property is read-only.
## 
## Syntax
<chartScale>.PanelIndex
## 
## Examples
| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale) {             // the index value of the panel (not the same as the panelUI)    int     panel     = chartScale.PanelIndex;    Print("panel: " + panel); } |
