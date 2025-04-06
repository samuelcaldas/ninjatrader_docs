



HorizontalLine

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](horizontalline.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Common](common.htm) > [Drawing](drawing.htm) > [Draw.HorizontalLine()](draw_horizontalline.htm) >  HorizontalLine | [Previous page](draw_horizontalline.htm) [Return to chapter overview](draw_horizontalline.htm) [Next page](draw_line.htm) |

Definition
----------

Represents an interface that exposes information regarding a Horizontal Line [IDrawingTool.](idrawingtool.htm)

Methods and Properties
----------------------

|  |  |
| --- | --- |
| StartAnchor | An [IDrawingTool's ChartAnchor](idrawingtool.htm#chartanchor) representing the starting point of the drawing object |
| EndAnchor | An [IDrawingTool's ChartAnchor](idrawingtool.htm#chartanchor) representing the end point of the drawing object |
| Stroke | A [Stroke](stroke_class.htm) object used to draw the object |

Example
-------

| ns |
| --- |
| // Instantiate a HorizontalLine object  HorizontalLine myLine = Draw.HorizontalLine(this, "tag1", 1000, Brushes.Black);     // Set a new Stroke for the object  myLine.Stroke = new Stroke(Brushes.Green, DashStyleHelper.Dash, 5); |