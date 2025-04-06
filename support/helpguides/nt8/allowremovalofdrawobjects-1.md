



AllowRemovalOfDrawObjects

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\allowremovalofdrawobjects.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [Drawing](drawing-1.htm) >  AllowRemovalOfDrawObjects | [Previous page](brushes-1.htm) [Return to chapter overview](drawing-1.htm) [Next page](backbrush-1.htm) |

Definition
----------

Determines if programmatically drawn [DrawObjects](drawingtools_drawobjects-1.htm) are allowed to remove manually from the chart

 

Property Value
--------------

When set to true, the draw objects from the indicator or strategy can be deleted from the chart manually by a user. If false, draw objects from the indicator or strategy can only be removed from the chart if the script removes the drawing object, or the script is terminates.  Default set to false.

Syntax
------

AllowRemovalOfDrawObjects

Examples
--------

|  |  |
| --- | --- |
| ns |  |
| protected override void OnStateChange()  {       Add(new Plot(Brushes.Orange, "SMA"));       AllowRemovalOfDrawObjects = true; // Draw objects can be removed separately from the script  } | |