
NinjaScript \> Language Reference \> Common \> Drawing \> Draw.FibonacciCircle() \> FibonacciCircle
FibonacciCircle
| \<\< [Click to Display Table of Contents](fibonaccicircle.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Drawing](drawing.md) \> [Draw.FibonacciCircle()](draw_fibonaccicircle.md) \> FibonacciCircle | [Previous page](draw_fibonaccicircle.md) [Return to chapter overview](draw_fibonaccicircle.md) [Next page](draw_fibonacciextensions.md) |
| --- | --- |
## Definition
Represents an interface that exposes information regarding a Fibonacci Circle [IDrawingTool](idrawingtool.md).
 
## Methods and Properties
| StartAnchor | An [IDrawingTool's ChartAnchor](idrawingtool.htm#chartanchor) representing the starting point of the drawing object |
| --- | --- |
| EndAnchor | An [IDrawingTool's ChartAnchor](idrawingtool.htm#chartanchor) representing the end point of the drawing object |
| [PriceLevels](pricelevels.md) | A collection of prices calculated by the drawing object |
| IsTimePriceDividedSeparately | A bool value which when true determines if the time and price are calculated together as a ratio, or independently |
| IsTextDisplayed | A bool value determining if the draw object should display text on the chart. |
## 
## 
## Example
| ns |
| --- |
| // Instantiate a Fibonacci circle FibonacciCircle myFibCirc \= Draw.FibonacciCircle(this, "tag1", true, 10, Low\[10], 0, High\[0]);   // Ensure that text is being displayed on the Drawing Object myFibCirc.IsTextDisplayed \= true; |

