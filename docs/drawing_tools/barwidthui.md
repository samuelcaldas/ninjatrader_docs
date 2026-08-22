# BarWidthUI

## Definition

The Bar width value which displays on the UI.  This value will be rounded from the internal [[[BarWidth](barwidth.md) property which is updated as the ChartControl is resized

## Property Value

A int value representing the width of the chart bars which can be set by a user.

## Syntax

BarWidthUI

 

## Examples

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale, ChartBars chartBars)
{
    int barWidth = GetBarPaintWidth(BarWidthUI);
}
```
