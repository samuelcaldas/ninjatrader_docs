



Dispose()

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\dispose.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Drawing Tool](drawing_tools-1.htm) >  Dispose() | [Previous page](displayonchartsmenus-1.htm) [Return to chapter overview](drawing_tools-1.htm) [Next page](drawingstate-1.htm) |

Definition
----------

Releases any device resources used for the drawing tool.

Method Return Value
-------------------

This method does not return a value

Syntax
------

Dispose()

Method Parameters
-----------------

This method does not accept any parameters

Examples
--------

| ns |
| --- |
| protected override void OnStateChange()  {     if (State == State.SetDefaults)     {       Name                 = @"My Drawing Tool";           }        else if (State == State.Terminated)       Dispose();  } |