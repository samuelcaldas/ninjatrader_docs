


NinjaScript \> Language Reference \> Drawing Tool \> IgnoresSnapping






















IgnoresSnapping







| \<\< [Click to Display Table of Contents](ignoressnapping.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Drawing Tool](drawing_tools-1.md) \> IgnoresSnapping | [Previous page](icon_drawingtool-1.md) [Return to chapter overview](drawing_tools-1.md) [Next page](ignoresuserinput-1.md) |
| --- | --- |











Definition  

Determines if the drawing tool chart anchor's will use the chart's Snap Mode mouse coordinates.


 


## Property Value


A bool value which when true the drawing tool ignores snapping; otherwise false.  Default is set to false.


 


## Syntax


IgnoresSnapping


## 


## Examples




| ns |
| --- |
| protected override void OnStateChange() {      if (State \=\= State.SetDefaults)      {           IgnoresSnapping \= true; // Set this to true to receive non\-snapped mouse coordinates      }      else if (State \=\= State.Configure)      {        } } |









