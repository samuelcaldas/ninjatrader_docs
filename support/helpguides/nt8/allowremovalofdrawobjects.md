


NinjaScript \> Language Reference \> Common \> Drawing \> AllowRemovalOfDrawObjects






















AllowRemovalOfDrawObjects







| \<\< [Click to Display Table of Contents](allowremovalofdrawobjects.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Drawing](drawing.md) \> AllowRemovalOfDrawObjects | [Previous page](brushes.md) [Return to chapter overview](drawing.md) [Next page](backbrush.md) |
| --- | --- |











## Definition


Determines if programmatically drawn [DrawObjects](drawingtools_drawobjects.md) are allowed to remove manually from the chart


 


## Property Value


When set to true, the draw objects from the indicator or strategy can be deleted from the chart manually by a user. If false, draw objects from the indicator or strategy can only be removed from the chart if the script removes the drawing object, or the script is terminates.  Default set to false.


 


## Syntax


AllowRemovalOfDrawObjects


 


## Examples




| ns |  |
| --- | --- |
| protected override void OnStateChange() {      Add(new Plot(Brushes.Orange, "SMA"));      AllowRemovalOfDrawObjects \= true; // Draw objects can be removed separately from the script } | |









