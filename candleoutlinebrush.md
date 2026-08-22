# CandleOutlineBrush

## Definition

Sets the outline Brush of a candlestick.

## Property Value

A [brush](http://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) object that represents the color of this price bar.

## Syntax

CandleOutlineBrush

 

> **Warning:** You may have up to 65,535 unique CandleOutlineBrushes instances, therefore, using [static predefined brushes](working_with_brushes.md) should be favored.  Alternatively,  in order to use fewer brushes, please try to cache your custom brushes until a new brush would actually need to be created.

## Examples

```csharp
// Sets the candle outline color to black
CandleOutlineBrush = Brushes.Black;
```
