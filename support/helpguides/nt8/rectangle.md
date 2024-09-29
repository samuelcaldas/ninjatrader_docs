


NinjaScript \> Language Reference \> Common \> Drawing \> Draw.Rectangle() \> Rectangle






















Rectangle







| \<\< [Click to Display Table of Contents](rectangle.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Drawing](drawing.md) \> [Draw.Rectangle()](draw_rectangle.md) \> Rectangle | [Previous page](draw_rectangle.md) [Return to chapter overview](draw_rectangle.md) [Next page](draw_region.md) |
| --- | --- |











## Definition


Represents an interface that exposes information regarding a Rectangle [IDrawingTool](idrawingtool.md).


 


## Methods and Properties




| StartAnchor | An [IDrawingTool's ChartAnchor](idrawingtool.htm#chartanchor) representing the starting point of the drawing object |
| --- | --- |
| EndAnchor | An [IDrawingTool's ChartAnchor](idrawingtool.htm#chartanchor) representing the starting point of the drawing object |
| AreaBrush | A [Brush](http://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) object representing the fill color of the draw object |
| AreaOpacity | An int value representing the opacity of the area color |
| OutlineStroke | The [Stroke](stroke_class.md) object used to draw the object's outline |



## 


## 


## Example




| ns |
| --- |
| // Instantiate a Rectangle object Rectangle myRec \= Draw.Rectangle(this, "tag1", 10, Low\[10] \- TickSize, 5, High\[5] \+ TickSize, Brushes.Blue);   // Set the object's AreaBrush to Blue myRec.AreaBrush \= Brushes.Blue; |









