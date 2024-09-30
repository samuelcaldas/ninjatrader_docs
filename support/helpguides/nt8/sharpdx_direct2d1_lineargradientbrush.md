
NinjaScript > SharpDX SDK Reference > SharpDX.Direct2D1 > LinearGradientBrush

SharpDX.Direct2D1.LinearGradientBrush

| << [Click to Display Table of Contents](sharpdx_direct2d1_lineargradientbrush.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [SharpDX SDK Reference](sharpdx_sdk_reference.md) > [SharpDX.Direct2D1](sharpdx_direct2d1.md) > SharpDX.Direct2D1.LinearGradientBrush | [Previous page](sharpdx_direct2d1_gradientstopcollection_gradientstopcount.md) [Return to chapter overview](sharpdx_direct2d1.md) [Next page](sharpdx_direct2d1_lineargradientbrush_endpoint.md) |
| --- | --- |

| Disclaimer: The [SharpDX SDK Reference](sharpdx_sdk_reference.md) section was compiled from the official [SharpDX Documentation](http://sharpdx.org/) and was NOT authored by NinjaTrader.  The contents of this section are provided as-is and only cover a fraction of what is available from the SharpDX SDK.  This page was intended only as a reference guide to help you get started with some of the 2D Graphics concepts used in the NinjaTrader.Custom assembly.  Please refer to the official SharpDX Documentation for additional members not covered in this reference.  For more seasoned graphic developers, the original MSDN [Direct2D1](https://msdn.microsoft.com/en-us/library/windows/desktop/dd370990.aspx) and [DirectWrite](https://msdn.microsoft.com/en-us/library/windows/desktop/dd368038.aspx) unmanaged API documentation can also be helpful for understanding the DirectX/Direct2D run-time environment. For NinjaScript development purposes, we document only essential members in the structure of this page. |
| --- |

## Definition
Paints an area with a linear gradient. 
(See also [unmanaged API documentation](http://msdn.microsoft.com/en-us/library/dd371488.aspx))
 

| Notes:  1.An LinearGradientBrush paints an area with a linear gradient along a line between the brush start point and end point. The gradient, defined by the brush [GradientStopCollection](sharpdx_direct2d1_lineargradientbrush_gradientstopcollection.md), is extruded perpendicular to this line, and then transformed by a brush [transform](sharpdx_direct2d1_brush_transform.md) (if specified).2.The start point and end point are described in the brush space and are mappped to the render target when the brush is used. Note the starting and ending coordinates are absolute, not relative to the render target size. A value of (0, 0) maps to the upper-left corner of the render target, while a value of (1, 1) maps one pixel diagonally away from (0, 0). If there is a nonidentity [brush transform](sharpdx_direct2d1_brush_transform.md) or [render target transform](sharpdx_direct2d1_rendertarget_transform.md), the brush [start point](sharpdx_direct2d1_lineargradientbrush_startpoint.md) and [end point](sharpdx_direct2d1_lineargradientbrush_endpoint.md) are also transformed.3.It is possible to specify a gradient axis that does not completely fill the area that is being painted. When this occurs, the ExtendMode, specified by the [GradientStopCollection](sharpdx_direct2d1_lineargradientbrush_gradientstopcollection.md), determines how the remaining area is painted.4.The LinearGradientBrush can only be used with the [render target](sharpdx_direct2d1_rendertarget.md) that created it or with the compatible targets for that render target.5.A LinearGradientBrush is a device-dependent resource: your application should create linear gradient brushes after it initializes the render target with which the brushes will be used, and recreate the brushes whenever the render target needs recreated.  Please see the [MSDN Direct2D Resources Overview](https://msdn.microsoft.com/en-us/library/dd756757(v=vs.85).aspx) for more information.6.For convenience, Direct2D provides the [RadialGradientBrushProperties](sharpdx_direct2d1_lineargradientbrushproperties.md) function for creating new a LinearGradientBrush. |
| --- |

## Syntax
class SolidColorBrush
 

| Tips:   1.For NinjaScript Development purposes, you can use the [NinjaTrader.Gui.DxExtensions.ToDxBrush()](dxextensions_todxbrush.md) helper method to convert a System.Windows.Media.LinearGradientBrush to a SharpDX.Direct2D1.LinearGradientBrush 2.General information on Direct2D brushes can be found on the [MSDN Direct2D Brushes Overview](https://msdn.microsoft.com/en-us/library/dd756651(v=vs.85).aspx) |
| --- |
## 
## Constructors

| new LinearGradientBrush([RenderTarget](sharpdx_direct2d1_rendertarget.md) renderTarget, [LinearGradientBrushProperties](sharpdx_direct2d1_lineargradientbrushproperties.md) linearGradientBrushProperties, [GradientStopCollection](sharpdx_direct2d1_gradientstopcollection.md) gradientStopCollection) | Creates an LinearGradientBrush that contains the specified gradient stops and has the specified transform and base opacity. |
| --- | --- |
| new LinearGradientBrush([RenderTarget](sharpdx_direct2d1_rendertarget.md) renderTarget, [LinearGradientBrushProperties](sharpdx_direct2d1_lineargradientbrushproperties.md) linearGradientBrushProperties, Nullable<[BrushProperties](sharpdx_direct2d1_brushproperties.md)> brushProperties, [GradientStopCollection](sharpdx_direct2d1_gradientstopcollection.md) gradientStopCollection) | Creates an LinearGradientBrush that contains the specified gradient stops and has the specified transform and base opacity. |
## 
## 
## Methods and Properties

| [Dispose()](sharpdx_disposebase_dispose.md) | Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources. (Inherited from [SharpDX.DisposeBase](sharpdx_disposebase.md).) |
| --- | --- |
| [EndPoint](sharpdx_direct2d1_lineargradientbrush_endpoint.md) | Retrieves or sets the ending coordinates of the linear gradient. |
| [GradientStopCollection](sharpdx_direct2d1_lineargradientbrush_gradientstopcollection.md) | Retrieves the GradientStopCollection associated with this linear gradient brush. |
| [IsDisposed](sharpdx_disposebase_isdisposed.md) | Gets a value indicating whether this instance is disposed. (Inherited from [SharpDX.DisposeBase](sharpdx_disposebase.md).) |
| [Opacity](sharpdx_direct2d1_brush_opacity.md) | Gets or sets the degree of opacity of this brush.  (Inherited from [Brush](sharpdx_direct2d1_brush.md).) |
| [StartPoint](sharpdx_direct2d1_lineargradientbrush_startpoint.md) | Retrieves or sets the starting coordinates of the linear gradient. |
| [Transform](sharpdx_direct2d1_brush_transform.md) | Gets or sets the transform applied to this brush.  (Inherited from [Brush](sharpdx_direct2d1_brush.md).) |
