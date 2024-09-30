
NinjaScript > Language Reference > Common > Drawing > Draw.Polygon() > Polygon

Polygon

| << [Click to Display Table of Contents](polygon.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > [Drawing](drawing.md) > [Draw.Polygon()](draw_polygon.md) > Polygon | [Previous page](draw_polygon.md) [Return to chapter overview](draw_polygon.md) [Next page](draw_ray.md) |
| --- | --- |
## Definition
Represents an interface that exposes information regarding a Polyon [IDrawingTool](idrawingtool.md).
 
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
| // Instantiate a Polygon object Polygon myPolygon = Draw.Polygon(this, "tag1", false, 20, 194, 10, 184, 13, 176, 25, 182);   // Set a new area brush for the object myPolygon.AreaBrush = Brushes.Green; |
