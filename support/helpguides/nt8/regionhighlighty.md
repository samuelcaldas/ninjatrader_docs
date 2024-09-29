


NinjaScript \> Language Reference \> Common \> Drawing \> Draw.RegionHighlightY() \> RegionHighlightY






















RegionHighlightY







| \<\< [Click to Display Table of Contents](regionhighlighty.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Drawing](drawing.md) \> [Draw.RegionHighlightY()](draw_regionhighlighty.md) \> RegionHighlightY | [Previous page](draw_regionhighlighty.md) [Return to chapter overview](draw_regionhighlighty.md) [Next page](draw_regressionchannel.md) |
| --- | --- |











## Definition


Represents an interface that exposes information regarding a Region Highlight Y [IDrawingTool.](idrawingtool.md)


 


## Methods and Properties




| StartAnchor | An [IDrawingTool's ChartAnchor](idrawingtool.htm#chartanchor) representing the starting point of the drawing object |
| --- | --- |
| EndAnchor | An [IDrawingTool's ChartAnchor](idrawingtool.htm#chartanchor) representing the starting point of the drawing object |
| AreaBrush | A [Brush](http://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) class representing the fill color of the draw object |
| AreaOpacity | An int value representing the opacity of the area color |
| OutlineStroke | The [Stroke](stroke_class.md) object used to draw the object's outline |



## 


## 


## Example




| ns |
| --- |
| // Instantiate a RegionHighlightX object RegionHighlightY myReg \= Draw.RegionHighlightY(this, "tag1", 10, 0, Brushes.Blue);   // Change the object's opacity myReg.AreaOpacity \= 25; |









