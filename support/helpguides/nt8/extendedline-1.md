



ExtendedLine

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\extendedline.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [Drawing](drawing-1.htm) > [Draw.ExtendedLine()](draw_extendedline-1.htm) >  ExtendedLine | [Previous page](draw_extendedline-1.htm) [Return to chapter overview](draw_extendedline-1.htm) [Next page](draw_fibonaccicircle-1.htm) |

Definition
----------

Represents an interface that exposes information regarding an Extended Line [IDrawingTool](idrawingtool-1.htm).

Methods and Properties
----------------------

|  |  |
| --- | --- |
| StartAnchor | An [IDrawingTool's ChartAnchor](idrawingtool-1.htm#chartanchor) representing the starting point of the drawing object |
| EndAnchor | An [IDrawingTool's ChartAnchor](idrawingtool-1.htm#chartanchor) representing the end point of the drawing object |
| Stroke | A [Stroke](stroke_class-1.htm) object used to draw the object |

Example
-------

| ns |
| --- |
| // Instantiate a dotted lime green Extended Line  ExtendedLine myLine = Draw.ExtendedLine(this, "tag1", 10, Close[10], 0, Close[0], Brushes.LimeGreen, DashStyleHelper.Dot, 2);     // Make the line a Global Drawing Object  myLine.IsGlobalDrawingTool = true; |