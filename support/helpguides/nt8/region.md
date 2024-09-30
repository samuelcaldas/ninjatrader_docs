
NinjaScript > Language Reference > Common > Drawing > Draw.Region() > Region

Region

| << [Click to Display Table of Contents](region.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > [Drawing](drawing.md) > [Draw.Region()](draw_region.md) > Region | [Previous page](draw_region.md) [Return to chapter overview](draw_region.md) [Next page](draw_regionhighlightx.md) |
| --- | --- |
## Definition
Represents an interface that exposes information regarding a Region [IDrawingTool.](idrawingtool.md)
 
## Methods and Properties

| StartAnchor | An [IDrawingTool's ChartAnchor](idrawingtool.htm#chartanchor) representing the starting point of the drawing object |
| --- | --- |
| EndAnchor | An [IDrawingTool's ChartAnchor](idrawingtool.htm#chartanchor) representing the starting point of the drawing object |
| AreaOpacity | An int value representing the opacity of the area color |
| AreaBrush | A [Brush](http://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) object representing the fill color of the draw object |
| OutlineStroke | A Stroke used for the outline of the region |
## 
## 
## Example

| ns |
| --- |
| // Instantiate a Region object Region myRegion = Draw.Region(this, "tag1", CurrentBar, 0, Bollinger(2, 14).Upper, Bollinger(2, 14).Lower, null, Brushes.Blue, 50);    // Set the object's OutlineStroke to a new Stroke myRegion.OutlineStroke = new Stroke(Brushes.Red, DashStyleHelper.Solid, 3); |
