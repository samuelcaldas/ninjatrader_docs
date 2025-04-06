



ExtendedLine

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](extendedline.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Common](common.htm) > [Drawing](drawing.htm) > [Draw.ExtendedLine()](draw_extendedline.htm) >  ExtendedLine | [Previous page](draw_extendedline.htm) [Return to chapter overview](draw_extendedline.htm) [Next page](draw_fibonaccicircle.htm) |

Definition
----------

Represents an interface that exposes information regarding an Extended Line [IDrawingTool](idrawingtool.htm).

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
| // Instantiate a dotted lime green Extended Line  ExtendedLine myLine = Draw.ExtendedLine(this, "tag1", 10, Close[10], 0, Close[0], Brushes.LimeGreen, DashStyleHelper.Dot, 2);     // Make the line a Global Drawing Object  myLine.IsGlobalDrawingTool = true; |