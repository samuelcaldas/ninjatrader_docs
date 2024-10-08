﻿
NinjaScript > SharpDX SDK Reference > SharpDX.Direct2D1 > RadialGradientBrushProperties

SharpDX.Direct2D1.RadialGradientBrushProperties

| << [Click to Display Table of Contents](sharpdx_direct2d1_radialgradientbrushproperties.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [SharpDX SDK Reference](sharpdx_sdk_reference.md) > [SharpDX.Direct2D1](sharpdx_direct2d1.md) > SharpDX.Direct2D1.RadialGradientBrushProperties | [Previous page](sharpdx_direct2d1_radialgradientbrush_radiusy.md) [Return to chapter overview](sharpdx_direct2d1.md) [Next page](sharpdx_direct2d1_rendertarget.md) |
| --- | --- |

| Disclaimer: The [SharpDX SDK Reference](sharpdx_sdk_reference.md) section was compiled from the official [SharpDX Documentation](http://sharpdx.org/) and was NOT authored by NinjaTrader.  The contents of this section are provided as-is and only cover a fraction of what is available from the SharpDX SDK.  This page was intended only as a reference guide to help you get started with some of the 2D Graphics concepts used in the NinjaTrader.Custom assembly.  Please refer to the official SharpDX Documentation for additional members not covered in this reference.  For more seasoned graphic developers, the original MSDN [Direct2D1](https://msdn.microsoft.com/en-us/library/windows/desktop/dd370990.aspx) and [DirectWrite](https://msdn.microsoft.com/en-us/library/windows/desktop/dd368038.aspx) unmanaged API documentation can also be helpful for understanding the DirectX/Direct2D run-time environment. For NinjaScript development purposes, we document only essential members in the structure of this page. |
| --- |

## Definition
Contains the gradient origin offset and the size and position of the gradient ellipse for an RadialGradientBrush. 
(See also [unmanaged API documentation](http://msdn.microsoft.com/en-us/library/dd368149.aspx))
 
## Syntax
struct RadialGradientBrushProperties
   

Constructors

| new RadialGradientBrushProperties() | Initializes a new instance of the RadialGradientBrushProperties structure |
| --- | --- |
## 
## 
Properties

| Center | A [SharpDX.Vector2](sharpdx_vector2.md) representing the brush's coordinate space, the center of the gradient ellipse. |
| --- | --- |
| GradientOriginOffset | A [SharpDX.Vector2](sharpdx_vector2.md) representing brush's coordinate space, the offset of the gradient origin relative to the gradient ellipse's center. |
| RadiusX | A float in the brush's coordinate space, the x-radius of the gradient ellipse. |
| RadiusY | A float in the brush's coordinate space, the y-radius of the gradient ellipse. |
