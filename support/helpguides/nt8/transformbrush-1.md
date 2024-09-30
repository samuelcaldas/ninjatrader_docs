
NinjaScript > Language Reference > Chart Style > TransformBrush()
TransformBrush()
| << [Click to Display Table of Contents](transformbrush.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Chart Style](chart_style-1.md) > TransformBrush() | [Previous page](setpropertyname-1.md) [Return to chapter overview](chart_style-1.md) [Next page](upbrush-1.md) |
| --- | --- |
## Definition
Scales a non-solid color brush used for rendering the chart style to properly display in NinjaTrader.
 
| Note:  This method has no impact on solid color brushes.  You would only need to pass in either a linear or radial gradient brush. |
| --- |

 
## Method Return Value
This method does not return a value.
 
## Syntax
TransformBrush(SharpDX.Direct2D1.Brush brush, RectangleF rect)
## 
## 
## Method Parameters
| brush | A [SharpDX.Direct2D1.Brush](sharpdx_direct2d1_brush-1.md) object representing the brush used to render |
| --- | --- |
| rect | A [RectangleF](https://msdn.microsoft.com/en-us/library/system.drawing.rectanglef%28v=vs.110%29.aspx) structure representing the rectangle to be rendered |

 
## 
## Examples
| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale, ChartBars chartBars) {     TransformBrush(brush, rect); } |
