



SharpDX.DirectWrite.TextLayout

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\sharpdx_directwrite_textlayout.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [SharpDX SDK Reference](sharpdx_sdk_reference-1.htm) > [SharpDX.DirectWrite](sharpdx_directwrite-1.htm) >  SharpDX.DirectWrite.TextLayout | [Previous page](sharpdx_directwrite_linemetrics-1.htm) [Return to chapter overview](sharpdx_directwrite-1.htm) [Next page](sharpdx_directwrite_textlayout_getlinemetrics-1.htm) |

|  |
| --- |
| Disclaimer: The [SharpDX SDK Reference](sharpdx_sdk_reference-1.htm) section was compiled from the official [SharpDX Documentation](http://sharpdx.org/) and was NOT authored by NinjaTrader.  The contents of this section are provided as-is and only cover a fraction of what is available from the SharpDX SDK.  This page was intended only as a reference guide to help you get started with some of the 2D Graphics concepts used in the NinjaTrader.Custom assembly.  Please refer to the official SharpDX Documentation for additional members not covered in this reference.  For more seasoned graphic developers, the original MSDN [Direct2D1](https://msdn.microsoft.com/en-us/library/windows/desktop/dd370990.aspx) and [DirectWrite](https://msdn.microsoft.com/en-us/library/windows/desktop/dd368038.aspx) unmanaged API documentation can also be helpful for understanding the DirectX/Direct2D run-time environment. For NinjaScript development purposes, we document only essential members in the structure of this page. |

Definition
----------

The TextLayout interface represents a block of text after it has been fully analyzed and formatted.

(See also [unmanaged API documentation](http://msdn.microsoft.com/en-us/library/dd316718.aspx))

|  |
| --- |
| Note: To draw a formatted string represented by an TextLayout object, Direct2D provides the DrawTextLayout method. |

Syntax
------

class TextLayout

Constructors
------------

|  |  |
| --- | --- |
| new TextLayout(Factory factory, string text, [TextFormat](sharpdx_directwrite_textformat-1.htm) textFormat, float maxWidth, float maxHeight) | Takes a string, text format, and associated constraints, and produces an object that represents the fully analyzed and formatted result. |

|  |
| --- |
| Tip: For NinjaScript development purposes, when creating a TextLayout object you should use the [NinjaTrader.Core.Globals.DirectWriteFactory](directwritefactory-1.htm) property |

Methods and Properties
----------------------

|  |  |
| --- | --- |
| [Dispose()](sharpdx_disposebase_dispose-1.htm) | Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources. (Inherited from [SharpDX.DisposeBase](sharpdx_disposebase-1.htm).) |
| [FlowDirection](sharpdx_directwrite_textformat_flowdirection-1.htm) | Gets or sets the direction that text lines flow. (Inherited from [TextFormat](sharpdx_directwrite_textformat-1.htm).) |
| [FontFamilyName](sharpdx_directwrite_textformat_fontfamilyname-1.htm) | Gets a copy of the font family name.(Inherited from [TextFormat](sharpdx_directwrite_textformat-1.htm).) |
| [FontSize](sharpdx_directwrite_textformat_fontsize-1.htm) | Gets the font size in DIP unites. (Inherited from [TextFormat](sharpdx_directwrite_textformat-1.htm).) |
| [FontStretch](sharpdx_directwrite_textformat_fontstretch-1.htm) | Gets the font stretch of the text. (Inherited from [TextFormat](sharpdx_directwrite_textformat-1.htm).) |
| [FontStyle](sharpdx_directwrite_textformat_fontstyle-1.htm) | Gets the font style of the text. (Inherited from [TextFormat](sharpdx_directwrite_textformat-1.htm).) |
| [FontWeight](sharpdx_directwrite_textformat_fontweight-1.htm) | Gets the font weight of the text. (Inherited from [TextFormat](sharpdx_directwrite_textformat-1.htm).) |
| [IsDisposed](sharpdx_disposebase_isdisposed-1.htm) | Gets a value indicating whether this instance is disposed. (Inherited from [SharpDX.DisposeBase](sharpdx_disposebase-1.htm).) |
| [MaxHeight](sharpdx_directwrite_textlayout_maxheight-1.htm) | Gets or sets the layout maximum height. |
| [MaxWidth](sharpdx_directwrite_textlayout_maxwidth-1.htm) | Gets or sets the layout maximum width. |
| [Metrics](sharpdx_directwrite_textlayout_metrics-1.htm) | Contains the metrics associated with text after layout. All coordinates are in device independent pixels (DIPs). |
| [ParagraphAlignment](sharpdx_directwrite_textformat_paragraphalignment-1.htm) | Gets or sets the alignment option of a paragraph which is relative to the top and bottom edges of a layout box.(Inherited from [TextFormat](sharpdx_directwrite_textformat-1.htm).) |
| [ReadingDirection](sharpdx_directwrite_textformat_readingdirection-1.htm) | Gets or sets the current reading direction for text in a paragraph.  (Inherited from [TextFormat](sharpdx_directwrite_textformat-1.htm).) |
| [TextAlignment](sharpdx_directwrite_textformat_textalignment-1.htm) | Gets or sets the alignment option of text relative to the layout box's leading and trailing edge. (Inherited from [TextFormat](sharpdx_directwrite_textformat-1.htm).) |
| [WordWrapping](sharpdx_directwrite_textformat_wordwrapping-1.htm) | Gets or sets the word wrapping option.  (Inherited from [TextFormat](sharpdx_directwrite_textformat-1.htm).) |