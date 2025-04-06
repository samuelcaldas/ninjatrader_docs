



TimeCycles

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](timecycles.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Common](common.htm) > [Drawing](drawing.htm) > [Draw.TimeCycles()](draw_timecycles.htm) >  TimeCycles | [Previous page](draw_timecycles.htm) [Return to chapter overview](draw_timecycles.htm) [Next page](draw_trendchannel.htm) |

Definition
----------

Represents an interface that exposes information regarding a TimeCyles [IDrawingTool](idrawingtool.htm).

Methods and Properties
----------------------

|  |  |
| --- | --- |
| Anchor | An [IDrawingTool's ChartAnchor](idrawingtool.htm#chartanchor) representing the point of the drawing object |
| OutlineStroke | A Stroke used for the outline of the region |
| AreaBrush | A [Brush](http://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) object representing the fill color of the draw object |

Example
-------

| ns |
| --- |
| // Instantiate a Time Cycles object  TimeCycles myTimeCycles = (this, "tag1", 0, 10, Brushes.CornflowerBlue, Brushes.CornflowerBlue, 40);     // Change the object's OutlineBrush  myTimeCycles.OutlineStroke = newÂ Stroke(Brushes.Red); |