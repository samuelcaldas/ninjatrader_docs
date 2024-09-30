
NinjaScript > SharpDX SDK Reference > SharpDX.Direct2D1 > PathGeometry > Open()

SharpDX.Direct2D1.PathGeometry.Open()

| << [Click to Display Table of Contents](sharpdx_direct2d1_pathgeometry_open.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [SharpDX SDK Reference](sharpdx_sdk_reference.md) > [SharpDX.Direct2D1](sharpdx_direct2d1.md) > [PathGeometry](sharpdx_direct2d1_pathgeometry.md) > SharpDX.Direct2D1.PathGeometry.Open() | [Previous page](sharpdx_direct2d1_pathgeometry_getbounds.md) [Return to chapter overview](sharpdx_direct2d1_pathgeometry.md) [Next page](sharpdx_direct2d1_pathgeometry_segmentcount.md) |
| --- | --- |

| Disclaimer: The [SharpDX SDK Reference](sharpdx_sdk_reference.md) section was compiled from the official [SharpDX Documentation](http://sharpdx.org/) and was NOT authored by NinjaTrader.  The contents of this section are provided as-is and only cover a fraction of what is available from the SharpDX SDK.  This page was intended only as a reference guide to help you get started with some of the 2D Graphics concepts used in the NinjaTrader.Custom assembly.  Please refer to the official SharpDX Documentation for additional members not covered in this reference.  For more seasoned graphic developers, the original MSDN [Direct2D1](https://msdn.microsoft.com/en-us/library/windows/desktop/dd370990.aspx) and [DirectWrite](https://msdn.microsoft.com/en-us/library/windows/desktop/dd368038.aspx) unmanaged API documentation can also be helpful for understanding the DirectX/Direct2D run-time environment. For NinjaScript development purposes, we document only essential members in the structure of this page. |
| --- |

## Definition
Retrieves the geometry sink that is used to populate the path geometry with figures and segments. 
(See also [unmanaged API documentation](http://msdn.microsoft.com/en-us/library/dd371522.aspx))
 

| Notes: 1.Because path geometries are immutable and can only be populated once, it is an error to call Open() on a path geometry more than once.2.Note that the fill mode defaults to Alternate. To set the fill mode, call [SetFillMode()](sharpdx_direct2d1_geometrysink_setfillmode.md) before the first call to [BeginFigure()](sharpdx_direct2d1_geometrysink_addlines.md). Failure to do so will put the geometry sink in an error state. |
| --- |

## Method Return Value
A [SharpDX.Direct2D1.GeometrySink](sharpdx_direct2d1_geometrysink.md) which contains the address of a reference to the geometry sink that is used to populate the path geometry with figures and segments.
 
## Syntax
<PathGeometry>.Open()
## Parameters
This method does not accept any parameters
