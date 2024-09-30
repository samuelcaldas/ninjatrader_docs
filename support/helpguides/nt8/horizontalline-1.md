
NinjaScript > Language Reference > Common > Drawing > Draw.HorizontalLine() > HorizontalLine
HorizontalLine
| << [Click to Display Table of Contents](horizontalline.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [Drawing](drawing-1.md) > [Draw.HorizontalLine()](draw_horizontalline-1.md) > HorizontalLine | [Previous page](draw_horizontalline-1.md) [Return to chapter overview](draw_horizontalline-1.md) [Next page](draw_line-1.md) |
| --- | --- |
## Definition
Represents an interface that exposes information regarding a Horizontal Line [IDrawingTool.](idrawingtool-1.md)
 
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
| // Instantiate a HorizontalLine object HorizontalLine myLine = Draw.HorizontalLine(this, "tag1", 1000, Brushes.Black);   // Set a new Stroke for the object myLine.Stroke = new Stroke(Brushes.Green, DashStyleHelper.Dash, 5); |

