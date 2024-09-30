
NinjaScript > Language Reference > Common > Drawing > Draw.TextFixed() > TextFixed
TextFixed
| << [Click to Display Table of Contents](textfixed.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > [Drawing](drawing.md) > [Draw.TextFixed()](draw_textfixed.md) > TextFixed | [Previous page](draw_textfixed.md) [Return to chapter overview](draw_textfixed.md) [Next page](draw_timecycles.md) |
| --- | --- |
## Definition
Represents an interface that exposes information regarding a Text Fixed [IDrawingTool](idrawingtool.md).
 
## Methods and Properties
| Anchor | An [IDrawingTool's ChartAnchor](idrawingtool.htm#chartanchor) representing the point of the drawing object |
| --- | --- |
| YPixelOffset | An int value representing the offset value in pixels from within the text box area |
| Alignment | Possible values are:   TextAlignment.Center  TextAlignment.Far  TextAlignment.Near  TextAlignment.Justify ([reference](https://msdn.microsoft.com/en-us/library/system.windows.textalignment%28v=vs.110%29.aspx)) |
| AreaOpacity | An int value representing the opacity of the area color |
| AreaBrush | A [Brush](http://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) class representing the fill color of the text box |
| DisplayText | A string value representing the text to be drawn |
| TextBrush | A [Brush](http://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) class representing the color of the text |
| Font | A [Font](simplefont_class.md) object representing the font for the text |
| OutlineStroke | The [Stroke](stroke_class.md) object used to outline the text box |
| TextPosition | Possible values are:   TextPosition.BottomLeft TextPosition.BottomRight TextPosition.Center TextPosition.TopLeft TextPosition.TopRight |

## 
## 
## 
## Example
| ns |
| --- |
| // Instantiate a TextFixed object TextFixed myTF = Draw.TextFixed(this, "tag1", "Text to draw", TextPosition.TopRight);   // Change the object's TextPosition myTF.TextPosition = TextPosition.Center; |
