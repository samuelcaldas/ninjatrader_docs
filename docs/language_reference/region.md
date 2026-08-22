# Region

## Definition

Represents an interface that exposes information regarding a Region [IDrawingTool.](idrawingtool.md)

## Methods and Properties

|  |  |
| --- | --- |
| StartAnchor | An [IDrawingTool's ChartAnchor](idrawingtool.md#chartanchor) representing the starting point of the drawing object |
| EndAnchor | An [IDrawingTool's ChartAnchor](idrawingtool.md#chartanchor) representing the starting point of the drawing object |
| AreaOpacity | An int value representing the opacity of the area color |
| AreaBrush | A [Brush](http://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) object representing the fill color of the draw object |
| OutlineStroke | A Stroke used for the outline of the region |

## Example

```csharp
// Instantiate a Region object
Region myRegion = Draw.Region(this, "tag1", CurrentBar, 0, Bollinger(2, 14).Upper, Bollinger(2, 14).Lower, null, Brushes.Blue, 50);
// Set the object's OutlineStroke to a new Stroke
myRegion.OutlineStroke = new Stroke(Brushes.Red, DashStyleHelper.Solid, 3);
```
