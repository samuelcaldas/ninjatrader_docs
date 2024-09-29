


NinjaScript \> Language Reference \> Common \> Charts \> Rendering \> DirectWriteFactory






















DirectWriteFactory







| \<\< [Click to Display Table of Contents](directwritefactory.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [Charts](chart-1.md) \> [Rendering](rendering-1.md) \> DirectWriteFactory | [Previous page](d2dfactory-1.md) [Return to chapter overview](rendering-1.md) [Next page](dxextensions-1.md) |
| --- | --- |











## Definition


Provides an default DirectWrite factory used for creating [SharpDX.DirectWrite](sharpdx_directwrite-1.md) components.


 


## Property Value


A read\-only SharpDX.DirectWrite.Factory used to create DirectWrite objects compatible with NinjaTrader rendering


 


## Syntax


NinjaTrader.Core.Globals.DirectWriteFactory


 




| ns |
| --- |
| // create a text format object with default NinjaTrader DirectWrite factory SharpDX.DirectWrite.TextFormat textFormat \= new SharpDX.DirectWrite.TextFormat(NinjaTrader.Core.Globals.DirectWriteFactory,     "Arial", 12f);   // create a text layout object with default NinjaTrader DirectWrite factory SharpDX.DirectWrite.TextLayout textLayout \= new SharpDX.DirectWrite.TextLayout(NinjaTrader.Core.Globals.DirectWriteFactory,     "text to render", textFormat, ChartPanel.W, ChartPanel.H); |









