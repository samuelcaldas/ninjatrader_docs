



DrawnBy

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](drawnby.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Drawing Tool](drawing_tools.htm) >  DrawnBy | [Previous page](drawingstate.htm) [Return to chapter overview](drawing_tools.htm) [Next page](getattachedtochartbars.htm) |

Definition
----------

Represents the NinjaScript object which created the drawing object

Property Value
--------------

The NinjaScript object which created the drawing tool; this value will be null if drawn by a user.

Syntax
------

DrawnBy

Examples
--------

| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale)  {           // if the drawing tool was not created by a user,      // print the name of the object that it was created           if(!IsUserDrawn)     Print(DrawnBy.Name);  } |