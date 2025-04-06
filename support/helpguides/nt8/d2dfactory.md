



D2DFactory

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](d2dfactory.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Common](common.htm) > [Charts](chart.htm) > [Rendering](rendering.htm) >  D2DFactory | [Previous page](rendering.htm) [Return to chapter overview](rendering.htm) [Next page](directwritefactory.htm) |

Definition
----------

Provides a default Direct2D1 factory used for creating [SharpDX.Direct2D1](sharpdx_direct2d1.htm) components.

Property Value
--------------

A read-only SharpDX.Direct2D1.Factory to create Direct2D1 objects compatible with NinjaTrader rendering

Syntax
------

NinjaTrader.Core.Globals.D2DFactory

 

|  |
| --- |
| Warning: Please ensure this property would only be accessed from [OnRender()](onrender.htm) or [OnRenderTargetChanged()](onrendertargetchanged.htm) (which run in the UI thread), as access from other threads outside those methods could cause a degradation in performance. |

 

| ns |
| --- |
| // create a Direct2D1 PathGeometry format object with default NinjaTrader D2DFactory factory  SharpDX.Direct2D1.PathGeometry pathGeometry = new SharpDX.Direct2D1.PathGeometry(NinjaTrader.Core.Globals.D2DFactory); |