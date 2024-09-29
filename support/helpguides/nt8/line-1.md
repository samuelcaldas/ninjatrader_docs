


NinjaScript \> Language Reference \> Common \> Drawing \> Draw.Line() \> Line






















Line







| \<\< [Click to Display Table of Contents](line.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [Drawing](drawing-1.md) \> [Draw.Line()](draw_line-1.md) \> Line | [Previous page](draw_line-1.md) [Return to chapter overview](draw_line-1.md) [Next page](draw_pathtool()-1.md) |
| --- | --- |











## Definition


Represents an interface that exposes information regarding a Line [IDrawingTool](idrawingtool-1.md).


 


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
| // Instantiate a Line object NinjaTrader.NinjaScript.DrawingTools.Line myLine \= Draw.Line(this, "tag1", false, 10, 1000, 0, 1001, Brushes.LimeGreen, DashStyleHelper.Dot, 2);   // Set a new Stroke for the object myLine.Stroke \= new Stroke(Brushes.Green, DashStyleHelper.Dash, 5); |



 


 




| Note: To differentiate between NinjaTrader.NinjaScript.DrawingTools.Line and NinjaTrader.Gui.Line when assigning a Line object, you will need to invoke the former path explicitly, as seen in the example above. |
| --- |









