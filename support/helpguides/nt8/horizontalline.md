
NinjaScript > Language Reference > Common > Drawing > Draw.HorizontalLine() > HorizontalLine
HorizontalLine
| << [Click to Display Table of Contents](horizontalline.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > [Drawing](drawing.md) > [Draw.HorizontalLine()](draw_horizontalline.md) > HorizontalLine | [Previous page](draw_horizontalline.md) [Return to chapter overview](draw_horizontalline.md) [Next page](draw_line.md) |
| --- | --- |
## Definition
Represents an interface that exposes information regarding a Horizontal Line [IDrawingTool.](idrawingtool.md)
 
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
| // Instantiate a HorizontalLine object HorizontalLine myLine = Draw.HorizontalLine(this, "tag1", 1000, Brushes.Black);   // Set a new Stroke for the object myLine.Stroke = new Stroke(Brushes.Green, DashStyleHelper.Dash, 5); |

