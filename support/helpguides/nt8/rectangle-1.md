
NinjaScript \> Language Reference \> Common \> Drawing \> Draw.Rectangle() \> Rectangle

Rectangle

| \<\< [Click to Display Table of Contents](rectangle.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [Drawing](drawing-1.md) \> [Draw.Rectangle()](draw_rectangle-1.md) \> Rectangle | [Previous page](draw_rectangle-1.md) [Return to chapter overview](draw_rectangle-1.md) [Next page](draw_region-1.md) |
| --- | --- |
## Definition
Represents an interface that exposes information regarding a Rectangle [IDrawingTool](idrawingtool-1.md).
 
## Methods and Properties

| StartAnchor | An [IDrawingTool's ChartAnchor](idrawingtool-1.htm#chartanchor) representing the starting point of the drawing object |
| --- | --- |
| EndAnchor | An [IDrawingTool's ChartAnchor](idrawingtool-1.htm#chartanchor) representing the starting point of the drawing object |
| AreaBrush | A [Brush](http://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) object representing the fill color of the draw object |
| AreaOpacity | An int value representing the opacity of the area color |
| OutlineStroke | The [Stroke](stroke_class-1.md) object used to draw the object's outline |
## 
## 
## Example

| ns |
| --- |
| // Instantiate a Rectangle object Rectangle myRec \= Draw.Rectangle(this, "tag1", 10, Low\[10] \- TickSize, 5, High\[5] \+ TickSize, Brushes.Blue);   // Set the object's AreaBrush to Blue myRec.AreaBrush \= Brushes.Blue; |
