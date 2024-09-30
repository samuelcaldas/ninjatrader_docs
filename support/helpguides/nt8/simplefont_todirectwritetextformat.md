
NinjaScript \> Language Reference \> Common \> SimpleFont \> ToDirectWriteTextFormat()

ToDirectWriteTextFormat()

| \<\< [Click to Display Table of Contents](simplefont_todirectwritetextformat.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [SimpleFont](simplefont_class.md) \> ToDirectWriteTextFormat() | [Previous page](simplefont_applyto.md) [Return to chapter overview](simplefont_class.md) [Next page](indicators.md) |
| --- | --- |
## Definition
Converts a [SimpleFont](simplefont_class.md) object to a [SharpDX](sharpdx.md) compatible font which can be used for chart rendering.
 

| Note:  For more information please see the educational resource on [Using SharpDX for Custom Chart Rendering](using_sharpdx_for_custom_chart_rendering.md) |
| --- |
## 
## 
## Method Return Value
## A [DirectWrite.TextFormat](sharpdx_directwrite_textformat.md) object
 

| Warning:  The returned DirectWrite.TextFormat object should be disposed of immediately when finished drawing text. |
| --- |

## Syntax
\<SimpleFont\>.ToDirectWriteTextFormat()

## Examples

| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale) {    // Set text to chart label simple font object    SharpDX.DirectWrite.TextFormat textFormat \= chartControl.Properties.LabelFont.ToDirectWriteTextFormat();      // use the textFormat in a RenderTarget.DrawText() or DrawTextLayout() method      // do not forget to dispose text format when finished    textFormat.Dispose(); } |
