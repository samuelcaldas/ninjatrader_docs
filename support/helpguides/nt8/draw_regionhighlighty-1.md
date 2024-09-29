


NinjaScript \> Language Reference \> Common \> Drawing \> Draw.RegionHighlightY()






















Draw.RegionHighlightY()







| \<\< [Click to Display Table of Contents](draw_regionhighlighty.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [Drawing](drawing-1.md) \> Draw.RegionHighlightY() | [Previous page](regionhighlightx-1.md) [Return to chapter overview](drawing-1.md) [Next page](regionhighlighty-1.md) |
| --- | --- |











## Definition


Draws a region highlight y on a chart.


 


## Method Return Value


A [RegionHighlightY](regionhighlighty-1.md) object that represents the draw object.


 


Syntax


Draw.RegionHighlightY(NinjaScriptBase owner, string tag, double startY, double endY, Brush brush)  

Draw.RegionHighlightY(NinjaScriptBase owner, string tag, bool isAutoScale, double startY, double endY, Brush brush, Brush areaBrush, int areaOpacity)  

Draw.RegionHighlightY(NinjaScriptBase owner, string tag, double startY, double endY, bool isGlobal, string templateName)


 


## Parameters




| owner | The hosting NinjaScript object which is calling the draw method   Typically will be the object which is calling the draw method (e.g., "this") |
| --- | --- |
| tag | A user defined unique id used to reference the draw object.    For example, if you pass in a value of "myTag", each time this tag is used, the same draw object is modified. If unique tags are used each time, a new draw object will be created each time. |
| isAutoScale | Determines if the draw object will be included in the y\-axis scale. Default value is false. |
| startY | The starting y value co\-ordinate where the draw object will be drawn |
| endY | The ending y value co\-ordinate where the draw object will be drawn |
| brush | The brush used to color the outline of draw object ([reference](https://msdn.microsoft.com/en-us/library/system.windows.media.brushes%28v=vs.110%29.aspx)) |
| areaBrush | The brush used to color the fill area of the draw object ([reference](https://msdn.microsoft.com/en-us/library/system.windows.media.brushes%28v=vs.110%29.aspx)) |
| areaOpacity | Sets the level of transparency for the fill color. Valid values between 0 \- 100\. (0 \= completely transparent, 100 \= no opacity) |
| isGlobal | Determines if the draw object will be global across all charts which match the instrument |
| templateName | The name of the drawing tool template the object will use to determine various visual properties (empty string could be used to just use the UI default visuals instead) |



 


## 


## Examples




| ns |
| --- |
| // Fills in the region between the startY and endY Draw.RegionHighlightY(this, "tag1", true, High\[0], Low\[0], Brushes.Blue, Brushes.Green, 20); |









