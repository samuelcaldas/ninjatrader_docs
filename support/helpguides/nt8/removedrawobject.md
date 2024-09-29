


NinjaScript \> Language Reference \> Common \> Drawing \> RemoveDrawObject()






















RemoveDrawObject()







| \<\< [Click to Display Table of Contents](removedrawobject.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Drawing](drawing.md) \> RemoveDrawObject() | [Previous page](pricelevels.md) [Return to chapter overview](drawing.md) [Next page](removedrawobjects.md) |
| --- | --- |











## Definition


Removes a draw object from the chart based on its tag value.


 




| Note:  This method will ONLY remove DrawObjects which were created by a NinjaScript object.  User drawn objects CANNOT be removed from via NinjaScript |
| --- |



## 


## 


## Method Return Value


## This method does not return a value


 


## Syntax


## RemoveDrawObject(string tag)


## 


## Parameters




| tag | A user defined unique id used to reference the draw object. For example, if you pass in a value of "myTag", each time this tag is used, the same draw object is modified. If unique tags are used each time, a new draw object will be created each time. |
| --- | --- |



 


## 


## Examples




| ns |
| --- |
| // Removes a draw object with the tag "tag1" RemoveDrawObject("tag1"); |









