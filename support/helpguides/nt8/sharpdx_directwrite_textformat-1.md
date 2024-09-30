
NinjaScript > SharpDX SDK Reference > SharpDX.DirectWrite > TextFormat

SharpDX.DirectWrite.TextFormat

| << [Click to Display Table of Contents](sharpdx_directwrite_textformat.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [SharpDX SDK Reference](sharpdx_sdk_reference-1.md) > [SharpDX.DirectWrite](sharpdx_directwrite-1.md) > SharpDX.DirectWrite.TextFormat | [Previous page](sharpdx_directwrite-1.md) [Return to chapter overview](sharpdx_directwrite-1.md) [Next page](sharpdx_directwrite_textformat_flowdirection-1.md) |
| --- | --- |

| Disclaimer: The [SharpDX SDK Reference](sharpdx_sdk_reference-1.md) section was compiled from the official [SharpDX Documentation](http://sharpdx.org/) and was NOT authored by NinjaTrader.  The contents of this section are provided as-is and only cover a fraction of what is available from the SharpDX SDK.  This page was intended only as a reference guide to help you get started with some of the 2D Graphics concepts used in the NinjaTrader.Custom assembly.  Please refer to the official SharpDX Documentation for additional members not covered in this reference.  For more seasoned graphic developers, the original MSDN [Direct2D1](https://msdn.microsoft.com/en-us/library/windows/desktop/dd370990.aspx) and [DirectWrite](https://msdn.microsoft.com/en-us/library/windows/desktop/dd368038.aspx) unmanaged API documentation can also be helpful for understanding the DirectX/Direct2D run-time environment. For NinjaScript development purposes, we document only essential members in the structure of this page. |
| --- |

## Definition
The TextFormat interface describes the font and paragraph properties used to format text, and it describes locale information. 
(See also [unmanaged API documentation](https://msdn.microsoft.com/en-us/library/dd316628.aspx))
 

| Notes:  1.These properties cannot be changed after the TextFormat object is created. To change these properties, a new TextFormat object must be created with the desired properties.2.The TextFormat interface is used to draw text with a single format.  To draw text with multiple formats, or to use a custom text renderer, use the [TextLayout](sharpdx_directwrite_textlayout-1.md) interface. TextLayout enables the application to change the format for ranges of text within the string.3.This object may not be thread-safe, and it may carry the state of text format change.4.To draw simple text with a single format, Direct2D provides the [DrawText()](sharpdx_direct2d1_rendertarget_drawtext-1.md) method, which draws a string using the format information provided by an TextFormat object. |
| --- |

## Syntax
class TextFormat
## Constructors

| new TextFormat(Factory factory, string fontFamilyName, float fontSize) | Creates a text format object used for text layout with normal weight, style and stretch. |
| --- | --- |
| new TextFormat(Factory factory, string fontFamilyName, [FontWeight](sharpdx_directwrite_textformat_fontweight-1.md) fontWeight, [FontStyle](sharpdx_directwrite_textformat_fontstyle-1.md) fontStyle, float fontSize) | Creates a text format object used for text layout with normal stretch. |
| new TextFormat(Factory factory, string fontFamilyName, [FontWeight](sharpdx_directwrite_textformat_fontweight-1.md) fontWeight, [FontStyle](sharpdx_directwrite_textformat_fontstyle-1.md) fontStyle, [FontStretch](sharpdx_directwrite_textformat_fontstretch-1.md) fontStretch, float fontSize) | Creates a text format object used for text layout. |
## 
## 

| Tip: For NinjaScript development purposes, when creating a TextFormat object you should use the [NinjaTrader.Core.Globals.DirectWriteFactory](directwritefactory-1.md) property |
| --- |
## 
## 
## Methods and Properties

| [Dispose()](sharpdx_disposebase_dispose-1.md) | Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources. (Inherited from [SharpDX.DisposeBase](sharpdx_disposebase-1.md).) |
| --- | --- |
| [FlowDirection](sharpdx_directwrite_textformat_flowdirection-1.md) | Gets or sets the direction that text lines flow. |
| [FontFamilyName](sharpdx_directwrite_textformat_fontfamilyname-1.md) | Creates a text format object used for text layout with normal weight, style and stretch. |
| [FontSize](sharpdx_directwrite_textformat_fontsize-1.md) | Creates a text format object used for text layout with normal stretch. |
| [FontStretch](sharpdx_directwrite_textformat_fontstretch-1.md) | Creates a text format object used for text layout. |
| [FontStyle](sharpdx_directwrite_textformat_fontstyle-1.md) | Gets the font style of the text. |
| [FontWeight](sharpdx_directwrite_textformat_fontweight-1.md) | Gets the font weight of the text. |
| [IsDisposed](sharpdx_disposebase_isdisposed-1.md) | Gets a value indicating whether this instance is disposed.  (Inherited from [SharpDX.DisposeBase](sharpdx_disposebase-1.md).) |
| [ParagraphAlignment](sharpdx_directwrite_textformat_paragraphalignment-1.md) | Gets or sets the alignment option of a paragraph which is relative to the top and bottom edges of a layout box. |
| [ReadingDirection](sharpdx_directwrite_textformat_readingdirection-1.md) | Gets or sets the current reading direction for text in a paragraph. |
| [TextAlignment](sharpdx_directwrite_textformat_textalignment-1.md) | Gets or sets the alignment option of text relative to the layout box's leading and trailing edge. |
| [WordWrapping](sharpdx_directwrite_textformat_wordwrapping-1.md) | Gets or sets the word wrapping option. |
