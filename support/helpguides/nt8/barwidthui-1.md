
NinjaScript \> Language Reference \> Chart Style \> BarWidthUI

BarWidthUI
| \<\< [Click to Display Table of Contents](barwidthui.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Chart Style](chart_style-1.md) \> BarWidthUI | [Previous page](barwidth-1.md) [Return to chapter overview](chart_style-1.md) [Next page](chartstyletype-1.md) |
| --- | --- |
## Definition
The Bar width value which displays on the UI.  This value will be rounded from the internal [BarWidth](barwidth-1.md) property which is updated as the ChartControl is resized
 
## Property Value
A int value representing the width of the chart bars which can be set by a user.
 
## Syntax
BarWidthUI

## Examples
| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale, ChartBars chartBars) {        int barWidth \= GetBarPaintWidth(BarWidthUI);   } |
