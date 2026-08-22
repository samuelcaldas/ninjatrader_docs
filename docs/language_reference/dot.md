# Dot

## Definition

Represents an interface that exposes information regarding a Dot [IDrawingTool](idrawingtool.md).

## Methods and Properties

| Name / Option | Description |
| --- | --- |
| Anchor | An [IDrawingTool's ChartAnchor](idrawingtool.md#chartanchor) representing the point of the drawing object |
| AreaBrush | A [Brush](http://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) object representing the fill color of the draw object |
| OutlineBrush | A [Brush](http://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) object representing the color of the draw object's outline |

## Example

![Ns](../images/ns.png)

```csharp
// Instantiates a red dot on the current bar 1 tick below the low
Dot myDot = Draw.Dot(this, "tag1", true, 0, Low[0] - TickSize, Brushes.Red);
// Disable the dot's Auto Scale property
myDot.IsAutoScale = false;
```