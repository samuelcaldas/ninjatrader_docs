﻿
NinjaScript > SharpDX SDK Reference > SharpDX.Direct2D1 > StrokeStyle > DashStyle

SharpDX.Direct2D1.StrokeStyle.DashStyle

| << [Click to Display Table of Contents](sharpdx_direct2d1_strokestyle_dashstyle.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [SharpDX SDK Reference](sharpdx_sdk_reference-1.md) > [SharpDX.Direct2D1](sharpdx_direct2d1-1.md) > [StrokeStyle](sharpdx_direct2d1_strokestyle-1.md) > SharpDX.Direct2D1.StrokeStyle.DashStyle | [Previous page](sharpdx_direct2d1_strokestyle_dashoffset-1.md) [Return to chapter overview](sharpdx_direct2d1_strokestyle-1.md) [Next page](sharpdx_direct2d1_strokestyle_endcap-1.md) |
| --- | --- |

| Disclaimer: The [SharpDX SDK Reference](sharpdx_sdk_reference-1.md) section was compiled from the official [SharpDX Documentation](http://sharpdx.org/) and was NOT authored by NinjaTrader.  The contents of this section are provided as-is and only cover a fraction of what is available from the SharpDX SDK.  This page was intended only as a reference guide to help you get started with some of the 2D Graphics concepts used in the NinjaTrader.Custom assembly.  Please refer to the official SharpDX Documentation for additional members not covered in this reference.  For more seasoned graphic developers, the original MSDN [Direct2D1](https://msdn.microsoft.com/en-us/library/windows/desktop/dd370990.aspx) and [DirectWrite](https://msdn.microsoft.com/en-us/library/windows/desktop/dd368038.aspx) unmanaged API documentation can also be helpful for understanding the DirectX/Direct2D run-time environment. For NinjaScript development purposes, we document only essential members in the structure of this page. |
| --- |

## Definition
Gets a value that describes the stroke's dash pattern. 
(See also [unmanaged API documentation](http://msdn.microsoft.com/en-us/library/dd372217.aspx))
 

| Note: If a custom dash style is specified, the dash pattern is described by the dashes array, which can be retrieved by calling the [GetDashes()](sharpdx_direct2d1_strokestyle_getdashes-1.md) method. |
| --- |

## Property Value
A SharpDX.Direct2D1.DashStyle enum value that describes the predefined dash pattern used, or DashStyle.Custom if a custom dash style is used.
 
Possible Values are:

| Solid | A solid line with no breaks. |
| --- | --- |
| Dash | A dash followed by a gap of equal length. The dash and the gap are each twice as long as the stroke thickness.  The equivalent dash array for Dash is {2, 2}. |
| Dot | A dot followed by a longer gap. The equivalent dash array for Dot is {0, 2}. |
| DashDot | A dash, followed by a gap, followed by a dot, followed by another gap. The equivalent dash array for DashDot is {2, 2, 0, 2}. |
| DashDotDot | A dash, followed by a gap, followed by a dot, followed by another gap, followed by another dot, followed by another gap. The equivalent dash array for DashDotDot is {2, 2, 0, 2, 0, 2}. |
| Custom | The dash pattern is specified by an array of floating-point values. |
(See also [unmanaged API documentation](http://msdn.microsoft.com/en-us/library/dd368087.aspx))
 
## Syntax
<StrokeStyle>.DashStyle
## 
## 
