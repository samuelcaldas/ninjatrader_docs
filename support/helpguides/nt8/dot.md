


NinjaScript \> Language Reference \> Common \> Drawing \> Draw.Dot() \> Dot






















Dot







| \<\< [Click to Display Table of Contents](dot.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Drawing](drawing.md) \> [Draw.Dot()](draw_dot.md) \> Dot | [Previous page](draw_dot.md) [Return to chapter overview](draw_dot.md) [Next page](draw_ellipse.md) |
| --- | --- |











## Definition


Represents an interface that exposes information regarding a Dot [IDrawingTool](idrawingtool.md).


 


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
| // Instantiates a red dot on the current bar 1 tick below the low Dot myDot \= Draw.Dot(this, "tag1", true, 0, Low\[0] \- TickSize, Brushes.Red);   // Disable the dot's Auto Scale property myDot.IsAutoScale \= false; |









