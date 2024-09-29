


NinjaScript \> Language Reference \> Common \> Drawing \> Draw.Text() \> Text






















Text







| \<\< [Click to Display Table of Contents](text.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [Drawing](drawing-1.md) \> [Draw.Text()](draw_text-1.md) \> Text | [Previous page](draw_text-1.md) [Return to chapter overview](draw_text-1.md) [Next page](draw_textfixed-1.md) |
| --- | --- |











## Definition


Represents an interface that exposes information regarding a Text [IDrawingTool](idrawingtool-1.md).


 


## Methods and Properties




| Anchor | An [IDrawingTool's ChartAnchor](idrawingtool-1.htm#chartanchor) representing the point of the drawing object |
| --- | --- |
| YPixelOffset | An int value representing the offset value in pixels from within the text box area |
| Alignment | Possible values are:   TextAlignment.Center,  TextAlignment.Left,  TextAlignment.Right,  TextAlignment.Justify ([reference](https://msdn.microsoft.com/en-us/library/system.windows.textalignment(v=vs.110).aspx)) |
| AreaOpacity | An int value representing the opacity of the area color |
| AreaBrush | A [Brush](http://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) class representing the fill color of the text box |
| Text | A string value representing the text to be drawn |
| TextBrush | A [Brush](http://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) class representing the color of the text |
| Font | A [Font](http://msdn.microsoft.com/en-us/library/system.drawing.font_members(v=vs.90).aspx) object representing the font for the text |
| OutlineStroke | The [Stroke](stroke_class-1.md) object used to outline the text box |



## 


## 


## 


## Example




| ns |
| --- |
| // Instantiate a Text object Text myText \= Draw.Text(this, "tag1", "Text to draw", 10, High\[10] \+ (5 \* TickSize), Brushes.Black);   // Change the object's DisplayText myText.DisplayText \= "New Display Text"; |









