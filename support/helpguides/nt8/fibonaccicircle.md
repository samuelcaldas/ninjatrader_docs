



FibonacciCircle

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](fibonaccicircle.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Common](common.htm) > [Drawing](drawing.htm) > [Draw.FibonacciCircle()](draw_fibonaccicircle.htm) >  FibonacciCircle | [Previous page](draw_fibonaccicircle.htm) [Return to chapter overview](draw_fibonaccicircle.htm) [Next page](draw_fibonacciextensions.htm) |

Definition
----------

Represents an interface that exposes information regarding a Fibonacci Circle [IDrawingTool](idrawingtool.htm).

Methods and Properties
----------------------

|  |  |
| --- | --- |
| StartAnchor | An [IDrawingTool's ChartAnchor](idrawingtool.htm#chartanchor) representing the starting point of the drawing object |
| EndAnchor | An [IDrawingTool's ChartAnchor](idrawingtool.htm#chartanchor) representing the end point of the drawing object |
| [PriceLevels](pricelevels.htm) | A collection of prices calculated by the drawing object |
| IsTimePriceDividedSeparately | A bool value which when true determines if the time and price are calculated together as a ratio, or independently |
| IsTextDisplayed | A bool value determining if the draw object should display text on the chart. |

Example
-------

| ns |
| --- |
| // Instantiate a Fibonacci circle  FibonacciCircle myFibCirc = Draw.FibonacciCircle(this, "tag1", true, 10, Low[10], 0, High[0]);     // Ensure that text is being displayed on the Drawing Object  myFibCirc.IsTextDisplayed = true; |