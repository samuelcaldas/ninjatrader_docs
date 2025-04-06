



Square

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](square.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Common](common.htm) > [Drawing](drawing.htm) > [Draw.Square()](draw_square.htm) >  Square | [Previous page](draw_square.htm) [Return to chapter overview](draw_square.htm) [Next page](draw_text.htm) |

Definition
----------

Represents an interface that exposes information regarding a Square [IDrawingTool](idrawingtool.htm).

Methods and Properties
----------------------

|  |  |
| --- | --- |
| Anchor | An [IDrawingTool's ChartAnchor](idrawingtool.htm#chartanchor) representing the point of the drawing object |
| OutlineBrush | A [Brush](http://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) used for the outline of the square |
| AreaBrush | A [Brush](http://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) object representing the fill color of the draw object |

Example
-------

| ns |
| --- |
| // Instantiate a Square object  Square mySquare = Draw.Square(this, "tag1", true, 0, Low[0] - TickSize, Brushes.Red);     // Change the object's OutlineBrush  mySquare.OutlineBrush = Brushes.Blue; |