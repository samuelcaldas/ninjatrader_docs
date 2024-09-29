


NinjaScript \> SharpDX SDK Reference \> SharpDX.Direct2D1 \> RenderTarget \> DrawText()






















SharpDX.Direct2D1\.RenderTarget.DrawText()







| \<\< [Click to Display Table of Contents](sharpdx_direct2d1_rendertarget_drawtext.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [SharpDX SDK Reference](sharpdx_sdk_reference.md) \> [SharpDX.Direct2D1](sharpdx_direct2d1.md) \> [RenderTarget](sharpdx_direct2d1_rendertarget.md) \> SharpDX.Direct2D1\.RenderTarget.DrawText() | [Previous page](sharpdx_direct2d1_rendertarget_drawrectangle.md) [Return to chapter overview](sharpdx_direct2d1_rendertarget.md) [Next page](sharpdx_direct2d1_rendertarget_drawtextlayout.md) |
| --- | --- |













| Disclaimer: The [SharpDX SDK Reference](sharpdx_sdk_reference.md) section was compiled from the official [SharpDX Documentation](http://sharpdx.org/) and was NOT authored by NinjaTrader.  The contents of this section are provided as\-is and only cover a fraction of what is available from the SharpDX SDK.  This page was intended only as a reference guide to help you get started with some of the 2D Graphics concepts used in the NinjaTrader.Custom assembly.  Please refer to the official SharpDX Documentation for additional members not covered in this reference.  For more seasoned graphic developers, the original MSDN [Direct2D1](https://msdn.microsoft.com/en-us/library/windows/desktop/dd370990.aspx) and [DirectWrite](https://msdn.microsoft.com/en-us/library/windows/desktop/dd368038.aspx) unmanaged API documentation can also be helpful for understanding the DirectX/Direct2D run\-time environment. For NinjaScript development purposes, we document only essential members in the structure of this page. |
| --- |



 


 


## Definition


Draws the specified text using the format information provided by an [SharpDX.DirectWrite.TextFormat](sharpdx_directwrite_textformat.md) object.


(See also [unmanaged API documentation](http://msdn.microsoft.com/en-us/library/dd742848.aspx))


 




| Note:  This method doesn't return an error code if it fails. |
| --- |



 


## 


## Method Return Value


This method does not return a value.


 


## Syntax


RenderTarget.DrawText(string text, TextFormat textFormat, RectangleF layoutRect, Brush defaultForegroundBrush)  

RenderTarget.DrawText(string text, TextFormat textFormat, RectangleF layoutRect, Brush defaultForegroundBrush, DrawTextOptions options)  

RenderTarget.DrawText(string text, TextFormat textFormat, RectangleF layoutRect, Brush defaultForegroundBrush, DrawTextOptions options,   MeasuringMode measuringMode)  

RenderTarget.DrawText(string text, int stringLength, TextFormat textFormat, RectangleF layoutRect, Brush defaultForegroundBrush, RenderTarget.DrawTextOptions options, MeasuringMode measuringMode)


## Parameters




| defaultForegroundBrush | The [SharpDX.Direct2D1\.Brush](sharpdx_direct2d1_brush.md) used to paint the text. |
| --- | --- |
| layoutRect | A [SharpDX.RectangleF](sharpdx_rectanglef.md) which determines size and position of the area in which the text is drawn. |
| measuringMode | A [SharpDX.Direct2D1\.MeasuringMode](sharpdx_direct2d1_measuringmode.md) value that indicates how glyph metrics are used to measure text when it is formatted. The default value is DWRITE\_MEASURING\_MODE\_NATURAL. |
| options | A [SharpDX.Direct2D1\.DrawTextOptions](sharpdx_direct2d1_drawtextoptions.md) value that indicates whether the text should be snapped to pixel boundaries and whether the text should be clipped to the layout rectangle. The default value is None, which indicates that text should be snapped to pixel boundaries and it should not be clipped to the layout rectangle. |
| stringLength | An int value which represents the number of characters in string. |
| text | A string reference to an array of Unicode characters to draw. |
| textFormat | A [SharpDX.DirectWrite.TextFormat](sharpdx_directwrite_textformat.md) object that describes formatting details of the text to draw, such as the font, the font size, and flow direction. |









