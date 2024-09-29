


NinjaScript \> Language Reference \> Chart Style \> DownBrushDX






















DownBrushDX







| \<\< [Click to Display Table of Contents](downbrushdx.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Chart Style](chart_style-1.md) \> DownBrushDX | [Previous page](downbrush-1.md) [Return to chapter overview](chart_style-1.md) [Next page](getbarpaintwidth-1.md) |
| --- | --- |











## Definition


A SharpDX [Brush](sharpdx_direct2d1_brush-1.md) object used to paint the down bars for the ChartStyle.


 


## Property  Value


A [SharpDX](sharpdx_direct2d1-1.md) Brush object used to paint the down bars


 


## Syntax


DownBrushDX


 


## Example




| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale, ChartBars chartBars) {    for (int idx \= chartBars.FromIndex; idx \<\= chartBars.ToIndex; idx\+\+)        {            double     closeValue             \= bars.GetClose(idx);             double     openValue               \= bars.GetOpen(idx);              // Set the brush of the current candle to UpBrushDX or DownBrushDX, depending on the             // bar direction            Brush brush \= closeValue \>\= openValue ? UpBrushDX : DownBrushDX;        } } |









