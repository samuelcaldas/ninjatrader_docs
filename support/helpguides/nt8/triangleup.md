
NinjaScript \> Language Reference \> Common \> Drawing \> Draw.TriangleUp() \> TriangleUp
TriangleUp
| \<\< [Click to Display Table of Contents](triangleup.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Drawing](drawing.md) \> [Draw.TriangleUp()](draw_triangleup.md) \> TriangleUp | [Previous page](draw_triangleup.md) [Return to chapter overview](draw_triangleup.md) [Next page](draw_verticalline.md) |
| --- | --- |
## Definition
Represents an interface that exposes information regarding a Triangle Up [IDrawingTool](idrawingtool.md).
 
## Methods and Properties
| Anchor | An [IDrawingTool's ChartAnchor](idrawingtool.htm#chartanchor) representing the point of the drawing object |
| --- | --- |
| AreaBrush | A [Brush](http://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) class representing the fill color of the draw object |
| OutlineBrush | A [Brush](http://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) class representing the outline color of the draw object |

## 
## 
## Examples
| ns |
| --- |
| // Instantiate a TriangleUp object TriangleUp myTri \= Draw.TriangleUp(this, "tag1", true, 0, Low\[0] \- TickSize, Brushes.Red);               // Change the object's AreaBrush myTri.AreaBrush \= Brushes.Beige; |
