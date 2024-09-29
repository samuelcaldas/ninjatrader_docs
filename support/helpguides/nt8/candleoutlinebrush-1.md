


NinjaScript \> Language Reference \> Common \> Drawing \> CandleOutlineBrush






















CandleOutlineBrush







| \<\< [Click to Display Table of Contents](candleoutlinebrush.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [Drawing](drawing-1.md) \> CandleOutlineBrush | [Previous page](barbrushes-1.md) [Return to chapter overview](drawing-1.md) [Next page](candleoutlinebrushes-1.md) |
| --- | --- |











## Definition


Sets the outline Brush of a candlestick. 


## 


## Property Value


A [brush](http://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) object that represents the color of this price bar.


 


## Syntax


CandleOutlineBrush


 




| Warning:  You may have up to 65,535 unique CandleOutlineBrushes instances, therefore, using [static predefined brushes](working_with_brushes-1.md) should be favored.  Alternatively,  in order to use fewer brushes, please try to cache your custom brushes until a new brush would actually need to be created. |
| --- |



## 


## 


## Examples




| ns |
| --- |
| // Sets the candle outline color to black CandleOutlineBrush \= Brushes.Black; |









