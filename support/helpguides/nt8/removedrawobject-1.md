
NinjaScript \> Language Reference \> Common \> Drawing \> RemoveDrawObject()

RemoveDrawObject()

| \<\< [Click to Display Table of Contents](removedrawobject.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [Drawing](drawing-1.md) \> RemoveDrawObject() | [Previous page](pricelevels-1.md) [Return to chapter overview](drawing-1.md) [Next page](removedrawobjects-1.md) |
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
