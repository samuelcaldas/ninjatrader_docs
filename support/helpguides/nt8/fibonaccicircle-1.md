
NinjaScript > Language Reference > Common > Drawing > Draw.FibonacciCircle() > FibonacciCircle
FibonacciCircle
| << [Click to Display Table of Contents](fibonaccicircle.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [Drawing](drawing-1.md) > [Draw.FibonacciCircle()](draw_fibonaccicircle-1.md) > FibonacciCircle | [Previous page](draw_fibonaccicircle-1.md) [Return to chapter overview](draw_fibonaccicircle-1.md) [Next page](draw_fibonacciextensions-1.md) |
| --- | --- |
## Definition
Represents an interface that exposes information regarding a Fibonacci Circle [IDrawingTool](idrawingtool-1.md).
 
## Methods and Properties
| StartAnchor | An [IDrawingTool's ChartAnchor](idrawingtool-1.htm#chartanchor) representing the starting point of the drawing object |
| --- | --- |
| EndAnchor | An [IDrawingTool's ChartAnchor](idrawingtool-1.htm#chartanchor) representing the end point of the drawing object |
| [PriceLevels](pricelevels-1.md) | A collection of prices calculated by the drawing object |
| IsTimePriceDividedSeparately | A bool value which when true determines if the time and price are calculated together as a ratio, or independently |
| IsTextDisplayed | A bool value determining if the draw object should display text on the chart. |
## 
## 
## Example
| ns |
| --- |
| // Instantiate a Fibonacci circle FibonacciCircle myFibCirc = Draw.FibonacciCircle(this, "tag1", true, 10, Low[10], 0, High[0]);   // Ensure that text is being displayed on the Drawing Object myFibCirc.IsTextDisplayed = true; |

