# LastSlotPainted

## Definition

Indicates the most recent (last) slot index of the Data Series on the chart, regardless if a bar is actually painted in that slot.

> **Note:** LastSlotPainted differs from [[[ChartBars.ToIndex](chartbars_toindex.md), which returns the last index containing a bar painted in the visible area of the chart.

## Property Value

A int representing the most recent (last) slot index on the chart

## Syntax

<ChartControl>.LastSlotPainted

## Example

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
    int lastSlot = chartControl.LastSlotPainted;
    // Print the index of the last slot on the chart
    Print(lastSlot);
}
```
