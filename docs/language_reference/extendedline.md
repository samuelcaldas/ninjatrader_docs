# ExtendedLine

## Definition

Represents an interface that exposes information regarding an Extended Line [[[IDrawingTool](idrawingtool.md).

## Methods and Properties

|  |  |
| --- | --- |
| StartAnchor | An [[[IDrawingTool's ChartAnchor](idrawingtool.md#chartanchor) representing the starting point of the drawing object |
| EndAnchor | An [[[IDrawingTool's ChartAnchor](idrawingtool.md#chartanchor) representing the end point of the drawing object |
| Stroke | A [[[Stroke](stroke_class.md) object used to draw the object |

## Example

```csharp
// Instantiate a dotted lime green Extended Line
ExtendedLine myLine = Draw.ExtendedLine(this, "tag1", 10, Close[10], 0, Close[0], Brushes.LimeGreen, DashStyleHelper.Dot, 2);
// Make the line a Global Drawing Object
myLine.IsGlobalDrawingTool = true;
```
