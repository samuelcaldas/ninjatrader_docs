


NinjaScript \> Language Reference \> Common \> Drawing \> Draw.ArrowUp() \> ArrowUp






















ArrowUp







| \<\< [Click to Display Table of Contents](arrowup.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Drawing](drawing.md) \> [Draw.ArrowUp()](draw_arrowup.md) \> ArrowUp | [Previous page](draw_arrowup.md) [Return to chapter overview](draw_arrowup.md) [Next page](draw_diamond.md) |
| --- | --- |











## Definition


Represents an interface that exposes information regarding an Arrow Up [IDrawingTool](idrawingtool.md).


 


## Methods and Properties




| Anchor | An [IDrawingTool's ChartAnchor](idrawingtool.htm#chartanchor) representing the point of the drawing object |
| --- | --- |
| AreaBrush | A [Brush](http://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) object representing the fill color of the draw object |
| OutlineBrush | A [Brush](http://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) object representing the color of the draw object's outline |



## 


## 


## Example




| ns |
| --- |
| // Instantiate an ArrowDown object ArrowUp myArrow \= Draw.ArrowUp(this, "tag1", true, Time\[0], Low\[0] \- (2 \* TickSize), Brushes.Green);   // Set the outline color of the Arrow myArrow.OutlineBrush \= Brushes.Black; |









