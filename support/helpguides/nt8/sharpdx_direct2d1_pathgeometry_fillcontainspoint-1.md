﻿
NinjaScript > SharpDX SDK Reference > SharpDX.Direct2D1 > PathGeometry > FillContainsPoint()

SharpDX.Direct2D1.PathGeometry.FillContainsPoint()

| << [Click to Display Table of Contents](sharpdx_direct2d1_pathgeometry_fillcontainspoint.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [SharpDX SDK Reference](sharpdx_sdk_reference-1.md) > [SharpDX.Direct2D1](sharpdx_direct2d1-1.md) > [PathGeometry](sharpdx_direct2d1_pathgeometry-1.md) > SharpDX.Direct2D1.PathGeometry.FillContainsPoint() | [Previous page](sharpdx_direct2d1_pathgeometry_figurecount-1.md) [Return to chapter overview](sharpdx_direct2d1_pathgeometry-1.md) [Next page](sharpdx_direct2d1_pathgeometry_getbounds-1.md) |
| --- | --- |

| Disclaimer: The [SharpDX SDK Reference](sharpdx_sdk_reference-1.md) section was compiled from the official [SharpDX Documentation](http://sharpdx.org/) and was NOT authored by NinjaTrader.  The contents of this section are provided as-is and only cover a fraction of what is available from the SharpDX SDK.  This page was intended only as a reference guide to help you get started with some of the 2D Graphics concepts used in the NinjaTrader.Custom assembly.  Please refer to the official SharpDX Documentation for additional members not covered in this reference.  For more seasoned graphic developers, the original MSDN [Direct2D1](https://msdn.microsoft.com/en-us/library/windows/desktop/dd370990.aspx) and [DirectWrite](https://msdn.microsoft.com/en-us/library/windows/desktop/dd368038.aspx) unmanaged API documentation can also be helpful for understanding the DirectX/Direct2D run-time environment. For NinjaScript development purposes, we document only essential members in the structure of this page. |
| --- |

## Definition
Indicates whether the area filled by the geometry would contain the specified point given the specified flattening tolerance.
(See also [unmanaged API documentation](http://msdn.microsoft.com/en-us/library/dd316687.aspx))
 
## Method Return Value
A bool value which is true if the area filled by the geometry contains point; otherwise, false.
 
## Syntax
<PathGeometry>.FillContainsPoint(Vector2 point)
## Parameters

| point | The [SharpDX.Vector2](sharpdx_vector2-1.md) point to test. |
| --- | --- |
