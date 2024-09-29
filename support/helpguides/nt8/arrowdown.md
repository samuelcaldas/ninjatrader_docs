


NinjaScript \> Language Reference \> Common \> Drawing \> Draw.ArrowDown() \> ArrowDown






















ArrowDown







| \<\< [Click to Display Table of Contents](arrowdown.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Drawing](drawing.md) \> [Draw.ArrowDown()](draw_arrowdown.md) \> ArrowDown | [Previous page](draw_arrowdown.md) [Return to chapter overview](draw_arrowdown.md) [Next page](draw_arrowline.md) |
| --- | --- |











## Definition


Represents an interface that exposes information regarding an Arrow Down [IDrawingTool](idrawingtool.md).


 


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
| // Instantiate an ArrowDown object ArrowDown myArrow \= Draw.ArrowDown(this, "tag1", true, Time\[0], High\[0] \+ (2 \* TickSize), Brushes.Green);   // Set the outline color of the Arrow myArrow.OutlineBrush \= Brushes.Black; |









