
NinjaScript > SharpDX SDK Reference > SharpDX.Direct2D1 > RenderTarget > FillEllipse()
SharpDX.Direct2D1.RenderTarget.FillEllipse()
| << [Click to Display Table of Contents](sharpdx_direct2d1_rendertarget_fillellipse.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [SharpDX SDK Reference](sharpdx_sdk_reference-1.md) > [SharpDX.Direct2D1](sharpdx_direct2d1-1.md) > [RenderTarget](sharpdx_direct2d1_rendertarget-1.md) > SharpDX.Direct2D1.RenderTarget.FillEllipse() | [Previous page](sharpdx_direct2d1_rendertarget_drawtextlayout-1.md) [Return to chapter overview](sharpdx_direct2d1_rendertarget-1.md) [Next page](sharpdx_direct2d1_rendertarget_fillgeometry-1.md) |
| --- | --- |
| Disclaimer: The [SharpDX SDK Reference](sharpdx_sdk_reference-1.md) section was compiled from the official [SharpDX Documentation](http://sharpdx.org/) and was NOT authored by NinjaTrader.  The contents of this section are provided as-is and only cover a fraction of what is available from the SharpDX SDK.  This page was intended only as a reference guide to help you get started with some of the 2D Graphics concepts used in the NinjaTrader.Custom assembly.  Please refer to the official SharpDX Documentation for additional members not covered in this reference.  For more seasoned graphic developers, the original MSDN [Direct2D1](https://msdn.microsoft.com/en-us/library/windows/desktop/dd370990.aspx) and [DirectWrite](https://msdn.microsoft.com/en-us/library/windows/desktop/dd368038.aspx) unmanaged API documentation can also be helpful for understanding the DirectX/Direct2D run-time environment. For NinjaScript development purposes, we document only essential members in the structure of this page. |
| --- |

## Definition
Paints the interior of the specified ellipse.
(See also [unmanaged API documentation](http://msdn.microsoft.com/en-us/library/dd371928.aspx))
 
| Note:  This method doesn't return an error code if it fails. |
| --- |

## Method Return Value
This method does not return a value
 
## Syntax
RenderTarget.FillEllipse(Ellipse ellipse, Brush brush)
## Parameters
| brush | A [SharpDX.Direct2D1.Brush](sharpdx_direct2d1_brush-1.md) used to paint the interior of the ellipse. |
| --- | --- |
| ellipse | A [SharpDX.Direct2D1.Ellipse](sharpdx_direct2d1_ellipse-1.md) which describes the position and radius, in device-independent pixels, of the ellipse to paint. |
