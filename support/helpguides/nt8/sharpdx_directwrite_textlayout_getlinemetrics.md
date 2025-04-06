



SharpDX.DirectWrite.TextLayout.GetLineMetrics()

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](sharpdx_directwrite_textlayout_getlinemetrics.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [SharpDX SDK Reference](sharpdx_sdk_reference.htm) > [SharpDX.DirectWrite](sharpdx_directwrite.htm) > [TextLayout](sharpdx_directwrite_textlayout.htm) >  SharpDX.DirectWrite.TextLayout.GetLineMetrics() | [Previous page](sharpdx_directwrite_textlayout.htm) [Return to chapter overview](sharpdx_directwrite_textlayout.htm) [Next page](sharpdx_directwrite_textlayout_maxheight.htm) |

|  |
| --- |
| Disclaimer: The [SharpDX SDK Reference](sharpdx_sdk_reference.htm) section was compiled from the official [SharpDX Documentation](http://sharpdx.org/) and was NOT authored by NinjaTrader.  The contents of this section are provided as-is and only cover a fraction of what is available from the SharpDX SDK.  This page was intended only as a reference guide to help you get started with some of the 2D Graphics concepts used in the NinjaTrader.Custom assembly.  Please refer to the official SharpDX Documentation for additional members not covered in this reference.  For more seasoned graphic developers, the original MSDN [Direct2D1](https://msdn.microsoft.com/en-us/library/windows/desktop/dd370990.aspx) and [DirectWrite](https://msdn.microsoft.com/en-us/library/windows/desktop/dd368038.aspx) unmanaged API documentation can also be helpful for understanding the DirectX/Direct2D run-time environment. For NinjaScript development purposes, we document only essential members in the structure of this page. |

Definition
----------

Retrieves the information about each individual text line of the text string.

(See also [unmanaged API documentation](https://msdn.microsoft.com/en-us/library/dd316763(v=vs.85).aspx))

Method Return Value
-------------------

A [LineMetrics](sharpdx_directwrite_linemetrics.htm)[] contains a pointer to an array of structures containing various calculated length values of individual text lines.

Syntax
------

<TextLayout>.GetLineMetrics()
-----------------------------

Parameters
----------

This method does not accept any parameters