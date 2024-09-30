
NinjaScript > Language Reference > Common > Drawing > BarBrush
BarBrush
| << [Click to Display Table of Contents](barbrush.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > [Drawing](drawing.md) > BarBrush | [Previous page](backbrushesall.md) [Return to chapter overview](drawing.md) [Next page](barbrushes.md) |
| --- | --- |
## Definition
Sets the brush used for painting the color of a price bar's body.
## 
## Property Value
A [Brush](http://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) object that represents the color of this price bar.
 
| Tip: To set the price bar color to an empty color which uses the default bar color property, set the BarBrush to null for that bar. |
| --- |
 
## Syntax
BarBrush
 
| Warning:  You may have up to 65,535 unique BarBrush instances, therefore, using [static predefined brushes](working_with_brushes.md) should be favored.  Alternatively,  in order to use fewer brushes, please try to cache your custom brushes until a new brush would actually need to be created. |
| --- |
## 
## 
## Examples
| ns |
| --- |
| protected override void OnBarUpdate() {      // Sets the bar color to yellow      BarBrush = Brushes.Yellow;        // Sets the brush used for the bar color to its default color as defined in the chart properties dialog      BarBrush = null;        // Sets the bar color to yellow if the 20 SMA is above the 50 SMA and the closing      // price is above the 20 SMA (see image below)      if (SMA(20)[0] > SMA(50)[0] && Close[0] > SMA(20)[0])          BarBrush = Brushes.Yellow; } |

