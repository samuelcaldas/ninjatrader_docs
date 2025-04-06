



Ellipse

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\ellipse.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [Drawing](drawing-1.htm) > [Draw.Ellipse()](draw_ellipse-1.htm) >  Ellipse | [Previous page](draw_ellipse-1.htm) [Return to chapter overview](draw_ellipse-1.htm) [Next page](draw_extendedline-1.htm) |

Definition
----------

Represents an interface that exposes information regarding an Ellipse [IDrawingTool](idrawingtool-1.htm).

Methods and Properties
----------------------

|  |  |
| --- | --- |
| StartAnchor | An [IDrawingTool's ChartAnchor](idrawingtool-1.htm#chartanchor) representing the starting point of the drawing object |
| EndAnchor | An [IDrawingTool's ChartAnchor](idrawingtool-1.htm#chartanchor) representing the starting point of the drawing object |
| AreaBrush | A [Brush](http://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) class representing the fill color of the draw object |
| AreaOpacity | An int value representing the opacity of the area color |
| OutlineStroke | The [Stroke](stroke_class-1.htm) object used to draw the object's outline |

Example
-------

| ns |
| --- |
| // Paint a red ellipse on the current bar  Ellipse myEllipse = Draw.Ellipse(this, "tag1", true, 5, Close[5], 0, Close[0], Brushes.Red, Brushes.Red, 5);     // Change the AreaOpacity of the Ellipse  myEllipse.AreaOpacity = 0; |