# Ruler

## Definition

Represents an interface that exposes information regarding a Ruler [IDrawingTool](idrawingtool.md).

## Methods and Properties

| Name / Option | Description |
| --- | --- |
| StartAnchor | An [IDrawingTool's ChartAnchor](idrawingtool.md#chartanchor) representing the starting point of the drawing object |
| EndAnchor | An [IDrawingTool's ChartAnchor](idrawingtool.md#chartanchor) representing the end point of the drawing object |
| TextAnchor | An [IDrawingTool's ChartAnchor](idrawingtool.md#chartanchor) representing the text point of the drawing object |
| TextColor | A [Brush](http://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) class representing the fill color of the draw object's text area |
| LineColor | A [Stroke](stroke_class.md) object used to draw the object |

## Example

```csharp
// Instantiate a Ruler object
Ruler myRuler = Draw.Ruler(this, "tag1", true, 4, Low[4], 3, High[3], 1, Low[1]);
// Change the object's text color to white
myRuler.TextColor = Brushes.White;
```
