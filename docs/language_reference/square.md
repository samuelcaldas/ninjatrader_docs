# Square

## Definition

Represents an interface that exposes information regarding a Square [IDrawingTool](idrawingtool.md).

## Methods and Properties

| Name / Option | Description |
| --- | --- |
| Anchor | An [IDrawingTool's ChartAnchor](idrawingtool.md#chartanchor) representing the point of the drawing object |
| OutlineBrush | A [Brush](http://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) used for the outline of the square |
| AreaBrush | A [Brush](http://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) object representing the fill color of the draw object |

## Example

![Ns](../images/ns.png)

```csharp
// Instantiate a Square object
Square mySquare = Draw.Square(this, "tag1", true, 0, Low[0] - TickSize, Brushes.Red);
// Change the object's OutlineBrush
mySquare.OutlineBrush = Brushes.Blue;
```