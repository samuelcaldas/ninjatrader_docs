
NinjaScript > SharpDX SDK Reference > SharpDX.DirectWrite > TextLayout

SharpDX.DirectWrite.TextLayout

| << [Click to Display Table of Contents](sharpdx_directwrite_textlayout.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [SharpDX SDK Reference](sharpdx_sdk_reference.md) > [SharpDX.DirectWrite](sharpdx_directwrite.md) > SharpDX.DirectWrite.TextLayout | [Previous page](sharpdx_directwrite_linemetrics.md) [Return to chapter overview](sharpdx_directwrite.md) [Next page](sharpdx_directwrite_textlayout_getlinemetrics.md) |
| --- | --- |

| Disclaimer: The [SharpDX SDK Reference](sharpdx_sdk_reference.md) section was compiled from the official [SharpDX Documentation](http://sharpdx.org/) and was NOT authored by NinjaTrader.  The contents of this section are provided as-is and only cover a fraction of what is available from the SharpDX SDK.  This page was intended only as a reference guide to help you get started with some of the 2D Graphics concepts used in the NinjaTrader.Custom assembly.  Please refer to the official SharpDX Documentation for additional members not covered in this reference.  For more seasoned graphic developers, the original MSDN [Direct2D1](https://msdn.microsoft.com/en-us/library/windows/desktop/dd370990.aspx) and [DirectWrite](https://msdn.microsoft.com/en-us/library/windows/desktop/dd368038.aspx) unmanaged API documentation can also be helpful for understanding the DirectX/Direct2D run-time environment. For NinjaScript development purposes, we document only essential members in the structure of this page. |
| --- |

## Definition
The TextLayout interface represents a block of text after it has been fully analyzed and formatted.
(See also [unmanaged API documentation](http://msdn.microsoft.com/en-us/library/dd316718.aspx))
 

| Note: To draw a formatted string represented by an TextLayout object, Direct2D provides the DrawTextLayout method. |
| --- |
 
## Syntax
class TextLayout
## Constructors

| new TextLayout(Factory factory, string text, [TextFormat](sharpdx_directwrite_textformat.md) textFormat, float maxWidth, float maxHeight) | Takes a string, text format, and associated constraints, and produces an object that represents the fully analyzed and formatted result. |
| --- | --- |
## 
## 

| Tip: For NinjaScript development purposes, when creating a TextLayout object you should use the [NinjaTrader.Core.Globals.DirectWriteFactory](directwritefactory.md) property |
| --- |
## 
## 
## Methods and Properties

| [Dispose()](sharpdx_disposebase_dispose.md) | Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources. (Inherited from [SharpDX.DisposeBase](sharpdx_disposebase.md).) |
| --- | --- |
| [FlowDirection](sharpdx_directwrite_textformat_flowdirection.md) | Gets or sets the direction that text lines flow. (Inherited from [TextFormat](sharpdx_directwrite_textformat.md).) |
| [FontFamilyName](sharpdx_directwrite_textformat_fontfamilyname.md) | Gets a copy of the font family name.(Inherited from [TextFormat](sharpdx_directwrite_textformat.md).) |
| [FontSize](sharpdx_directwrite_textformat_fontsize.md) | Gets the font size in DIP unites. (Inherited from [TextFormat](sharpdx_directwrite_textformat.md).) |
| [FontStretch](sharpdx_directwrite_textformat_fontstretch.md) | Gets the font stretch of the text. (Inherited from [TextFormat](sharpdx_directwrite_textformat.md).) |
| [FontStyle](sharpdx_directwrite_textformat_fontstyle.md) | Gets the font style of the text. (Inherited from [TextFormat](sharpdx_directwrite_textformat.md).) |
| [FontWeight](sharpdx_directwrite_textformat_fontweight.md) | Gets the font weight of the text. (Inherited from [TextFormat](sharpdx_directwrite_textformat.md).) |
| [IsDisposed](sharpdx_disposebase_isdisposed.md) | Gets a value indicating whether this instance is disposed. (Inherited from [SharpDX.DisposeBase](sharpdx_disposebase.md).) |
| [MaxHeight](sharpdx_directwrite_textlayout_maxheight.md) | Gets or sets the layout maximum height. |
| [MaxWidth](sharpdx_directwrite_textlayout_maxwidth.md) | Gets or sets the layout maximum width. |
| [Metrics](sharpdx_directwrite_textlayout_metrics.md) | Contains the metrics associated with text after layout. All coordinates are in device independent pixels (DIPs). |
| [ParagraphAlignment](sharpdx_directwrite_textformat_paragraphalignment.md) | Gets or sets the alignment option of a paragraph which is relative to the top and bottom edges of a layout box.(Inherited from [TextFormat](sharpdx_directwrite_textformat.md).) |
| [ReadingDirection](sharpdx_directwrite_textformat_readingdirection.md) | Gets or sets the current reading direction for text in a paragraph. (Inherited from [TextFormat](sharpdx_directwrite_textformat.md).) |
| [TextAlignment](sharpdx_directwrite_textformat_textalignment.md) | Gets or sets the alignment option of text relative to the layout box's leading and trailing edge. (Inherited from [TextFormat](sharpdx_directwrite_textformat.md).) |
| [WordWrapping](sharpdx_directwrite_textformat_wordwrapping.md) | Gets or sets the word wrapping option. (Inherited from [TextFormat](sharpdx_directwrite_textformat.md).) |
