﻿
NinjaScript > SharpDX SDK Reference > SharpDX.Direct2D1 > CapStyle

SharpDX.Direct2D1.CapStyle

| << [Click to Display Table of Contents](sharpdx_direct2d1_capstyle.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [SharpDX SDK Reference](sharpdx_sdk_reference.md) > [SharpDX.Direct2D1](sharpdx_direct2d1.md) > SharpDX.Direct2D1.CapStyle | [Previous page](sharpdx_direct2d1_brushproperties.md) [Return to chapter overview](sharpdx_direct2d1.md) [Next page](sharpdx_direct2d1_drawtextoptions.md) |
| --- | --- |

| Disclaimer: The [SharpDX SDK Reference](sharpdx_sdk_reference.md) section was compiled from the official [SharpDX Documentation](http://sharpdx.org/) and was NOT authored by NinjaTrader.  The contents of this section are provided as-is and only cover a fraction of what is available from the SharpDX SDK.  This page was intended only as a reference guide to help you get started with some of the 2D Graphics concepts used in the NinjaTrader.Custom assembly.  Please refer to the official SharpDX Documentation for additional members not covered in this reference.  For more seasoned graphic developers, the original MSDN [Direct2D1](https://msdn.microsoft.com/en-us/library/windows/desktop/dd370990.aspx) and [DirectWrite](https://msdn.microsoft.com/en-us/library/windows/desktop/dd368038.aspx) unmanaged API documentation can also be helpful for understanding the DirectX/Direct2D run-time environment. For NinjaScript development purposes, we document only essential members in the structure of this page. |
| --- |

## Definition
Describes the shape at the end of a line or segment.
(See also [unmanaged API documentation](http://msdn.microsoft.com/en-us/library/dd368079.aspx))
 
## Syntax
enum CapStyle
 
## Enumerators

| Flat | A cap that does not extend past the last point of the line. Comparable to cap used for objects other than lines. |
| --- | --- |
| Square | Half of a square that has a length equal to the line thickness. |
| Round | A semicircle that has a diameter equal to the line thickness. |
| Triangle | An isosceles right triangle whose hypotenuse is equal in length to the thickness of the line. |
 
