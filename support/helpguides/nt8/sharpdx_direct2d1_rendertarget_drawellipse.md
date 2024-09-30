
NinjaScript \> SharpDX SDK Reference \> SharpDX.Direct2D1 \> RenderTarget \> DrawEllipse()
SharpDX.Direct2D1\.RenderTarget.DrawEllipse()

| \<\< [Click to Display Table of Contents](sharpdx_direct2d1_rendertarget_drawellipse.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [SharpDX SDK Reference](sharpdx_sdk_reference.md) \> [SharpDX.Direct2D1](sharpdx_direct2d1.md) \> [RenderTarget](sharpdx_direct2d1_rendertarget.md) \> SharpDX.Direct2D1\.RenderTarget.DrawEllipse() | [Previous page](sharpdx_direct2d1_rendertarget_antialiasmode.md) [Return to chapter overview](sharpdx_direct2d1_rendertarget.md) [Next page](sharpdx_direct2d1_rendertarget_drawgeometry.md) |
| --- | --- |

| Disclaimer: The [SharpDX SDK Reference](sharpdx_sdk_reference.md) section was compiled from the official [SharpDX Documentation](http://sharpdx.org/) and was NOT authored by NinjaTrader.  The contents of this section are provided as\-is and only cover a fraction of what is available from the SharpDX SDK.  This page was intended only as a reference guide to help you get started with some of the 2D Graphics concepts used in the NinjaTrader.Custom assembly.  Please refer to the official SharpDX Documentation for additional members not covered in this reference.  For more seasoned graphic developers, the original MSDN [Direct2D1](https://msdn.microsoft.com/en-us/library/windows/desktop/dd370990.aspx) and [DirectWrite](https://msdn.microsoft.com/en-us/library/windows/desktop/dd368038.aspx) unmanaged API documentation can also be helpful for understanding the DirectX/Direct2D run\-time environment. For NinjaScript development purposes, we document only essential members in the structure of this page. |
| --- |

## Definition
Draws the outline of the specified ellipse using the specified stroke style.
(See also [unmanaged API documentation](http://msdn.microsoft.com/en-us/library/dd371886.aspx))
 
| Note:  This method doesn't return an error code if it fails. |
| --- |

## Method Return Value
This method does not return a value
 
## Syntax
RenderTarget.DrawEllipse(Ellipse ellipse, Brush brush)  

RenderTarget.DrawEllipse(Ellipse ellipse, Brush brush, float strokeWidth)  

RenderTarget.DrawEllipse(Ellipse ellipse, Brush brush, float strokeWidth, StrokeStyle strokeStyle)
## Parameters
| ellipse | The [SharpDX.Direct2D1\.Ellipse](sharpdx_direct2d1_ellipse.md) position and radius of the ellipse to draw, in device\-independent pixels. |
| --- | --- |
| brush | The [SharpDX.Direct2D1\.Brush](sharpdx_direct2d1_brush.md) used to paint the ellipse's outline. |
| strokeWidth | The thickness of the ellipse's stroke. The stroke is centered on the ellipse's outline. |
| strokeStyle | The [SharpDX.Direct2D1\.StrokeStyle](sharpdx_direct2d1_strokestyle.md) to apply to the ellipse's outline, or null to paint a solid stroke. |

