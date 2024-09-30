
NinjaScript \> Language Reference \> Common \> Charts \> Rendering \> DirectWriteFactory
DirectWriteFactory

| \<\< [Click to Display Table of Contents](directwritefactory.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Charts](chart.md) \> [Rendering](rendering.md) \> DirectWriteFactory | [Previous page](d2dfactory.md) [Return to chapter overview](rendering.md) [Next page](dxextensions.md) |
| --- | --- |

## Definition
Provides an default DirectWrite factory used for creating [SharpDX.DirectWrite](sharpdx_directwrite.md) components.
 
## Property Value
A read\-only SharpDX.DirectWrite.Factory used to create DirectWrite objects compatible with NinjaTrader rendering
 
## Syntax
NinjaTrader.Core.Globals.DirectWriteFactory
 
| ns |
| --- |
| // create a text format object with default NinjaTrader DirectWrite factory SharpDX.DirectWrite.TextFormat textFormat \= new SharpDX.DirectWrite.TextFormat(NinjaTrader.Core.Globals.DirectWriteFactory,     "Arial", 12f);   // create a text layout object with default NinjaTrader DirectWrite factory SharpDX.DirectWrite.TextLayout textLayout \= new SharpDX.DirectWrite.TextLayout(NinjaTrader.Core.Globals.DirectWriteFactory,     "text to render", textFormat, ChartPanel.W, ChartPanel.H); |

