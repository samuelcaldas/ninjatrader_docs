



IsVisible

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\isvisible.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) >  IsVisible | [Previous page](indicator_displayname-1.htm) [Return to chapter overview](common-1.htm) [Next page](name-1.htm) |

Definition
----------

Determines if the current NinjaScript object should be visible on the chart. When an object's IsVisible property is set to false, the object will NOT be displayed on the chart and will not be calculated to save resources.

|  |
| --- |
| Note: Strategies intentionally contain no IsVisible property. |

|  |
| --- |
| Warning: This property should NOT be set on indicators which add a panel or own their own panel. Panel addition/removal is determined when an indicator is added/removed to a chart and is not modified through the IsVisible property. |

Property Value
--------------

A bool value when true will be displayed on the chart; otherwise false; default value is true.

Syntax
------

IsVisible

Examples
--------

| ns |
| --- |
| protected override void OnBarUpdate()  {     // Loops through the DrawObjects collection via a threadsafe list copy     foreach (DrawingTool draw in DrawObjects.ToList())     {       // Detect all manual drawn line objects and change their visibility       if (draw is DrawingTools.Line && draw.IsUserDrawn)       {           draw.IsVisible = false;       }     }               } |