
NinjaScript > Language Reference > Common > Drawing > Draw.TriangleDown() > TriangleDown
TriangleDown
| << [Click to Display Table of Contents](triangledown.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > [Drawing](drawing.md) > [Draw.TriangleDown()](draw_triangledown.md) > TriangleDown | [Previous page](draw_triangledown.md) [Return to chapter overview](draw_triangledown.md) [Next page](draw_triangleup.md) |
| --- | --- |
## Definition
Represents an interface that exposes information regarding a Triangle Down [IDrawingTool](idrawingtool.md).
 
## Methods and Properties
| Anchor | An [IDrawingTool's ChartAnchor](idrawingtool.htm#chartanchor) representing the point of the drawing object |
| --- | --- |
| AreaBrush | A [Brush](http://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) class representing the fill color of the draw object |
| OutlineBrush | A [Brush](http://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) class representing the outline color of the draw object |

## 
## 
## 
## Example
| ns |
| --- |
| // Instantiate a TriangleDown object TriangleDown myTri = Draw.TriangleDown(this, "tag1", true, 0, Low[0] - TickSize, Brushes.Red);               // Change the object's AreaBrush myTri.AreaBrush = Brushes.Beige; |
