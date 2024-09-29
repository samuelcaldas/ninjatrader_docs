


NinjaScript \> Language Reference \> Drawing Tool \> DisplayOnChartsMenus






















DisplayOnChartsMenus







| \<\< [Click to Display Table of Contents](displayonchartsmenus.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Drawing Tool](drawing_tools-1.md) \> DisplayOnChartsMenus | [Previous page](createanchor-1.md) [Return to chapter overview](drawing_tools-1.md) [Next page](dispose-1.md) |
| --- | --- |











## Definition


Determines if the drawing tool displays in the chart's drawing tool menus.


 


## Property Value


A bool value, when true the drawing tool will be created on the chart's drawing tool menu; otherwise false.  Default value is true.


 


## Syntax


DisplayOnChartsMenus


 


## Examples




| ns |
| --- |
| protected override void OnStateChange() {    if (State \=\= State.SetDefaults)    {      Name                 \= @"My Drawing Tool";      DisplayOnChartsMenus \= true;    } } |









