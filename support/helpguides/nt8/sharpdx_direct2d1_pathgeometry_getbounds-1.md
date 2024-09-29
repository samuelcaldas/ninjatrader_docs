


NinjaScript \> SharpDX SDK Reference \> SharpDX.Direct2D1 \> PathGeometry \> GetBounds()






















SharpDX.Direct2D1\.PathGeometry.GetBounds()







| \<\< [Click to Display Table of Contents](sharpdx_direct2d1_pathgeometry_getbounds.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [SharpDX SDK Reference](sharpdx_sdk_reference-1.md) \> [SharpDX.Direct2D1](sharpdx_direct2d1-1.md) \> [PathGeometry](sharpdx_direct2d1_pathgeometry-1.md) \> SharpDX.Direct2D1\.PathGeometry.GetBounds() | [Previous page](sharpdx_direct2d1_pathgeometry_fillcontainspoint-1.md) [Return to chapter overview](sharpdx_direct2d1_pathgeometry-1.md) [Next page](sharpdx_direct2d1_pathgeometry_open-1.md) |
| --- | --- |













| Disclaimer: The [SharpDX SDK Reference](sharpdx_sdk_reference-1.md) section was compiled from the official [SharpDX Documentation](http://sharpdx.org/) and was NOT authored by NinjaTrader.  The contents of this section are provided as\-is and only cover a fraction of what is available from the SharpDX SDK.  This page was intended only as a reference guide to help you get started with some of the 2D Graphics concepts used in the NinjaTrader.Custom assembly.  Please refer to the official SharpDX Documentation for additional members not covered in this reference.  For more seasoned graphic developers, the original MSDN [Direct2D1](https://msdn.microsoft.com/en-us/library/windows/desktop/dd370990.aspx) and [DirectWrite](https://msdn.microsoft.com/en-us/library/windows/desktop/dd368038.aspx) unmanaged API documentation can also be helpful for understanding the DirectX/Direct2D run\-time environment. For NinjaScript development purposes, we document only essential members in the structure of this page. |
| --- |



 


 


## Definition


Retrieves the bounds of the geometry.


(See also [unmanaged API documentation](http://msdn.microsoft.com/en-us/library/dd742751.aspx))


 


## Method Return Value


A [SharpDX.RectangleF](sharpdx_rectanglef-1.md) which contains the bounds of this geometry. If the bounds are empty, this will be a rect where bounds.left \> bounds.right.


 


## Syntax


\<PathGeometry\>.GetBounds()


## Parameters


This method does not accept any parameters








