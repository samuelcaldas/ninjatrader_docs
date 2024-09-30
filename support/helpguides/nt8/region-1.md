
NinjaScript > Language Reference > Common > Drawing > Draw.Region() > Region

Region

| << [Click to Display Table of Contents](region.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [Drawing](drawing-1.md) > [Draw.Region()](draw_region-1.md) > Region | [Previous page](draw_region-1.md) [Return to chapter overview](draw_region-1.md) [Next page](draw_regionhighlightx-1.md) |
| --- | --- |
## Definition
Represents an interface that exposes information regarding a Region [IDrawingTool.](idrawingtool-1.md)
 
## Methods and Properties

| StartAnchor | An [IDrawingTool's ChartAnchor](idrawingtool-1.htm#chartanchor) representing the starting point of the drawing object |
| --- | --- |
| EndAnchor | An [IDrawingTool's ChartAnchor](idrawingtool-1.htm#chartanchor) representing the starting point of the drawing object |
| AreaOpacity | An int value representing the opacity of the area color |
| AreaBrush | A [Brush](http://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) object representing the fill color of the draw object |
| OutlineStroke | A Stroke used for the outline of the region |
## 
## 
## Example

| ns |
| --- |
| // Instantiate a Region object Region myRegion = Draw.Region(this, "tag1", CurrentBar, 0, Bollinger(2, 14).Upper, Bollinger(2, 14).Lower, null, Brushes.Blue, 50);    // Set the object's OutlineStroke to a new Stroke myRegion.OutlineStroke = new Stroke(Brushes.Red, DashStyleHelper.Solid, 3); |
