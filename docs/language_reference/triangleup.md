# TriangleUp

## Definition

Represents an interface that exposes information regarding a Triangle Up [IDrawingTool](idrawingtool.md).

## Methods and Properties

| Name / Option | Description |
| --- | --- |
| Anchor | An [IDrawingTool's ChartAnchor](idrawingtool.md#chartanchor) representing the point of the drawing object |
| AreaBrush | A [Brush](http://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) class representing the fill color of the draw object |
| OutlineBrush | A [Brush](http://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) class representing the outline color of the draw object |

## Examples

```csharp
// Instantiate a TriangleUp object
TriangleUp myTri = Draw.TriangleUp(this, "tag1", true, 0, Low[0] - TickSize, Brushes.Red);
// Change the object's AreaBrush
myTri.AreaBrush = Brushes.Beige;
```