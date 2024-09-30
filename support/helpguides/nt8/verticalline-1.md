
NinjaScript \> Language Reference \> Common \> Drawing \> Draw.VerticalLine() \> VerticalLine
VerticalLine

| \<\< [Click to Display Table of Contents](verticalline.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [Drawing](drawing-1.md) \> [Draw.VerticalLine()](draw_verticalline-1.md) \> VerticalLine | [Previous page](draw_verticalline-1.md) [Return to chapter overview](draw_verticalline-1.md) [Next page](brushes-1.md) |
| --- | --- |

## Definition
Represents an interface that exposes information regarding a Vertical Line [IDrawingTool](idrawingtool-1.md).
 
## Methods and Properties
| StartAnchor | An [IDrawingTool's ChartAnchor](idrawingtool-1.htm#chartanchor) representing the starting point of the drawing object |
| --- | --- |
| EndAnchor | An [IDrawingTool's ChartAnchor](idrawingtool-1.htm#chartanchor) representing the end point of the drawing object |
| Stroke | A [Stroke](stroke_class-1.md) object used to draw the object |

## 
## 
## Examples
| ns |
| --- |
| // Instantiate a VerticalLine object VerticalLine myLine \= Draw.VerticalLine(this, "tag1", 10, Brushes.Black);    // Change the object's Stroke myLine.Stroke \= new Stroke(Brushes.BlanchedAlmond, DashStyleHelper.Dot, 5); |

