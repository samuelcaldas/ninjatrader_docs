



DisplayOnChartsMenus

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](displayonchartsmenus.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Drawing Tool](drawing_tools.htm) >  DisplayOnChartsMenus | [Previous page](createanchor.htm) [Return to chapter overview](drawing_tools.htm) [Next page](dispose.htm) |

Definition
----------

Determines if the drawing tool displays in the chart's drawing tool menus.

Property Value
--------------

A bool value, when true the drawing tool will be created on the chart's drawing tool menu; otherwise false.  Default value is true.

Syntax
------

DisplayOnChartsMenus

Examples
--------

| ns |
| --- |
| protected override void OnStateChange()  {     if (State == State.SetDefaults)     {       Name                 = @"My Drawing Tool";       DisplayOnChartsMenus = true;     }  } |