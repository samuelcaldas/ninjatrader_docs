
NinjaScript > Language Reference > Common > Charts > ChartControl > BarWidthArray

BarWidthArray
| << [Click to Display Table of Contents](barwidtharray.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > [Charts](chart.md) > [ChartControl](chartcontrol.md) > BarWidthArray | [Previous page](chartcontrol_barwidth.md) [Return to chapter overview](chartcontrol.md) [Next page](canvasleft.md) |
| --- | --- |
## Definition
An array containing the values of the [BarWidth](chartcontrol_barwidth.md) properties of all Bars objects applied to the chart.
## 
## Property Value
An array of double variables containing the values of the BarWidth properties of Bars objects on the chart.
## 
## Syntax
<ChartControl>.BarWidthArray[]
## 
## Examples
| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale) {    // Assign BarWidthArray to a new array    double[] barWidths = chartControl.BarWidthArray;      double referenceWidth = barWidths[0];      // Trigger an alert if bar widths on the chart differ    foreach (double width in barWidths)    {        if (width != referenceWidth)            Alert("mismatchWidths", Priority.Low, "Bar widths on the chart do not match!", " ", 20, Brushes.White, Brushes.Black);    } } |
