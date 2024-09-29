


NinjaScript \> Language Reference \> Common \> IsVisible






















IsVisible







| \<\< [Click to Display Table of Contents](isvisible.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> IsVisible | [Previous page](indicator_displayname.md) [Return to chapter overview](common.md) [Next page](name.md) |
| --- | --- |











## Definition


Determines if the current NinjaScript object should be visible on the chart. When an object's IsVisible property is set to false, the object will NOT be displayed on the chart and will not be calculated to save resources.


 




| Note: Strategies intentionally contain no IsVisible property. |
| --- |



## 




| Warning: This property should NOT be set on indicators which add a panel or own their own panel. Panel addition/removal is determined when an indicator is added/removed to a chart and is not modified through the IsVisible property. |
| --- |



## 


## Property Value


A bool value when true will be displayed on the chart; otherwise false; default value is true.


 


## Syntax


IsVisible


 


## Examples




| ns |
| --- |
| protected override void OnBarUpdate() {    // Loops through the DrawObjects collection via a threadsafe list copy    foreach (DrawingTool draw in DrawObjects.ToList())    {      // Detect all manual drawn line objects and change their visibility      if (draw is DrawingTools.Line \&\& draw.IsUserDrawn)      {          draw.IsVisible \= false;      }    }              } |









