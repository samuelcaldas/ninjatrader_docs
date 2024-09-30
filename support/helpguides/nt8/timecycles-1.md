
NinjaScript > Language Reference > Common > Drawing > Draw.TimeCycles() > TimeCycles
TimeCycles
| << [Click to Display Table of Contents](timecycles.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [Drawing](drawing-1.md) > [Draw.TimeCycles()](draw_timecycles-1.md) > TimeCycles | [Previous page](draw_timecycles-1.md) [Return to chapter overview](draw_timecycles-1.md) [Next page](draw_trendchannel-1.md) |
| --- | --- |
## Definition
Represents an interface that exposes information regarding a TimeCyles [IDrawingTool](idrawingtool-1.md).
 
## Methods and Properties
| Anchor | An [IDrawingTool's ChartAnchor](idrawingtool-1.htm#chartanchor) representing the point of the drawing object |
| --- | --- |
| OutlineStroke | A Stroke used for the outline of the region |
| AreaBrush | A [Brush](http://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) object representing the fill color of the draw object |

## 
## 
## 
## Example
| ns |
| --- |
| // Instantiate a Time Cycles object TimeCycles myTimeCycles = (this, "tag1", 0, 10, Brushes.CornflowerBlue, Brushes.CornflowerBlue, 40);   // Change the object's OutlineBrush myTimeCycles.OutlineStroke = newÂ Stroke(Brushes.Red); |
