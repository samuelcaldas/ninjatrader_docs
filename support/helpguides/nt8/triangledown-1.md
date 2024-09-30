
NinjaScript > Language Reference > Common > Drawing > Draw.TriangleDown() > TriangleDown
TriangleDown
| << [Click to Display Table of Contents](triangledown.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [Drawing](drawing-1.md) > [Draw.TriangleDown()](draw_triangledown-1.md) > TriangleDown | [Previous page](draw_triangledown-1.md) [Return to chapter overview](draw_triangledown-1.md) [Next page](draw_triangleup-1.md) |
| --- | --- |
## Definition
Represents an interface that exposes information regarding a Triangle Down [IDrawingTool](idrawingtool-1.md).
 
## Methods and Properties
| Anchor | An [IDrawingTool's ChartAnchor](idrawingtool-1.htm#chartanchor) representing the point of the drawing object |
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
