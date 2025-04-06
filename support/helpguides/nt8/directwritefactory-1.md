



DirectWriteFactory

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\directwritefactory.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [Charts](chart-1.htm) > [Rendering](rendering-1.htm) >  DirectWriteFactory | [Previous page](d2dfactory-1.htm) [Return to chapter overview](rendering-1.htm) [Next page](dxextensions-1.htm) |

Definition
----------

Provides an default DirectWrite factory used for creating [SharpDX.DirectWrite](sharpdx_directwrite-1.htm) components.

Property Value
--------------

A read-only SharpDX.DirectWrite.Factory used to create DirectWrite objects compatible with NinjaTrader rendering

Syntax
------

NinjaTrader.Core.Globals.DirectWriteFactory

 

| ns |
| --- |
| // create a text format object with default NinjaTrader DirectWrite factory  SharpDX.DirectWrite.TextFormat textFormat = new SharpDX.DirectWrite.TextFormat(NinjaTrader.Core.Globals.DirectWriteFactory,      "Arial", 12f);     // create a text layout object with default NinjaTrader DirectWrite factory  SharpDX.DirectWrite.TextLayout textLayout = new SharpDX.DirectWrite.TextLayout(NinjaTrader.Core.Globals.DirectWriteFactory,      "text to render", textFormat, ChartPanel.W, ChartPanel.H); |