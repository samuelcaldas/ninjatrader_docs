
NinjaScript > Language Reference > Common > Charts > Rendering > ZOrder

ZOrder

| << [Click to Display Table of Contents](chart_zorder.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > [Charts](chart.md) > [Rendering](rendering.md) > ZOrder | [Previous page](setzorder.md) [Return to chapter overview](rendering.md) [Next page](formatpricemarker.md) |
| --- | --- |
## Definition
A unique identifier representing the index in which chart objects are drawn on the chart's Z-axis (front to back ordering). Objects with a higher ZOrder are drawn first.  
 

| Note:  The ZOrder index should NOT be set using this property. Please use the dedicated [SetZOrder()](setzorder.md) for this purpose. |
| --- |
 
## Property Value
A int value representing the order that the object is drawn.  Default value is categorized by the type of object drawn, which will then increment for each instance of the chart object that is drawn.  Each type of object will have a different default starting value to keep these objects separate:
 

| Chart Bars | 1 |
| --- | --- |
| NinjaScript Objects | 10001 |
| Global Draw Objects | 20001 |
| Draw Objects | 30001 |
 
## Syntax
ZOrder
 
## Examples

| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale) {    // call the base.OnRender() to ensure standard Plots work as designed    base.OnRender(chartControl, chartScale);      // Print the currently assigned ZOrder index for this NinjaScript object    Print("Current ZOrder level is: " + ZOrder); } |
