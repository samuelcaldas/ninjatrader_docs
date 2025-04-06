



Diamond

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\diamond.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [Drawing](drawing-1.htm) > [Draw.Diamond()](draw_diamond-1.htm) >  Diamond | [Previous page](draw_diamond-1.htm) [Return to chapter overview](draw_diamond-1.htm) [Next page](draw_dot-1.htm) |

Definition
----------

Represents an interface that exposes information regarding a Diamond [IDrawingTool](idrawingtool-1.htm).

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
| // Instantiates a red diamond on the current bar 1 tick below the low  Diamond myDiamond = Draw.Diamond(this, "tag1", true, 0, Low[0] - TickSize, Brushes.Red);     // Set the area fill color to Red  myDiamond.AreaBrush = Brushes.Red; |