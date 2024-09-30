
NinjaScript > Language Reference > Common > Drawing > CandleOutlineBrush

CandleOutlineBrush

| << [Click to Display Table of Contents](candleoutlinebrush.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > [Drawing](drawing.md) > CandleOutlineBrush | [Previous page](barbrushes.md) [Return to chapter overview](drawing.md) [Next page](candleoutlinebrushes.md) |
| --- | --- |
## Definition
Sets the outline Brush of a candlestick. 
## 
## Property Value
A [brush](http://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) object that represents the color of this price bar.
 
## Syntax
CandleOutlineBrush
 

| Warning:  You may have up to 65,535 unique CandleOutlineBrushes instances, therefore, using [static predefined brushes](working_with_brushes.md) should be favored.  Alternatively,  in order to use fewer brushes, please try to cache your custom brushes until a new brush would actually need to be created. |
| --- |
## 
## 
## Examples

| ns |
| --- |
| // Sets the candle outline color to black CandleOutlineBrush = Brushes.Black; |
