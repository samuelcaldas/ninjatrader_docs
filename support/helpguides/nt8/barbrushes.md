


NinjaScript \> Language Reference \> Common \> Drawing \> BarBrushes






















BarBrushes







| \<\< [Click to Display Table of Contents](barbrushes.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Drawing](drawing.md) \> BarBrushes | [Previous page](barbrush.md) [Return to chapter overview](drawing.md) [Next page](candleoutlinebrush.md) |
| --- | --- |











## Definition


A collection of historical brushes used for painting the color of a price bar's body.


 


## Property Value


A brush series type object. Accessing this property via an index value \[int barsAgo] returns a [Brush](http://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) object representing the referenced bar's color.


 




| Note: This will only return the color of a bar in which an explicit color overwrite was used. Otherwise it will return null. |
| --- |



 


## Syntax


BarBrushes  

BarBrushes\[int barsAgo]


 




| Warning:  You may have up to 65,535 unique BarBrushes instances, therefore, using [static predefined brushes](working_with_brushes.md) should be favored.  Alternatively,  in order to use fewer brushes, please try to cache your custom brushes until a new brush would actually need to be created. |
| --- |



## 


## 


## Examples




| ns |
| --- |
| protected override void OnBarUpdate() {      if (CurrentBar \< 1)          return;        // Sets the color of the current bar to blue.      BarBrushes\[0] \= Brushes.Blue;        // Sets the color of the previous bar to orange.      BarBrushes\[1] \= Brushes.Orange;   } |









