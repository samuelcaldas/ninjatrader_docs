# ArrowLine

## Definition

Represents an interface that exposes information regarding an Arrow Line [IDrawingTool](idrawingtool.md).

## Methods and Properties

| Name / Option | Description |
| --- | --- |
| StartAnchor | An [IDrawingTool's ChartAnchor](idrawingtool.md#chartanchor) representing the starting point of the drawing object |
| EndAnchor | An [IDrawingTool's ChartAnchor](idrawingtool.md#chartanchor) representing the end point of the drawing object |
| Stroke | A [Stroke](stroke_class.md) object used to draw the object |

## Example

![Ns](../images/ns.png)

```csharp
// Draw an ArrowLine object
ArrowLine myArrow = Draw.ArrowLine(this, "myArrowLine", 3, High[3], 1, High[1], Brushes.Blue, DashStyleHelper.DashDot, 3);
// Disable the arrow's visibility
myArrow.IsVisible = false;
```