



CandleOutlineBrush

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\candleoutlinebrush.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [Drawing](drawing-1.htm) >  CandleOutlineBrush | [Previous page](barbrushes-1.htm) [Return to chapter overview](drawing-1.htm) [Next page](candleoutlinebrushes-1.htm) |

Definition
----------

Sets the outline Brush of a candlestick.

Property Value
--------------

A [brush](http://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) object that represents the color of this price bar.

Syntax
------

CandleOutlineBrush

 

|  |
| --- |
| Warning:  You may have up to 65,535 unique CandleOutlineBrushes instances, therefore, using [static predefined brushes](working_with_brushes-1.htm) should be favored.  Alternatively,  in order to use fewer brushes, please try to cache your custom brushes until a new brush would actually need to be created. |

Examples
--------

| ns |
| --- |
| // Sets the candle outline color to black  CandleOutlineBrush = Brushes.Black; |