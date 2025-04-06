



ArrowDown

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\arrowdown.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [Drawing](drawing-1.htm) > [Draw.ArrowDown()](draw_arrowdown-1.htm) >  ArrowDown | [Previous page](draw_arrowdown-1.htm) [Return to chapter overview](draw_arrowdown-1.htm) [Next page](draw_arrowline-1.htm) |

Definition
----------

Represents an interface that exposes information regarding an Arrow Down [IDrawingTool](idrawingtool-1.htm).

Methods and Properties
----------------------

|  |  |
| --- | --- |
| Anchor | An [IDrawingTool's ChartAnchor](idrawingtool-1.htm#chartanchor) representing the point of the drawing object |
| AreaBrush | A [Brush](http://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) object representing the fill color of the draw object |
| OutlineBrush | A [Brush](http://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) object representing the color of the draw object's outline |

Example
-------

| ns |
| --- |
| // Instantiate an ArrowDown object  ArrowDown myArrow = Draw.ArrowDown(this, "tag1", true, Time[0], High[0] + (2 \* TickSize), Brushes.Green);     // Set the outline color of the Arrow  myArrow.OutlineBrush = Brushes.Black; |