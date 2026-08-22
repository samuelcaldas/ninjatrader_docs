# Diamond

## Definition

Represents an interface that exposes information regarding a Diamond [IDrawingTool](idrawingtool.md).

## Methods and Properties

| Name / Option | Description |
| --- | --- |
| Anchor | An [IDrawingTool's ChartAnchor](idrawingtool.md#chartanchor) representing the point of the drawing object |
| AreaBrush | A [Brush](http://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) object representing the fill color of the draw object |
| OutlineBrush | A [Brush](http://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) object representing the color of the draw object's outline |

## Example

```csharp
// Instantiates a red diamond on the current bar 1 tick below the low
Diamond myDiamond = Draw.Diamond(this, "tag1", true, 0, Low[0] - TickSize, Brushes.Red);
// Set the area fill color to Red
myDiamond.AreaBrush = Brushes.Red;
```
