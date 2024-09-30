
NinjaScript \> Language Reference \> Common \> Drawing \> Draw.Polygon() \> Polygon

Polygon

| \<\< [Click to Display Table of Contents](polygon.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [Drawing](drawing-1.md) \> [Draw.Polygon()](draw_polygon-1.md) \> Polygon | [Previous page](draw_polygon-1.md) [Return to chapter overview](draw_polygon-1.md) [Next page](draw_ray-1.md) |
| --- | --- |
## Definition
Represents an interface that exposes information regarding a Polyon [IDrawingTool](idrawingtool-1.md).
 
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
| // Instantiate a Polygon object Polygon myPolygon \= Draw.Polygon(this, "tag1", false, 20, 194, 10, 184, 13, 176, 25, 182);   // Set a new area brush for the object myPolygon.AreaBrush \= Brushes.Green; |
