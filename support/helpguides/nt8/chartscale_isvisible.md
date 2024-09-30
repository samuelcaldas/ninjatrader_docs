
NinjaScript \> Language Reference \> Common \> Charts \> ChartScale \> IsVisible
IsVisible

| \<\< [Click to Display Table of Contents](chartscale_isvisible.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Charts](chart.md) \> [ChartScale](chartscale.md) \> IsVisible | [Previous page](height.md) [Return to chapter overview](chartscale.md) [Next page](maxminusmin.md) |
| --- | --- |

## Definition
Indicates if the chart scale is viewable on the UI.  If the bar series, indicator, or strategy which uses the chart scale is not in view, the chart scale IsVisible property will return false.
## 
## Property Value
A bool value, which when true the series used to build the scale is viewable; otherwise false.  This property is read\-only.
## 
## Syntax
\<chartScale\>.IsVisible
## 
## Examples
| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale) {             // do not process render info chart scale is not visible    if(!chartScale.IsVisible)      return; } |

