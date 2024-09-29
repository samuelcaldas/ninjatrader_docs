


NinjaScript \> Language Reference \> Common \> Drawing \> Draw.FibonacciExtensions() \> FibonacciExtensions






















FibonacciExtensions







| \<\< [Click to Display Table of Contents](fibonacciextensions.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Drawing](drawing.md) \> [Draw.FibonacciExtensions()](draw_fibonacciextensions.md) \> FibonacciExtensions | [Previous page](draw_fibonacciextensions.md) [Return to chapter overview](draw_fibonacciextensions.md) [Next page](draw_fibonacciretracements.md) |
| --- | --- |











## Definition


Represents an interface that exposes information regarding a Fibonacci Extensions [IDrawingTool](idrawingtool.md).


 


## Methods and Properties




| StartAnchor | An [IDrawingTool's ChartAnchor](idrawingtool.htm#chartanchor) representing the starting point of the drawing object |
| --- | --- |
| EndAnchor | An [IDrawingTool's ChartAnchor](idrawingtool.htm#chartanchor) representing the end point of the drawing object |
| ExtensionAnchor | An [IDrawingTool's ChartAnchor](idrawingtool.htm#chartanchor) representing the extension point of the drawing object |
| [PriceLevels](pricelevels.md) | A collection of prices calculated by the drawing object |
| TextLocation | An enum determining the text location; can be set to TextLocation.Off to remove text |
| IsExtendedLinesLeft | A bool value determining if the draw object should draw lines to the far left side of the screen |
| IsExtendedLinesRight | A bool value determining if the draw object should draw lines to the far right side of the screen |



## 


## 


## Example




| ns |
| --- |
| // Instantiates a Fibonnaci Extension FibonacciExtensions myFibExt \= Draw.FibonacciExtensions(this, "tag1", true, 4, Low\[4], 3, High\[3], 1, Low\[1]);   // Extend the Fibonacci Extension oject's lines to the right myFibExt.IsExtendedLinesRight \= true; |









