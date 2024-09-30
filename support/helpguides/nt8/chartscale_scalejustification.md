
NinjaScript > Language Reference > Common > Charts > ChartScale > ScaleJustification

ScaleJustification
| << [Click to Display Table of Contents](chartscale_scalejustification.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > [Charts](chart.md) > [ChartScale](chartscale.md) > ScaleJustification | [Previous page](chartscale_properties.md) [Return to chapter overview](chartscale.md) [Next page](width.md) |
| --- | --- |
## Definition
Indicates the location of the chart scale relative to the chart control.
## 
## Property Value
A ScaleJustification enum.  Possible values are:
- Right

- Left

- Overlay

## 
## Syntax
ScaleJustification
## 
## Examples
| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale) {             if (chartScale.ScaleJustification == ScaleJustification.Right)    {      // do something                } } |
