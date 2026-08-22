# ToDirectWriteTextFormat()

## Definition

Converts a [SimpleFont](../language_reference/simplefont_class.md) object to a [SharpDX](sharpdx.md) compatible font which can be used for chart rendering.

 

> **Note:** For more information please see the educational resource on [Using SharpDX for Custom Chart Rendering](using_sharpdx_for_custom_chart_rendering.md)

## Method Return Value

## A [DirectWrite.TextFormat](sharpdx_directwrite_textformat.md) object

> **Warning:** The returned DirectWrite.TextFormat object should be disposed of immediately when finished drawing text.

## Syntax

<SimpleFont>.ToDirectWriteTextFormat()

 

## Examples

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
    // Set text to chart label simple font object
    SharpDX.DirectWrite.TextFormat textFormat = chartControl.Properties.LabelFont.ToDirectWriteTextFormat();
    // use the textFormat in a RenderTarget.DrawText() or DrawTextLayout() method
    // do not forget to dispose text format when finished
    textFormat.Dispose();
}
```
