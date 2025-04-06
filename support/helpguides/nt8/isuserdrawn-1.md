



IsUserDrawn

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\isuserdrawn.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Drawing Tool](drawing_tools-1.htm) >  IsUserDrawn | [Previous page](islocked-1.htm) [Return to chapter overview](drawing_tools-1.htm) [Next page](onbarschanged-1.htm) |

Definition  
Indicates if the drawing tool was manually drawn by a user as opposed to programmatically drawn by a NinjaScript object (such as an indicator or strategy).

Property Value
--------------

A bool value which when true if the draw object was manually drawn ; otherwise false. This property is read-only

Syntax
------

IsUserDrawn

Examples
--------

| ns |
| --- |
| if (IsUserDrawn)  {  // do something only if the object was drawn manually  } |