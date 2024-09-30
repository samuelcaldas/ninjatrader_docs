
NinjaScript \> Language Reference \> Common \> Drawing \> Draw.Arc() \> Arc
Arc
| \<\< [Click to Display Table of Contents](arc.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Drawing](drawing.md) \> [Draw.Arc()](draw_arc.md) \> Arc | [Previous page](draw_arc.md) [Return to chapter overview](draw_arc.md) [Next page](draw_arrowdown.md) |
| --- | --- |
## Definition
Represents an interface that exposes information regarding an Arc [IDrawingTool](idrawingtool.md).
 
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
| // Draw an Arc object Arc myArc \= Draw.Arc(this, "myArc", Time\[10], Close\[10], Time\[0], Close\[0], Brushes.Blue);   // Set the opacity of the shading between the arc and the chord myArc.AreaOpacity \= 100; |

