# BarWidth

## Definition

Measures the value of the [bar width](../drawing_tools/barwidth.md) set for the primary Bars object on the chart.

> **Note:** This property value is not stated in pixels. To obtain the pixel-width of bars on the chart, use [GetBarPaintWidth(](chartcontrol_getbarpaintwidth.md)) instead.

## Property Value

A double representing the value of the bar width.

## Syntax

<ChartControl>.BarWidth

## Examples

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
    double barWidth = chartControl.BarWidth;
    // Prints the width of bars on the chart
    Print(barWidth);
}
```

 

 

Based on the image below, BarWidth reveals that the bars on the chart are 4.02 pixels wide.

![ChartControl_BarWidth](../images/chartcontrol_barwidth.png)
