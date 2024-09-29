


NinjaScript \> Language Reference \> Common \> Drawing \> Draw.Ellipse() \> Ellipse






















Ellipse







| \<\< [Click to Display Table of Contents](ellipse.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Drawing](drawing.md) \> [Draw.Ellipse()](draw_ellipse.md) \> Ellipse | [Previous page](draw_ellipse.md) [Return to chapter overview](draw_ellipse.md) [Next page](draw_extendedline.md) |
| --- | --- |











## Definition


Represents an interface that exposes information regarding an Ellipse [IDrawingTool](idrawingtool.md).


 


## Methods and Properties




| StartAnchor | An [IDrawingTool's ChartAnchor](idrawingtool.htm#chartanchor) representing the starting point of the drawing object |
| --- | --- |
| EndAnchor | An [IDrawingTool's ChartAnchor](idrawingtool.htm#chartanchor) representing the starting point of the drawing object |
| AreaBrush | A [Brush](http://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) class representing the fill color of the draw object |
| AreaOpacity | An int value representing the opacity of the area color |
| OutlineStroke | The [Stroke](stroke_class.md) object used to draw the object's outline |



## 


## 


## Example




| ns |
| --- |
| // Paint a red ellipse on the current bar Ellipse myEllipse \= Draw.Ellipse(this, "tag1", true, 5, Close\[5], 0, Close\[0], Brushes.Red, Brushes.Red, 5);   // Change the AreaOpacity of the Ellipse myEllipse.AreaOpacity \= 0; |









