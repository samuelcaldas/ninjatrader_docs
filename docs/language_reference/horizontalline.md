# HorizontalLine

## Definition

Represents an interface that exposes information regarding a Horizontal Line [[[IDrawingTool.](idrawingtool.md)

## Methods and Properties

|  |  |
| --- | --- |
| StartAnchor | An [[[IDrawingTool's ChartAnchor](idrawingtool.md#chartanchor) representing the starting point of the drawing object |
| EndAnchor | An [[[IDrawingTool's ChartAnchor](idrawingtool.md#chartanchor) representing the end point of the drawing object |
| Stroke | A [[[Stroke](stroke_class.md) object used to draw the object |

## Example

```csharp
// Instantiate a HorizontalLine object
HorizontalLine myLine = Draw.HorizontalLine(this, "tag1", 1000, Brushes.Black);
// Set a new Stroke for the object
myLine.Stroke = new Stroke(Brushes.Green, DashStyleHelper.Dash, 5);
```
