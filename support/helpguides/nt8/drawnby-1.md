


NinjaScript \> Language Reference \> Drawing Tool \> DrawnBy






















DrawnBy







| \<\< [Click to Display Table of Contents](drawnby.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Drawing Tool](drawing_tools-1.md) \> DrawnBy | [Previous page](drawingstate-1.md) [Return to chapter overview](drawing_tools-1.md) [Next page](getattachedtochartbars-1.md) |
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









