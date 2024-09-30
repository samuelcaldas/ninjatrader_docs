
NinjaScript > Language Reference > Common > Drawing > Draw.FibonacciRetracements() > FibonacciRetracements
FibonacciRetracements
| << [Click to Display Table of Contents](fibonacciretracements.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > [Drawing](drawing.md) > [Draw.FibonacciRetracements()](draw_fibonacciretracements.md) > FibonacciRetracements | [Previous page](draw_fibonacciretracements.md) [Return to chapter overview](draw_fibonacciretracements.md) [Next page](draw_fibonaccitimeextensions.md) |
| --- | --- |
## Definition
Represents an interface that exposes information regarding a Fibonacci Retracements [IDrawingTool](idrawingtool.md).
 
## Methods and Properties
| StartAnchor | An [IDrawingTool's ChartAnchor](idrawingtool.htm#chartanchor) representing the starting point of the drawing object |
| --- | --- |
| EndAnchor | An [IDrawingTool's ChartAnchor](idrawingtool.htm#chartanchor) representing the end point of the drawing object |
| [PriceLevels](pricelevels.md) | A collection of prices calculated by the drawing object |
| TextLocation | An enum determining the text location; can be set to TextLocation.Off to remove text |
| IsExtendedLinesLeft | A bool value determining if the draw object should draw lines to the far left side of the screen |
| IsExtendedLinesRight | A bool value determining if the draw object should draw lines to the far right side of the screen |
## 
## 
## Example
| ns |
| --- |
| // Instantiate a FibonacciRetracements object FibonacciRetracements myFibRet = Draw.FibonacciRetracements(this, "tag1", true, 10, Low[10], 0, High[0]);   // Set the object's lines to extend to the right myFibRet.IsExtendedLinesRight = true; |

