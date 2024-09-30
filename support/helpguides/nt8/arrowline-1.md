
NinjaScript \> Language Reference \> Common \> Drawing \> Draw.ArrowLine() \> ArrowLine
ArrowLine
| \<\< [Click to Display Table of Contents](arrowline.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [Drawing](drawing-1.md) \> [Draw.ArrowLine()](draw_arrowline-1.md) \> ArrowLine | [Previous page](draw_arrowline-1.md) [Return to chapter overview](draw_arrowline-1.md) [Next page](draw_arrowup-1.md) |
| --- | --- |
## Definition
Represents an interface that exposes information regarding an Arrow Line [IDrawingTool](idrawingtool-1.md).
 
## Methods and Properties
| StartAnchor | An [IDrawingTool's ChartAnchor](idrawingtool-1.htm#chartanchor) representing the starting point of the drawing object |
| --- | --- |
| EndAnchor | An [IDrawingTool's ChartAnchor](idrawingtool-1.htm#chartanchor) representing the end point of the drawing object |
| Stroke | A [Stroke](stroke_class-1.md) object used to draw the object |
## 
## 
## Example
| ns |
| --- |
| // Draw an ArrowLine object ArrowLine myArrow \= Draw.ArrowLine(this, "myArrowLine", 3, High\[3], 1, High\[1], Brushes.Blue, DashStyleHelper.DashDot, 3);   // Disable the arrow's visibility myArrow.IsVisible \= false; |

