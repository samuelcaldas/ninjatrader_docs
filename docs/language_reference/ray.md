# Ray

## Definition

Represents an interface that exposes information regarding a Ray [IDrawingTool](idrawingtool.md).

## Methods and Properties

| Name / Option | Description |
| --- | --- |
| StartAnchor | An [IDrawingTool's ChartAnchor](idrawingtool.md#chartanchor) representing the starting point of the drawing object |
| EndAnchor | An [IDrawingTool's ChartAnchor](idrawingtool.md#chartanchor) representing the end point of the drawing object |
| Stroke | A [Stroke](stroke_class.md) object used to draw the object |

## Example

![Ns](../images/ns.png)

```csharp
// Instantiate a Ray object
Ray myRay = Draw.Ray(this, "tag1", 10, 1000, 0, 1001, Brushes.LimeGreen);
// Set a new Stroke for the object
myRay.Stroke = new Stroke(Brushes.Green, DashStyleHelper.DashDot, 3);
```