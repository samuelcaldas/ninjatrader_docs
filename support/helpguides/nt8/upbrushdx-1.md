
NinjaScript > Language Reference > Chart Style > UpBrushDX
UpBrushDX
| << [Click to Display Table of Contents](upbrushdx.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Chart Style](chart_style-1.md) > UpBrushDX | [Previous page](upbrush-1.md) [Return to chapter overview](chart_style-1.md) [Next page](drawing_tools-1.md) |
| --- | --- |
## Definition
A SharpDX [Brush](sharpdx_direct2d1_brush-1.md) object used to paint the up bars for the ChartStyle.
 
## Property  Value
A [SharpDX](sharpdx_direct2d1-1.md) Brush object used to paint the up bars
 
## Syntax
UpBrushDX
 
## Examples
| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale, ChartBars chartBars) {    for (int idx = chartBars.FromIndex; idx <= chartBars.ToIndex; idx++)        {            double     closeValue             = bars.GetClose(idx);             double     openValue               = bars.GetOpen(idx);              // Set the brush of the current candle to UpBrushDX or DownBrushDX, depending on the             // bar direction            Brush brush = closeValue >= openValue ? UpBrushDX : DownBrushDX;        } } |
