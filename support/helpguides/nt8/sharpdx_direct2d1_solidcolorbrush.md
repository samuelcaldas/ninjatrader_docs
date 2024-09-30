
NinjaScript > SharpDX SDK Reference > SharpDX.Direct2D1 > SolidColorBrush

SharpDX.Direct2D1.SolidColorBrush

| << [Click to Display Table of Contents](sharpdx_direct2d1_solidcolorbrush.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [SharpDX SDK Reference](sharpdx_sdk_reference.md) > [SharpDX.Direct2D1](sharpdx_direct2d1.md) > SharpDX.Direct2D1.SolidColorBrush | [Previous page](sharpdx_direct2d1_rendertarget_transform.md) [Return to chapter overview](sharpdx_direct2d1.md) [Next page](sharpdx_direct2d1_solidcolorbrush_color.md) |
| --- | --- |

| Disclaimer: The [SharpDX SDK Reference](sharpdx_sdk_reference.md) section was compiled from the official [SharpDX Documentation](http://sharpdx.org/) and was NOT authored by NinjaTrader.  The contents of this section are provided as-is and only cover a fraction of what is available from the SharpDX SDK.  This page was intended only as a reference guide to help you get started with some of the 2D Graphics concepts used in the NinjaTrader.Custom assembly.  Please refer to the official SharpDX Documentation for additional members not covered in this reference.  For more seasoned graphic developers, the original MSDN [Direct2D1](https://msdn.microsoft.com/en-us/library/windows/desktop/dd370990.aspx) and [DirectWrite](https://msdn.microsoft.com/en-us/library/windows/desktop/dd368038.aspx) unmanaged API documentation can also be helpful for understanding the DirectX/Direct2D run-time environment. For NinjaScript development purposes, we document only essential members in the structure of this page. |
| --- |

## Definition
Paints an area with a solid color.
(See also [unmanaged API documentation](http://msdn.microsoft.com/en-us/library/dd372207.aspx))
 

| Notes:  1.The SolidColorBrush can only be used with the render target that created it or with the compatible targets for that render target. 2.A SolidColorBrush is a device-dependent resource.  Please see the [MSDN Direct2D Resources Overview](https://msdn.microsoft.com/en-us/library/dd756757(v=vs.85).aspx) for more information.3.For convenience, Direct2D provides the [BrushProperties](sharpdx_direct2d1_brushproperties.md) function for creating new a SolidColorBrush. |
| --- |

## Syntax
class SolidColorBrush
 

| Tips:   1.For NinjaScript Development purposes, you can use the [NinjaTrader.Gui.DxExtensions.ToDxBrush()](dxextensions_todxbrush.md) helper method to convert a System.Windows.Media.SolidColorBrush to a SharpDX.Direct2D1.SolidColorBrush 2.General information on Direct2D brushes can be found on the [MSDN Direct2D Brushes Overview](https://msdn.microsoft.com/en-us/library/dd756651(v=vs.85).aspx) |
| --- |
## 
## Constructors

| new SolidColorBrush(RenderTarget renderTarget, Color4 color) | Creates a new SolidColorBrush that has the specified color and opacity. |
| --- | --- |
| new SolidColorBrush(RenderTarget renderTarget, Color4 color, Nullable<BrushProperties> brushProperties) | Creates a new SolidColorBrush that has the specified color and opacity. |
## 
## 
## Methods and Properties

| [Color](sharpdx_direct2d1_solidcolorbrush_color.md) | Retrieves or sets the color of the solid color brush. |
| --- | --- |
| [Dispose()](sharpdx_disposebase_dispose.md) | Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources. (Inherited from [SharpDX.DisposeBase](sharpdx_disposebase.md).) |
| [IsDisposed](sharpdx_disposebase_isdisposed.md) | Gets a value indicating whether this instance is disposed. (Inherited from [SharpDX.DisposeBase](sharpdx_disposebase.md).) |
| [Opacity](sharpdx_direct2d1_brush_opacity.md) | Gets or sets the degree of opacity of this brush.  (Inherited from [Brush](sharpdx_direct2d1_brush.md).) |
| [Transform](sharpdx_direct2d1_brush_transform.md) | Gets or sets the transform applied to this brush.  (Inherited from [Brush](sharpdx_direct2d1_brush.md).) |
