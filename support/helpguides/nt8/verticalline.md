


NinjaScript \> Language Reference \> Common \> Drawing \> Draw.VerticalLine() \> VerticalLine






















VerticalLine







| \<\< [Click to Display Table of Contents](verticalline.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Drawing](drawing.md) \> [Draw.VerticalLine()](draw_verticalline.md) \> VerticalLine | [Previous page](draw_verticalline.md) [Return to chapter overview](draw_verticalline.md) [Next page](brushes.md) |
| --- | --- |











## Definition


Represents an interface that exposes information regarding a Vertical Line [IDrawingTool](idrawingtool.md).


 


## Methods and Properties




| StartAnchor | An [IDrawingTool's ChartAnchor](idrawingtool.htm#chartanchor) representing the starting point of the drawing object |
| --- | --- |
| EndAnchor | An [IDrawingTool's ChartAnchor](idrawingtool.htm#chartanchor) representing the end point of the drawing object |
| Stroke | A [Stroke](stroke_class.md) object used to draw the object |



## 


## 


## Examples




| ns |
| --- |
| // Instantiate a VerticalLine object VerticalLine myLine \= Draw.VerticalLine(this, "tag1", 10, Brushes.Black);    // Change the object's Stroke myLine.Stroke \= new Stroke(Brushes.BlanchedAlmond, DashStyleHelper.Dot, 5); |









