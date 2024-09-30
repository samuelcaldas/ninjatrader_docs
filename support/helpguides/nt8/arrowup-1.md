
NinjaScript > Language Reference > Common > Drawing > Draw.ArrowUp() > ArrowUp
ArrowUp
| << [Click to Display Table of Contents](arrowup.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [Drawing](drawing-1.md) > [Draw.ArrowUp()](draw_arrowup-1.md) > ArrowUp | [Previous page](draw_arrowup-1.md) [Return to chapter overview](draw_arrowup-1.md) [Next page](draw_diamond-1.md) |
| --- | --- |
## Definition
Represents an interface that exposes information regarding an Arrow Up [IDrawingTool](idrawingtool-1.md).
 
## Methods and Properties
| Anchor | An [IDrawingTool's ChartAnchor](idrawingtool-1.htm#chartanchor) representing the point of the drawing object |
| --- | --- |
| AreaBrush | A [Brush](http://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) object representing the fill color of the draw object |
| OutlineBrush | A [Brush](http://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) object representing the color of the draw object's outline |
## 
## 
## Example
| ns |
| --- |
| // Instantiate an ArrowDown object ArrowUp myArrow = Draw.ArrowUp(this, "tag1", true, Time[0], Low[0] - (2 * TickSize), Brushes.Green);   // Set the outline color of the Arrow myArrow.OutlineBrush = Brushes.Black; |

