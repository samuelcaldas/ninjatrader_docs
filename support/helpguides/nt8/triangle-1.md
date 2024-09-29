


NinjaScript \> Language Reference \> Common \> Drawing \> Draw.Triangle() \> Triangle






















Triangle







| \<\< [Click to Display Table of Contents](triangle.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [Drawing](drawing-1.md) \> [Draw.Triangle()](draw_triangle-1.md) \> Triangle | [Previous page](draw_triangle-1.md) [Return to chapter overview](draw_triangle-1.md) [Next page](draw_triangledown-1.md) |
| --- | --- |











## Definition


Represents an interface that exposes information regarding a Triangle [IDrawingTool](idrawingtool-1.md).


 


## Methods and Properties




| StartAnchor | An [IDrawingTool's ChartAnchor](idrawingtool-1.htm#chartanchor) representing the starting point of the drawing object |
| --- | --- |
| MiddleAnchor | An [IDrawingTool's ChartAnchor](idrawingtool-1.htm#chartanchor) representing the middle point of the drawing object |
| EndAnchor | An [IDrawingTool's ChartAnchor](idrawingtool-1.htm#chartanchor) representing the starting point of the drawing object |
| AreaBrush | A [Brush](http://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) class representing the fill color of the draw object |
| AreaOpacity | An int value representing the opacity of the area color |
| OutlineStroke | The [Stroke](stroke_class-1.md) object used to draw the object's outline |



## 


## 


## 


## Example




| ns |
| --- |
| // Instantiate a Triangle object Triangle myTri \= Draw.Triangle(this, "tag1", 4, Low\[4], 3, High\[3], 1, Low\[1], Brushes.Blue);               // Change the object's AreaOpacity myTri.AreaOpacity \= 100; |









