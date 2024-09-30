
NinjaScript > SharpDX SDK Reference > SharpDX.Direct2D1 > GradientStopCollection 

SharpDX.Direct2D1.GradientStopCollection

| << [Click to Display Table of Contents](sharpdx_direct2d1_gradientstopcollection.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [SharpDX SDK Reference](sharpdx_sdk_reference.md) > [SharpDX.Direct2D1](sharpdx_direct2d1.md) > SharpDX.Direct2D1.GradientStopCollection | [Previous page](sharpdx_direct2d1_gradientstop.md) [Return to chapter overview](sharpdx_direct2d1.md) [Next page](sharpdx_direct2d1_gradientstopcollection_colorinterpolationgamma.md) |
| --- | --- |

| Disclaimer: The [SharpDX SDK Reference](sharpdx_sdk_reference.md) section was compiled from the official [SharpDX Documentation](http://sharpdx.org/) and was NOT authored by NinjaTrader.  The contents of this section are provided as-is and only cover a fraction of what is available from the SharpDX SDK.  This page was intended only as a reference guide to help you get started with some of the 2D Graphics concepts used in the NinjaTrader.Custom assembly.  Please refer to the official SharpDX Documentation for additional members not covered in this reference.  For more seasoned graphic developers, the original MSDN [Direct2D1](https://msdn.microsoft.com/en-us/library/windows/desktop/dd370990.aspx) and [DirectWrite](https://msdn.microsoft.com/en-us/library/windows/desktop/dd368038.aspx) unmanaged API documentation can also be helpful for understanding the DirectX/Direct2D run-time environment. For NinjaScript development purposes, we document only essential members in the structure of this page. |
| --- |

## Definition
Describes an elliptical arc between two points.
(See also [unmanaged API documentation](http://msdn.microsoft.com/en-us/library/dd368065.aspx))
 

| Note:  A gradient stop collection is a device-dependent resource: your application should create gradient stop collections after it initializes the render target with which the gradient stop collection will be used, and recreate the gradient stop collection whenever the render target needs recreated. Please see the [MSDN Direct2D Resources Overview](https://msdn.microsoft.com/en-us/library/dd756757(v=vs.85).aspx) for more information. |
| --- |

## Syntax
class GradientStopCollection
 
## Constructors

| new GradientStopCollection([RenderTarget](sharpdx_direct2d1_rendertarget.md) renderTarget, [GradientStop](sharpdx_direct2d1_gradientstop.md)[] gradientStops) | Creates an GradientStopCollection from the specified gradient stops, a Gamma.StandardRgb, and ExtendMode.Clamp |
| --- | --- |
| new GradientStopCollection([RenderTarget](sharpdx_direct2d1_rendertarget.md) renderTarget, [GradientStop](sharpdx_direct2d1_gradientstop.md)[] gradientStops, [ExtendMode](sharpdx_direct2d1_gradientstopcollection_extendmode.md) extendMode) | Creates an GradientStopCollection from the specified gradient stops, color Gamma.StandardRgb, and extend mode |
| new GradientStopCollection([RenderTarget](sharpdx_direct2d1_rendertarget.md) renderTarget, [GradientStop](sharpdx_direct2d1_gradientstop.md)[] gradientStops, [Gamma](sharpdx_direct2d1_gradientstopcollection_colorinterpolationgamma.md) colorInterpolationGamma) | Creates an GradientStopCollection from the specified gradient stops, color interpolation gamma, and ExtendMode.Clamp |
| new GradientStopCollection([RenderTarget](sharpdx_direct2d1_rendertarget.md) renderTarget, [GradientStop](sharpdx_direct2d1_gradientstop.md)[] gradientStops, [Gamma](sharpdx_direct2d1_gradientstopcollection_colorinterpolationgamma.md) colorInterpolationGamma, [ExtendMode](sharpdx_direct2d1_gradientstopcollection_extendmode.md) extendMode) | Creates an GradientStopCollection from the specified gradient stops, color interpolation gamma, and extend mode |
   

 
## Methods and Properties

| [ColorInterpolationGamma](sharpdx_direct2d1_gradientstopcollection_colorinterpolationgamma.md) | Indicates the gamma space in which the gradient stops are interpolated |
| --- | --- |
| [Dispose()](sharpdx_disposebase_dispose.md) | Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources. (Inherited from [SharpDX.DisposeBase](sharpdx_disposebase.md).) |
| [ExtendMode](sharpdx_direct2d1_gradientstopcollection_extendmode.md) | Indicates the behavior of the gradient outside the normalized gradient range |
| [GradientStopCount](sharpdx_direct2d1_gradientstopcollection_gradientstopcount.md) | Retrieves the number of gradient stops in the collection |
| [IsDisposed](sharpdx_disposebase_isdisposed.md) | Gets a value indicating whether this instance is disposed.  (Inherited from [SharpDX.DisposeBase](sharpdx_disposebase.md).) |
