



Dot

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\dot.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [Drawing](drawing-1.htm) > [Draw.Dot()](draw_dot-1.htm) >  Dot | [Previous page](draw_dot-1.htm) [Return to chapter overview](draw_dot-1.htm) [Next page](draw_ellipse-1.htm) |

Definition
----------

Represents an interface that exposes information regarding a Dot [IDrawingTool](idrawingtool-1.htm).

Methods and Properties
----------------------

|  |  |
| --- | --- |
| Anchor | An [IDrawingTool's ChartAnchor](idrawingtool-1.htm#chartanchor) representing the point of the drawing object |
| AreaBrush | A [Brush](http://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) object representing the fill color of the draw object |
| OutlineBrush | A [Brush](http://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) object representing the color of the draw object's outline |

Example
-------

| ns |
| --- |
| // Instantiates a red dot on the current bar 1 tick below the low  Dot myDot = Draw.Dot(this, "tag1", true, 0, Low[0] - TickSize, Brushes.Red);     // Disable the dot's Auto Scale property  myDot.IsAutoScale = false; |