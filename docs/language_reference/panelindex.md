# PanelIndex

## Definition

The panel on which the chart scale resides.

> **Note:** This value is NOT the same value as the indicator's [[[PanelUI](panelui.md). PanelIndex will provide the actual indexed value of the chart panel used for this chart scale.

## Property Value

An int value representing the panel as an index value which starts at 0 and will increment for each panel configured on the chart.  This property is read-only.

## Syntax

<chartScale>.PanelIndex

## Examples

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
    // the index value of the panel (not the same as the panelUI)
    int
    panel
    = chartScale.PanelIndex;
    Print("panel: " + panel);
}
```
