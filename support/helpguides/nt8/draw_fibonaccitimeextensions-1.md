
NinjaScript \> Language Reference \> Common \> Drawing \> Draw.FibonacciTimeExtensions()
Draw.FibonacciTimeExtensions()
| \<\< [Click to Display Table of Contents](draw_fibonaccitimeextensions.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [Drawing](drawing-1.md) \> Draw.FibonacciTimeExtensions() | [Previous page](fibonacciretracements-1.md) [Return to chapter overview](drawing-1.md) [Next page](fibonaccitimeextensions-1.md) |
| --- | --- |
## Definition
Draws a fibonacci time extension.
 
## Method Return Value
A [FibonacciTimeExtensions](fibonaccitimeextensions-1.md) object that represents the draw object.
 
Syntax  

Draw.FibonacciTimeExtensions(NinjaScriptBase owner, string tag, bool isAutoScale, DateTime startTime, double startY, DateTime endTime, double endY)  

Draw.FibonacciTimeExtensions(NinjaScriptBase owner, string tag, bool isAutoScale, int startBarsAgo, double startY, int endBarsAgo, double endY)  

Draw.FibonacciTimeExtensions(NinjaScriptBase owner, string tag, bool isAutoScale, DateTime startTime, double startY, DateTime endTime, double endY, bool isGlobal, string templateName)  

Draw.FibonacciTimeExtensions(NinjaScriptBase owner, string tag, bool isAutoScale, int startBarsAgo, double startY, int endBarsAgo, double endY, bool isGlobal, string templateName)

## Parameters
| owner | The hosting NinjaScript object which is calling the draw method   Typically will be the object which is calling the draw method (e.g., "this") |
| --- | --- |
| tag | A user defined unique id used to reference the draw object.    For example, if you pass in a value of "myTag", each time this tag is used, the same draw object is modified. If unique tags are used each time, a new draw object will be created each time. |
| isAutoScale | Determines if the draw object will be included in the y\-axis scale. Default value is false. |
| startBarsAgo | The starting bar (x axis co\-ordinate) where the draw object will be drawn. For example, a value of 10 would paint the draw object 10 bars back. |
| startTime | The starting time where the draw object will be drawn. |
| startY | The starting y value co\-ordinate where the draw object will be drawn |
| endBarsAgo | The end bar (x axis co\-ordinate) where the draw object will terminate |
| endTime | The end time where the draw object will terminate |
| endY | The end y value co\-ordinate where the draw object will terminate |
| isGlobal | Determines if the draw object will be global across all charts which match the instrument |
| templateName | The name of the drawing tool template the object will use to determine various visual properties (empty string could be used to just use the UI default visuals instead) |
## 
## 
## Examples
| ns |
| --- |
| // Draws a fibonacci time extension object Draw.FibonacciTimeExtensions(this, "tag1", false, 10, Low\[10], 0, High\[0]); |

