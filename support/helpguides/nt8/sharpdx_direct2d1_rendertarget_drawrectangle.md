﻿
NinjaScript > SharpDX SDK Reference > SharpDX.Direct2D1 > RenderTarget > DrawRectangle()
SharpDX.Direct2D1.RenderTarget.DrawRectangle()

| << [Click to Display Table of Contents](sharpdx_direct2d1_rendertarget_drawrectangle.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [SharpDX SDK Reference](sharpdx_sdk_reference.md) > [SharpDX.Direct2D1](sharpdx_direct2d1.md) > [RenderTarget](sharpdx_direct2d1_rendertarget.md) > SharpDX.Direct2D1.RenderTarget.DrawRectangle() | [Previous page](sharpdx_direct2d1_rendertarget_drawline.md) [Return to chapter overview](sharpdx_direct2d1_rendertarget.md) [Next page](sharpdx_direct2d1_rendertarget_drawtext.md) |
| --- | --- |

| Disclaimer: The [SharpDX SDK Reference](sharpdx_sdk_reference.md) section was compiled from the official [SharpDX Documentation](http://sharpdx.org/) and was NOT authored by NinjaTrader.  The contents of this section are provided as-is and only cover a fraction of what is available from the SharpDX SDK.  This page was intended only as a reference guide to help you get started with some of the 2D Graphics concepts used in the NinjaTrader.Custom assembly.  Please refer to the official SharpDX Documentation for additional members not covered in this reference.  For more seasoned graphic developers, the original MSDN [Direct2D1](https://msdn.microsoft.com/en-us/library/windows/desktop/dd370990.aspx) and [DirectWrite](https://msdn.microsoft.com/en-us/library/windows/desktop/dd368038.aspx) unmanaged API documentation can also be helpful for understanding the DirectX/Direct2D run-time environment. For NinjaScript development purposes, we document only essential members in the structure of this page. |
| --- |

## Definition
Draws the outline of a rectangle that has the specified dimensions and stroke style.
(See also [unmanaged API documentation](http://msdn.microsoft.com/en-us/library/dd371902.aspx))
 
| Note:  This method doesn't return an error code if it fails. |
| --- |

## Method Return Value
This method does not return a value
 
## Syntax
RenderTarget.DrawRectangle(RectangleF rect, Brush brush)  

RenderTarget.DrawRectangle(RectangleF rect, Brush brush, float strokeWidth)  

RenderTarget.DrawRectangle(RectangleF rect, Brush brush, float strokeWidth, StrokeStyle strokeStyle)
## Parameters
| brush | The [SharpDX.Direct2D1.Brush](sharpdx_direct2d1_brush.md) used to paint the rectangle's stroke. |
| --- | --- |
| rect | The [SharpDX.RectangleF](sharpdx_rectanglef.md) which determines the dimensions of the rectangle to draw, in device-independent pixels. |
| strokeStyle | The [SharpDX.Direct2D1.StrokeStyle](sharpdx_direct2d1_strokestyle.md) used to paint, or null to paint a solid stroke. |
| strokeWidth | A value greater than or equal to 0.0f that specifies the width of the rectangle's stroke. The stroke is centered on the rectangle's outline. |

