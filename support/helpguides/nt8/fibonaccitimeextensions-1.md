
NinjaScript > Language Reference > Common > Drawing > Draw.FibonacciTimeExtensions() > FibonacciTimeExtensions
FibonacciTimeExtensions
| << [Click to Display Table of Contents](fibonaccitimeextensions.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [Drawing](drawing-1.md) > [Draw.FibonacciTimeExtensions()](draw_fibonaccitimeextensions-1.md) > FibonacciTimeExtensions | [Previous page](draw_fibonaccitimeextensions-1.md) [Return to chapter overview](draw_fibonaccitimeextensions-1.md) [Next page](draw_gannfan-1.md) |
| --- | --- |
## Definition
Represents an interface that exposes information regarding a Fibonacci Time Extensions [IDrawingTool](idrawingtool-1.md).
 
## Methods and Properties
| StartAnchor | An [IDrawingTool's ChartAnchor](idrawingtool-1.htm#chartanchor) representing the starting point of the drawing object |
| --- | --- |
| EndAnchor | An [IDrawingTool's ChartAnchor](idrawingtool-1.htm#chartanchor) representing the end point of the drawing object |
| [PriceLevels](pricelevels-1.md) | A collection of prices calculated by the drawing object |
| IsTextDisplayed | A bool value determining if the draw object should display text on the chart. |
| IsExtendedLinesLeft | A bool value determining if the draw object should draw lines to the far left side of the screen |
| IsExtendedLinesRight | A bool value determining if the draw object should draw lines to the far right side of the screen |
## 
## 
## Example
| ns |
| --- |
| // Instantiate a FibonacciTimeExtensions object FibonacciTimeExtensions myFibTime = Draw.FibonacciTimeExtensions(this, "tag1", false, 10, Low[10], 0, High[0]);   // Instantiate a new PriceLevel to be used in the step below PriceLevel myLevel = new PriceLevel(99, Brushes.Black);   // Change the object's price level at index 3 myFibTime.PriceLevels[3] = myLevel; |

