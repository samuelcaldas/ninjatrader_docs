# ArrowUp

## Definition

Represents an interface that exposes information regarding an Arrow Up [IDrawingTool](idrawingtool.md).

## Methods and Properties

|  |  |
| --- | --- |
| Anchor | An [IDrawingTool's ChartAnchor](idrawingtool.md#chartanchor) representing the point of the drawing object |
| AreaBrush | A [Brush](http://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) object representing the fill color of the draw object |
| OutlineBrush | A [Brush](http://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) object representing the color of the draw object's outline |

## Example

```csharp
// Instantiate an ArrowDown object
ArrowUp myArrow = Draw.ArrowUp(this, "tag1", true, Time[0], Low[0] - (2 \* TickSize), Brushes.Green);
// Set the outline color of the Arrow
myArrow.OutlineBrush = Brushes.Black;
```
