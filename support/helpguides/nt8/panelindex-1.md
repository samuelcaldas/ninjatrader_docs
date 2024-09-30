
NinjaScript > Language Reference > Common > Charts > ChartScale > PanelIndex
PanelIndex
| << [Click to Display Table of Contents](panelindex.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [Charts](chart-1.md) > [ChartScale](chartscale-1.md) > PanelIndex | [Previous page](chartscale_minvalue-1.md) [Return to chapter overview](chartscale-1.md) [Next page](chartscale_properties-1.md) |
| --- | --- |
## Definition
The panel on which the chart scale resides.  
## 
| Note:  This value is NOT the same value as the indicator's [PanelUI](panelui-1.md). PanelIndex will provide the actual indexed value of the chart panel used for this chart scale. |
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
