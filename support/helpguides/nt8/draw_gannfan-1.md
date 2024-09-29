


NinjaScript \> Language Reference \> Common \> Drawing \> Draw.GannFan()






















Draw.GannFan()







| \<\< [Click to Display Table of Contents](draw_gannfan.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [Drawing](drawing-1.md) \> Draw.GannFan() | [Previous page](fibonaccitimeextensions-1.md) [Return to chapter overview](drawing-1.md) [Next page](gannfan-1.md) |
| --- | --- |











## Definition


Draws a Gann Fan.


 


## Method Return Value


A [GannFan](gannfan-1.md) object that represents the draw object.


 


## Syntax
Draw.GannFan(NinjaScriptBase owner, string tag, bool isAutoScale, int barsAgo, double y)
Draw.GannFan(NinjaScriptBase owner, string tag, bool isAutoScale, DateTime time, double y)
Draw.GannFan(NinjaScriptBase owner, string tag, bool isAutoScale, int barsAgo, double y, bool isGlobal, string templateName)
Draw.GannFan(NinjaScriptBase owner, string tag, bool isAutoScale, DateTime time, double y, bool isGlobal, string templateName)


## 


 


## Parameters




| owner | The hosting NinjaScript object which is calling the draw method   Typically will be the object which is calling the draw method (e.g., "this") |
| --- | --- |
| tag | A user defined unique id used to reference the draw object.    For example, if you pass in a value of "myTag", each time this tag is used, the same draw object is modified. If unique tags are used each time, a new draw object will be created each time. |
| isAutoScale | Determines if the draw object will be included in the y\-axis scale |
| barsAgo | The bar the object will be drawn at. A value of 10 would be 10 bars ago. |
| time | The time the object will be drawn at. |
| y | The y value |
| isGlobal | Determines if the draw object will be global across all charts which match the instrument |
| templateName | The name of the drawing tool template the object will use to determine various visual properties (empty string could be used to just use the UI default visuals instead) |



 


## 


## Examples




| ns |
| --- |
| // Draws a Gann Fan at the current bar low Draw.GannFan(this, "tag1", true, 0, Low\[0]); |









