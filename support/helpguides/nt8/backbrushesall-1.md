



BackBrushesAll

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\backbrushesall.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [Drawing](drawing-1.htm) >  BackBrushesAll | [Previous page](backbrushes-1.htm) [Return to chapter overview](drawing-1.htm) [Next page](barbrush-1.htm) |

Definition
----------

A collection of historical brushes used for the background colors for all chart panels.

Property Value
--------------

A brush series type object. Accessing this property via an index value [int barsAgo] returns a [Brush](http://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) object representing the color of the background color on the referenced bar for all chart panels.

Syntax
------

BackBrushesAll  
BackBrushesAll[int barsAgo]

 

|  |
| --- |
| Warning:  You may have up to 65,535 unique BackBrushAll instances, therefore, using [static predefined brushes](working_with_brushes-1.htm) should be favored.  Alternatively,  in order to use fewer brushes, please try to cache your custom brushes until a new brush would actually need to be created. |

Examples
--------

| ns |
| --- |
| protected override void OnBarUpdate()  {       if (CurrentBar < 1)           return;          // Sets the color of the background on the current bar as blue on all chart panels.       BackBrushesAll[0] = Brushes.Blue;          // Sets the color of the background on the previous bar as orange on all chart panels.       BackBrushesAll[1] = Brushes.Orange;  } |