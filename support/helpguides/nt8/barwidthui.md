
NinjaScript > Language Reference > Chart Style > BarWidthUI

BarWidthUI
| << [Click to Display Table of Contents](barwidthui.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Chart Style](chart_style.md) > BarWidthUI | [Previous page](barwidth.md) [Return to chapter overview](chart_style.md) [Next page](chartstyletype.md) |
| --- | --- |
## Definition
The Bar width value which displays on the UI.  This value will be rounded from the internal [BarWidth](barwidth.md) property which is updated as the ChartControl is resized
 
## Property Value
A int value representing the width of the chart bars which can be set by a user.
 
## Syntax
BarWidthUI

## Examples
| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale, ChartBars chartBars) {        int barWidth = GetBarPaintWidth(BarWidthUI);   } |
