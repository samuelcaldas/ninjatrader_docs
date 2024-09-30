
NinjaScript > SharpDX SDK Reference > SharpDX.Direct2D1 > RenderTarget
SharpDX.Direct2D1.RenderTarget
| << [Click to Display Table of Contents](sharpdx_direct2d1_rendertarget.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [SharpDX SDK Reference](sharpdx_sdk_reference-1.md) > [SharpDX.Direct2D1](sharpdx_direct2d1-1.md) > SharpDX.Direct2D1.RenderTarget | [Previous page](sharpdx_direct2d1_radialgradientbrushproperties-1.md) [Return to chapter overview](sharpdx_direct2d1-1.md) [Next page](sharpdx_direct2d1_rendertarget_antialiasmode-1.md) |
| --- | --- |
| Disclaimer: The [SharpDX SDK Reference](sharpdx_sdk_reference-1.md) section was compiled from the official [SharpDX Documentation](http://sharpdx.org/) and was NOT authored by NinjaTrader.  The contents of this section are provided as-is and only cover a fraction of what is available from the SharpDX SDK.  This page was intended only as a reference guide to help you get started with some of the 2D Graphics concepts used in the NinjaTrader.Custom assembly.  Please refer to the official SharpDX Documentation for additional members not covered in this reference.  For more seasoned graphic developers, the original MSDN [Direct2D1](https://msdn.microsoft.com/en-us/library/windows/desktop/dd370990.aspx) and [DirectWrite](https://msdn.microsoft.com/en-us/library/windows/desktop/dd368038.aspx) unmanaged API documentation can also be helpful for understanding the DirectX/Direct2D run-time environment. For NinjaScript development purposes, we document only essential members in the structure of this page. |
| --- |

## Definition
Represents an object that can receive drawing commands. 
(See also [unmanaged API documentation](http://msdn.microsoft.com/en-us/library/dd371766.aspx))
 
## Syntax
class RenderTarget
 
| Tips:   1.For NinjaScript Development purposes, [DrawingTools](drawingtool-1.md), [ChartStyles](chartstyletype-1.md), [Indicators](indicators-1.md), and [Strategies](strategy-1.md) implement the Chart's [RenderTarget](rendertarget-1.md) ready to be used in the OnRender() method2.General information on Direct2D Render Targets can be found on the [MSDN Direct2D Render Targets Overview](https://msdn.microsoft.com/en-us/library/dd756757(v=vs.85).aspx) |
| --- |

## 
## 
## Methods and Properties
| [AntialiasMode](sharpdx_direct2d1_rendertarget_antialiasmode-1.md) | Retrieves or sets the current antialiasing mode for nontext drawing operations. |
| --- | --- |
| [DrawEllipse()](sharpdx_direct2d1_rendertarget_drawellipse-1.md) | Draws the outline of the specified ellipse using the specified stroke style. |
| [DrawGeometry()](sharpdx_direct2d1_rendertarget_drawgeometry-1.md) | Draws the outline of the specified geometry. |
| [DrawLine()](sharpdx_direct2d1_rendertarget_drawline-1.md) | Draws a line between the specified points. |
| [DrawRectangle()](sharpdx_direct2d1_rendertarget_drawrectangle-1.md) | Draws the outline of a rectangle that has the specified dimensions. |
| [DrawText()](sharpdx_direct2d1_rendertarget_drawtext-1.md) | Draws the specified text using the format information provided by an [SharpDX.DirectWrite.TextFormat](sharpdx_directwrite_textformat-1.md) object. |
| [DrawTextLayout()](sharpdx_direct2d1_rendertarget_drawtextlayout-1.md) | Draws the formatted text described by the specified [SharpDX.DirectWrite.TextLayout](sharpdx_directwrite_textlayout-1.md) object. |
| [FillEllipse()](sharpdx_direct2d1_rendertarget_fillellipse-1.md) | Paints the interior of the specified ellipse. |
| [FillGeometry()](sharpdx_direct2d1_rendertarget_fillgeometry-1.md) | Paints the interior of the specified geometry. |
| [FillRectangle()](sharpdx_direct2d1_rendertarget_fillrectangle-1.md) | Paints the interior of the specified rectangle. |
| [IsDisposed](sharpdx_disposebase_isdisposed-1.md) | Gets a value indicating whether this instance is disposed.  (Inherited from [SharpDX.DisposeBase](sharpdx_disposebase-1.md).) |
| [Transform](sharpdx_direct2d1_rendertarget_transform-1.md) | Gets or sets the current transform of the render target. |
