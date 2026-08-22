# VerticalLine

## Definition

Represents an interface that exposes information regarding a Vertical Line [IDrawingTool](idrawingtool.md).

## Methods and Properties

| Name / Option | Description |
| --- | --- |
| StartAnchor | An [IDrawingTool's ChartAnchor](idrawingtool.md#chartanchor) representing the starting point of the drawing object |
| EndAnchor | An [IDrawingTool's ChartAnchor](idrawingtool.md#chartanchor) representing the end point of the drawing object |
| Stroke | A [Stroke](stroke_class.md) object used to draw the object |

## Examples

![Ns](../images/ns.png)

```csharp
// Instantiate a VerticalLine object
VerticalLine myLine = Draw.VerticalLine(this, "tag1", 10, Brushes.Black);
// Change the object's Stroke
myLine.Stroke = new Stroke(Brushes.BlanchedAlmond, DashStyleHelper.Dot, 5);
```