
NinjaScript \> Language Reference \> Common \> Drawing \> AllowRemovalOfDrawObjects

AllowRemovalOfDrawObjects

| \<\< [Click to Display Table of Contents](allowremovalofdrawobjects.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [Drawing](drawing-1.md) \> AllowRemovalOfDrawObjects | [Previous page](brushes-1.md) [Return to chapter overview](drawing-1.md) [Next page](backbrush-1.md) |
| --- | --- |
## Definition
Determines if programmatically drawn [DrawObjects](drawingtools_drawobjects-1.md) are allowed to remove manually from the chart
 
## Property Value
When set to true, the draw objects from the indicator or strategy can be deleted from the chart manually by a user. If false, draw objects from the indicator or strategy can only be removed from the chart if the script removes the drawing object, or the script is terminates.  Default set to false.
 
## Syntax
AllowRemovalOfDrawObjects
 
## Examples

| ns |  |
| --- | --- |
| protected override void OnStateChange() {      Add(new Plot(Brushes.Orange, "SMA"));      AllowRemovalOfDrawObjects \= true; // Draw objects can be removed separately from the script } | |
