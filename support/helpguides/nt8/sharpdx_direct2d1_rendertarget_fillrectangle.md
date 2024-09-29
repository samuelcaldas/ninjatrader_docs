


NinjaScript \> SharpDX SDK Reference \> SharpDX.Direct2D1 \> RenderTarget \> FillRectangle()






















SharpDX.Direct2D1\.RenderTarget.FillRectangle()







| \<\< [Click to Display Table of Contents](sharpdx_direct2d1_rendertarget_fillrectangle.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [SharpDX SDK Reference](sharpdx_sdk_reference.md) \> [SharpDX.Direct2D1](sharpdx_direct2d1.md) \> [RenderTarget](sharpdx_direct2d1_rendertarget.md) \> SharpDX.Direct2D1\.RenderTarget.FillRectangle() | [Previous page](sharpdx_direct2d1_rendertarget_fillgeometry.md) [Return to chapter overview](sharpdx_direct2d1_rendertarget.md) [Next page](sharpdx_direct2d1_rendertarget_transform.md) |
| --- | --- |













| Disclaimer: The [SharpDX SDK Reference](sharpdx_sdk_reference.md) section was compiled from the official [SharpDX Documentation](http://sharpdx.org/) and was NOT authored by NinjaTrader.  The contents of this section are provided as\-is and only cover a fraction of what is available from the SharpDX SDK.  This page was intended only as a reference guide to help you get started with some of the 2D Graphics concepts used in the NinjaTrader.Custom assembly.  Please refer to the official SharpDX Documentation for additional members not covered in this reference.  For more seasoned graphic developers, the original MSDN [Direct2D1](https://msdn.microsoft.com/en-us/library/windows/desktop/dd370990.aspx) and [DirectWrite](https://msdn.microsoft.com/en-us/library/windows/desktop/dd368038.aspx) unmanaged API documentation can also be helpful for understanding the DirectX/Direct2D run\-time environment. For NinjaScript development purposes, we document only essential members in the structure of this page. |
| --- |



 


 


## Definition


Paints the interior of the specified rectangle.


(See also [unamanged API documentation](http://msdn.microsoft.com/en-us/library/dd371954.aspx))


 




| Note:  This method doesn't return an error code if it fails. |
| --- |



 


 


## Method Return Value


This method does not return a value


 


## Syntax


RenderTarget.FillRectangle(RectangleF rect, Brush brush)


## Parameters




| brush | The [SharpDX.Direct2D1\.Brush](sharpdx_direct2d1_brush.md) used to paint the rectangle's interior. |
| --- | --- |
| rect | A [SharpDX.RectangleF](sharpdx_rectanglef.md) describing the dimension of the rectangle to paint, in device\-independent pixels. |









