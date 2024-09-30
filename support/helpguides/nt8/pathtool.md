
NinjaScript > Language Reference > Common > Drawing > Draw.PathTool() > PathTool

PathTool

| << [Click to Display Table of Contents](pathtool.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > [Drawing](drawing.md) > [Draw.PathTool()](draw_pathtool().md) > PathTool | [Previous page](draw_pathtool().md) [Return to chapter overview](draw_pathtool().md) [Next page](draw_polygon.md) |
| --- | --- |
## Definition
Represents an interface that exposes information regarding a PathTool [IDrawingTool](idrawingtool.md).
 
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
| // Instantiate a PathTool object PathTool myPathTool = Draw.PathTool(this, "tag1", false, 20, 194, 10, 184, 13, 176, 25, 182); |
