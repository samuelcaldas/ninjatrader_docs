
NinjaScript > Language Reference > Common > Drawing > Draw.PathTool() > PathTool

PathTool

| << [Click to Display Table of Contents](pathtool.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [Drawing](drawing-1.md) > [Draw.PathTool()](draw_pathtool()-1.md) > PathTool | [Previous page](draw_pathtool()-1.md) [Return to chapter overview](draw_pathtool()-1.md) [Next page](draw_polygon-1.md) |
| --- | --- |
## Definition
Represents an interface that exposes information regarding a PathTool [IDrawingTool](idrawingtool-1.md).
 
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
| // Instantiate a PathTool object PathTool myPathTool = Draw.PathTool(this, "tag1", false, 20, 194, 10, 184, 13, 176, 25, 182); |
