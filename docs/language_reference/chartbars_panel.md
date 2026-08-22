# Panel

## Definition

A zero-based index value that represents the [ChartPanel](chartpanel.md) where the [ChartBars](chartbars.md) reside.

> **Note:** This is NOT the same as the [PanelUI](panelui.md) property displays on the Chart's [Data Series](../operations/working_with_price_data.md) menu.  A ChartBars.Panel value of 0 represents the first panel on the chart.

## Property Value

An int indicating the panel of the ChartBars

## Syntax

Bars.Panel

 

## Examples

![Ns](../images/ns.png)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
    Print("ChartBars reside on panel index: " + ChartBars.Panel);
    // Output:
    ChartBars reside on panel index: 0
}
```