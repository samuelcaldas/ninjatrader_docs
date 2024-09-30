
NinjaScript \> Language Reference \> Common \> Drawing \> CandleOutlineBrushes
CandleOutlineBrushes
| \<\< [Click to Display Table of Contents](candleoutlinebrushes.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Drawing](drawing.md) \> CandleOutlineBrushes | [Previous page](candleoutlinebrush.md) [Return to chapter overview](drawing.md) [Next page](drawingtools_drawobjects.md) |
| --- | --- |
## Definition
A collection of historical outline brushes for candlesticks.
 
## Property Value
A brush series type object. Accessing this property via an index value \[int barsAgo] returns a [brush](http://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) structure representing the referenced bar's outline color.
 
| Note: This will only return the color of a candlestick outline in which an explicit color overwrite was used. Otherwise it will return null. |
| --- |

## Syntax
CandleOutlineBrushes  

CandleOutlineBrushes\[int barsAgo]
 
| Warning:  You may have up to 65,535 unique CandleOutlineBrushes instances, therefore, using [static predefined brushes](working_with_brushes.md) should be favored.  Alternatively,  in order to use fewer brushes, please try to cache your custom brushes until a new brush would actually need to be created. |
| --- |

## Examples
| ns |
| --- |
| // Sets the outline color of the current bar to black. CandleOutlineBrushes\[0] \= Brushes.Black;   // Sets the outline color of the previous bar to blue. CandleOutlineBrushes\[1] \= Brushes.Blue; |

