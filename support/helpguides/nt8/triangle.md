



Triangle

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](triangle.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Common](common.htm) > [Drawing](drawing.htm) > [Draw.Triangle()](draw_triangle.htm) >  Triangle | [Previous page](draw_triangle.htm) [Return to chapter overview](draw_triangle.htm) [Next page](draw_triangledown.htm) |

Definition
----------

Represents an interface that exposes information regarding a Triangle [IDrawingTool](idrawingtool.htm).

Methods and Properties
----------------------

|  |  |
| --- | --- |
| StartAnchor | An [IDrawingTool's ChartAnchor](idrawingtool.htm#chartanchor) representing the starting point of the drawing object |
| MiddleAnchor | An [IDrawingTool's ChartAnchor](idrawingtool.htm#chartanchor) representing the middle point of the drawing object |
| EndAnchor | An [IDrawingTool's ChartAnchor](idrawingtool.htm#chartanchor) representing the starting point of the drawing object |
| AreaBrush | A [Brush](http://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) class representing the fill color of the draw object |
| AreaOpacity | An int value representing the opacity of the area color |
| OutlineStroke | The [Stroke](stroke_class.htm) object used to draw the object's outline |

Example
-------

| ns |
| --- |
| // Instantiate a Triangle object  Triangle myTri = Draw.Triangle(this, "tag1", 4, Low[4], 3, High[3], 1, Low[1], Brushes.Blue);                 // Change the object's AreaOpacity  myTri.AreaOpacity = 100; |