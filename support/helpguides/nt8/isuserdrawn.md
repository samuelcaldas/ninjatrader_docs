


NinjaScript \> Language Reference \> Drawing Tool \> IsUserDrawn






















IsUserDrawn







| \<\< [Click to Display Table of Contents](isuserdrawn.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Drawing Tool](drawing_tools.md) \> IsUserDrawn | [Previous page](islocked.md) [Return to chapter overview](drawing_tools.md) [Next page](onbarschanged.md) |
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









