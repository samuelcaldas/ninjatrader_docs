



Ray

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\ray.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [Drawing](drawing-1.htm) > [Draw.Ray()](draw_ray-1.htm) >  Ray | [Previous page](draw_ray-1.htm) [Return to chapter overview](draw_ray-1.htm) [Next page](draw_rectangle-1.htm) |

Definition
----------

Represents an interface that exposes information regarding a Ray [IDrawingTool](idrawingtool-1.htm).

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
| // Instantiate a Ray object  Ray myRay = Draw.Ray(this, "tag1", 10, 1000, 0, 1001, Brushes.LimeGreen);     // Set a new Stroke for the object  myRay.Stroke = new Stroke(Brushes.Green, DashStyleHelper.DashDot, 3); |