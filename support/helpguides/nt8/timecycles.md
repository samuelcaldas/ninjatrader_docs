
NinjaScript \> Language Reference \> Common \> Drawing \> Draw.TimeCycles() \> TimeCycles
TimeCycles

| \<\< [Click to Display Table of Contents](timecycles.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Drawing](drawing.md) \> [Draw.TimeCycles()](draw_timecycles.md) \> TimeCycles | [Previous page](draw_timecycles.md) [Return to chapter overview](draw_timecycles.md) [Next page](draw_trendchannel.md) |
| --- | --- |

## Definition
Represents an interface that exposes information regarding a TimeCyles [IDrawingTool](idrawingtool.md).
 
## Methods and Properties
| Anchor | An [IDrawingTool's ChartAnchor](idrawingtool.htm#chartanchor) representing the point of the drawing object |
| --- | --- |
| OutlineStroke | A Stroke used for the outline of the region |
| AreaBrush | A [Brush](http://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) object representing the fill color of the draw object |

## 
## 
## 
## Example
| ns |
| --- |
| // Instantiate a Time Cycles object TimeCycles myTimeCycles \= (this, "tag1", 0, 10, Brushes.CornflowerBlue, Brushes.CornflowerBlue, 40);   // Change the object's OutlineBrush myTimeCycles.OutlineStroke \= newÂ Stroke(Brushes.Red); |

