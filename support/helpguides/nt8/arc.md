



Arc

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](arc.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Common](common.htm) > [Drawing](drawing.htm) > [Draw.Arc()](draw_arc.htm) >  Arc | [Previous page](draw_arc.htm) [Return to chapter overview](draw_arc.htm) [Next page](draw_arrowdown.htm) |

Definition
----------

Represents an interface that exposes information regarding an Arc [IDrawingTool](idrawingtool.htm).

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
| // Draw an Arc object  Arc myArc = Draw.Arc(this, "myArc", Time[10], Close[10], Time[0], Close[0], Brushes.Blue);     // Set the opacity of the shading between the arc and the chord  myArc.AreaOpacity = 100; |