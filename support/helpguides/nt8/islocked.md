
NinjaScript \> Language Reference \> Drawing Tool \> IsLocked

IsLocked

| \<\< [Click to Display Table of Contents](islocked.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Drawing Tool](drawing_tools.md) \> IsLocked | [Previous page](isglobaldrawingtool.md) [Return to chapter overview](drawing_tools.md) [Next page](isuserdrawn.md) |
| --- | --- |
Definition  

Determines if the drawing tool should be be locked in place.  This property can be set either manually through the UI or explicitly through code.
 
## Property Value
A bool value which when true if the drawing tool is locked; otherwise false.  Default is set to false.
 

| Note: For Drawing tools which are drawn by an indicator or strategy, this property will default to true. |
| --- |

## Syntax
IsLocked
## 
## Examples

| ns |
| --- |
| public override void OnMouseMove(ChartControl chartControl, ChartPanel chartPanel, ChartScale chartScale, Point point) {    if (IsLocked) //if the object is locked, do not attempt to move      return; } |
