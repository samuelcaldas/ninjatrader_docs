



UpBrushDX

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](upbrushdx.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Chart Style](chart_style.htm) >  UpBrushDX | [Previous page](upbrush.htm) [Return to chapter overview](chart_style.htm) [Next page](drawing_tools.htm) |

Definition
----------

A SharpDX [Brush](sharpdx_direct2d1_brush.htm) object used to paint the up bars for the ChartStyle.

Property  Value
---------------

A [SharpDX](sharpdx_direct2d1.htm) Brush object used to paint the up bars

Syntax
------

UpBrushDX

Examples
--------

| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale, ChartBars chartBars)  {     for (int idx = chartBars.FromIndex; idx <= chartBars.ToIndex; idx++)         {             double     closeValue             = bars.GetClose(idx);              double     openValue               = bars.GetOpen(idx);                // Set the brush of the current candle to UpBrushDX or DownBrushDX, depending on the              // bar direction             Brush brush = closeValue >= openValue ? UpBrushDX : DownBrushDX;         }  } |