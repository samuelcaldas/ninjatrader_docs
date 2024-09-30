
NinjaScript > Language Reference > Common > Charts > Rendering > D2DFactory

D2DFactory
| << [Click to Display Table of Contents](d2dfactory.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > [Charts](chart.md) > [Rendering](rendering.md) > D2DFactory | [Previous page](rendering.md) [Return to chapter overview](rendering.md) [Next page](directwritefactory.md) |
| --- | --- |
## Definition
Provides a default Direct2D1 factory used for creating [SharpDX.Direct2D1](sharpdx_direct2d1.md) components.
 
## Property Value
A read-only SharpDX.Direct2D1.Factory to create Direct2D1 objects compatible with NinjaTrader rendering
 
## Syntax
NinjaTrader.Core.Globals.D2DFactory
 
| Warning: Please ensure this property would only be accessed from [OnRender()](onrender.md) or [OnRenderTargetChanged()](onrendertargetchanged.md) (which run in the UI thread), as access from other threads outside those methods could cause a degradation in performance. |
| --- |

## 
 
| ns |
| --- |
| // create a Direct2D1 PathGeometry format object with default NinjaTrader D2DFactory factory SharpDX.Direct2D1.PathGeometry pathGeometry = new SharpDX.Direct2D1.PathGeometry(NinjaTrader.Core.Globals.D2DFactory); |
