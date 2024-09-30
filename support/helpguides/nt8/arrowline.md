
NinjaScript > Language Reference > Common > Drawing > Draw.ArrowLine() > ArrowLine
ArrowLine
| << [Click to Display Table of Contents](arrowline.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > [Drawing](drawing.md) > [Draw.ArrowLine()](draw_arrowline.md) > ArrowLine | [Previous page](draw_arrowline.md) [Return to chapter overview](draw_arrowline.md) [Next page](draw_arrowup.md) |
| --- | --- |
## Definition
Represents an interface that exposes information regarding an Arrow Line [IDrawingTool](idrawingtool.md).
 
## Methods and Properties
| StartAnchor | An [IDrawingTool's ChartAnchor](idrawingtool.htm#chartanchor) representing the starting point of the drawing object |
| --- | --- |
| EndAnchor | An [IDrawingTool's ChartAnchor](idrawingtool.htm#chartanchor) representing the end point of the drawing object |
| Stroke | A [Stroke](stroke_class.md) object used to draw the object |
## 
## 
## Example
| ns |
| --- |
| // Draw an ArrowLine object ArrowLine myArrow = Draw.ArrowLine(this, "myArrowLine", 3, High[3], 1, High[1], Brushes.Blue, DashStyleHelper.DashDot, 3);   // Disable the arrow's visibility myArrow.IsVisible = false; |

