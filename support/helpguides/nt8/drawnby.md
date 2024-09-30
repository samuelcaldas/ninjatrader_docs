
NinjaScript \> Language Reference \> Drawing Tool \> DrawnBy

DrawnBy
| \<\< [Click to Display Table of Contents](drawnby.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Drawing Tool](drawing_tools.md) \> DrawnBy | [Previous page](drawingstate.md) [Return to chapter overview](drawing_tools.md) [Next page](getattachedtochartbars.md) |
| --- | --- |
## Definition
Represents the NinjaScript object which created the drawing object
 
## Property Value
The NinjaScript object which created the drawing tool; this value will be null if drawn by a user.
 
## Syntax
DrawnBy
 
## Examples
| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale) {          // if the drawing tool was not created by a user,     // print the name of the object that it was created          if(!IsUserDrawn)    Print(DrawnBy.Name); } |
