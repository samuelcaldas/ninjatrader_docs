



Ray

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](ray.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Common](common.htm) > [Drawing](drawing.htm) > [Draw.Ray()](draw_ray.htm) >  Ray | [Previous page](draw_ray.htm) [Return to chapter overview](draw_ray.htm) [Next page](draw_rectangle.htm) |

Definition
----------

Represents an interface that exposes information regarding a Ray [IDrawingTool](idrawingtool.htm).

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
| // Instantiate a Ray object  Ray myRay = Draw.Ray(this, "tag1", 10, 1000, 0, 1001, Brushes.LimeGreen);     // Set a new Stroke for the object  myRay.Stroke = new Stroke(Brushes.Green, DashStyleHelper.DashDot, 3); |