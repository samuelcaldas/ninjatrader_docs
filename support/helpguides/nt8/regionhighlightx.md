


NinjaScript \> Language Reference \> Common \> Drawing \> Draw.RegionHighlightX() \> RegionHighlightX






















RegionHighlightX







| \<\< [Click to Display Table of Contents](regionhighlightx.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Drawing](drawing.md) \> [Draw.RegionHighlightX()](draw_regionhighlightx.md) \> RegionHighlightX | [Previous page](draw_regionhighlightx.md) [Return to chapter overview](draw_regionhighlightx.md) [Next page](draw_regionhighlighty.md) |
| --- | --- |











## Definition


Represents an interface that exposes information regarding a Region Highlight X [IDrawingTool](idrawingtool.md).


 


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
| // Instantiate a RegionHighlightX object RegionHighlightX myReg \= Draw.RegionHighlightX(this, "tag1", 10, 0, Brushes.Blue);   // Change the object's opacity myReg.AreaOpacity \= 25; |









