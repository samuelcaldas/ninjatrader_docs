
NinjaScript > Language Reference > Common > Drawing > BackBrushes
BackBrushes
| << [Click to Display Table of Contents](backbrushes.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [Drawing](drawing-1.md) > BackBrushes | [Previous page](backbrushall-1.md) [Return to chapter overview](drawing-1.md) [Next page](backbrushesall-1.md) |
| --- | --- |
## Definition
A collection of prior back brushes used for the background colors of the chart panel.
 
## Property Value
A brush series type object. Accessing this property via an index value [int barsAgo] returns a [Brush](http://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) object representing the color of the background color on the referenced bar.
## 
## Syntax
## BackBrushes
## BackBrushes[int barsAgo]
## 
| Warning:  You may have up to 65,535 unique BackBrushes instances, therefore, using [static predefined brushes](working_with_brushes-1.md) should be favored.  Alternatively,  in order to use fewer brushes, please try to cache your custom brushes until a new brush would actually need to be created. |
| --- |

## 
## 
## Examples
| ns |
| --- |
| protected override void OnBarUpdate() {      if (CurrentBar < 1)          return;        // Sets the color of the background on the current bar as blue      BackBrushes[0] = Brushes.Blue;        // Sets the color of the background on the previous bar as orange      BackBrushes[1] = Brushes.Orange; } |
