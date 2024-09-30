
NinjaScript \> Language Reference \> Common \> Drawing \> Draw.Arc() \> Arc
Arc
| \<\< [Click to Display Table of Contents](arc.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [Drawing](drawing-1.md) \> [Draw.Arc()](draw_arc-1.md) \> Arc | [Previous page](draw_arc-1.md) [Return to chapter overview](draw_arc-1.md) [Next page](draw_arrowdown-1.md) |
| --- | --- |
## Definition
Represents an interface that exposes information regarding an Arc [IDrawingTool](idrawingtool-1.md).
 
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
| // Draw an Arc object Arc myArc \= Draw.Arc(this, "myArc", Time\[10], Close\[10], Time\[0], Close\[0], Brushes.Blue);   // Set the opacity of the shading between the arc and the chord myArc.AreaOpacity \= 100; |

