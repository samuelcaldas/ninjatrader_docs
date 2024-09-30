
NinjaScript \> Language Reference \> Common \> Drawing \> Draw.Diamond() \> Diamond

Diamond
| \<\< [Click to Display Table of Contents](diamond.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Drawing](drawing.md) \> [Draw.Diamond()](draw_diamond.md) \> Diamond | [Previous page](draw_diamond.md) [Return to chapter overview](draw_diamond.md) [Next page](draw_dot.md) |
| --- | --- |
## Definition
Represents an interface that exposes information regarding a Diamond [IDrawingTool](idrawingtool.md).
 
## Methods and Properties
| Anchor | An [IDrawingTool's ChartAnchor](idrawingtool.htm#chartanchor) representing the point of the drawing object |
| --- | --- |
| AreaBrush | A [Brush](http://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) object representing the fill color of the draw object |
| OutlineBrush | A [Brush](http://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) object representing the color of the draw object's outline |

## 
## 
## Example
| ns |
| --- |
| // Instantiates a red diamond on the current bar 1 tick below the low Diamond myDiamond \= Draw.Diamond(this, "tag1", true, 0, Low\[0] \- TickSize, Brushes.Red);   // Set the area fill color to Red myDiamond.AreaBrush \= Brushes.Red; |
