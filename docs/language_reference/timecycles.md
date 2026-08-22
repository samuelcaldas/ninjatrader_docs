# TimeCycles

## Definition

Represents an interface that exposes information regarding a TimeCyles [IDrawingTool](idrawingtool.md).

## Methods and Properties

| Name / Option | Description |
| --- | --- |
| Anchor | An [IDrawingTool's ChartAnchor](idrawingtool.md#chartanchor) representing the point of the drawing object |
| OutlineStroke | A Stroke used for the outline of the region |
| AreaBrush | A [Brush](http://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) object representing the fill color of the draw object |

## Example

```csharp
// Instantiate a Time Cycles object
TimeCycles myTimeCycles = (this, "tag1", 0, 10, Brushes.CornflowerBlue, Brushes.CornflowerBlue, 40);
// Change the object's OutlineBrush
myTimeCycles.OutlineStroke = newÂ Stroke(Brushes.Red);
```