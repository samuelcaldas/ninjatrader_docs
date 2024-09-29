


NinjaScript \> Language Reference \> Common \> Drawing \> Draw.Ray() \> Ray






















Ray







| \<\< [Click to Display Table of Contents](ray.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Drawing](drawing.md) \> [Draw.Ray()](draw_ray.md) \> Ray | [Previous page](draw_ray.md) [Return to chapter overview](draw_ray.md) [Next page](draw_rectangle.md) |
| --- | --- |











## Definition


Represents an interface that exposes information regarding a Ray [IDrawingTool](idrawingtool.md).


 


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
| // Instantiate a Ray object Ray myRay \= Draw.Ray(this, "tag1", 10, 1000, 0, 1001, Brushes.LimeGreen);   // Set a new Stroke for the object myRay.Stroke \= new Stroke(Brushes.Green, DashStyleHelper.DashDot, 3); |









