


NinjaScript \> Language Reference \> Common \> Drawing \> Draw.FibonacciRetracements() \> FibonacciRetracements






















FibonacciRetracements







| \<\< [Click to Display Table of Contents](fibonacciretracements.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [Drawing](drawing-1.md) \> [Draw.FibonacciRetracements()](draw_fibonacciretracements-1.md) \> FibonacciRetracements | [Previous page](draw_fibonacciretracements-1.md) [Return to chapter overview](draw_fibonacciretracements-1.md) [Next page](draw_fibonaccitimeextensions-1.md) |
| --- | --- |











## Definition


Represents an interface that exposes information regarding a Fibonacci Retracements [IDrawingTool](idrawingtool-1.md).


 


## Methods and Properties




| StartAnchor | An [IDrawingTool's ChartAnchor](idrawingtool-1.htm#chartanchor) representing the starting point of the drawing object |
| --- | --- |
| EndAnchor | An [IDrawingTool's ChartAnchor](idrawingtool-1.htm#chartanchor) representing the end point of the drawing object |
| [PriceLevels](pricelevels-1.md) | A collection of prices calculated by the drawing object |
| TextLocation | An enum determining the text location; can be set to TextLocation.Off to remove text |
| IsExtendedLinesLeft | A bool value determining if the draw object should draw lines to the far left side of the screen |
| IsExtendedLinesRight | A bool value determining if the draw object should draw lines to the far right side of the screen |



## 


## 


## Example




| ns |
| --- |
| // Instantiate a FibonacciRetracements object FibonacciRetracements myFibRet \= Draw.FibonacciRetracements(this, "tag1", true, 10, Low\[10], 0, High\[0]);   // Set the object's lines to extend to the right myFibRet.IsExtendedLinesRight \= true; |









