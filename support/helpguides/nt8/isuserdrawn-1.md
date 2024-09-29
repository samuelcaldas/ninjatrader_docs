


NinjaScript \> Language Reference \> Drawing Tool \> IsUserDrawn






















IsUserDrawn







| \<\< [Click to Display Table of Contents](isuserdrawn.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Drawing Tool](drawing_tools-1.md) \> IsUserDrawn | [Previous page](islocked-1.md) [Return to chapter overview](drawing_tools-1.md) [Next page](onbarschanged-1.md) |
| --- | --- |











Definition  

Indicates if the drawing tool was manually drawn by a user as opposed to programmatically drawn by a NinjaScript object (such as an indicator or strategy).


 


## Property Value


A bool value which when true if the draw object was manually drawn ; otherwise false. This property is read\-only


 


## Syntax


IsUserDrawn


## 


## Examples




| ns |
| --- |
| if (IsUserDrawn) {   // do something only if the object was drawn manually } |









