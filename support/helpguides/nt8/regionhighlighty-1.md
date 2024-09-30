
NinjaScript > Language Reference > Common > Drawing > Draw.RegionHighlightY() > RegionHighlightY

RegionHighlightY

| << [Click to Display Table of Contents](regionhighlighty.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [Drawing](drawing-1.md) > [Draw.RegionHighlightY()](draw_regionhighlighty-1.md) > RegionHighlightY | [Previous page](draw_regionhighlighty-1.md) [Return to chapter overview](draw_regionhighlighty-1.md) [Next page](draw_regressionchannel-1.md) |
| --- | --- |
## Definition
Represents an interface that exposes information regarding a Region Highlight Y [IDrawingTool.](idrawingtool-1.md)
 
## Methods and Properties

| StartAnchor | An [IDrawingTool's ChartAnchor](idrawingtool-1.htm#chartanchor) representing the starting point of the drawing object |
| --- | --- |
| EndAnchor | An [IDrawingTool's ChartAnchor](idrawingtool-1.htm#chartanchor) representing the starting point of the drawing object |
| AreaBrush | A [Brush](http://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) class representing the fill color of the draw object |
| AreaOpacity | An int value representing the opacity of the area color |
| OutlineStroke | The [Stroke](stroke_class-1.md) object used to draw the object's outline |
## 
## 
## Example

| ns |
| --- |
| // Instantiate a RegionHighlightX object RegionHighlightY myReg = Draw.RegionHighlightY(this, "tag1", 10, 0, Brushes.Blue);   // Change the object's opacity myReg.AreaOpacity = 25; |
