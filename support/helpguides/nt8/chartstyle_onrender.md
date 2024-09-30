
NinjaScript > Language Reference > Chart Style > OnRender()

OnRender()
| << [Click to Display Table of Contents](chartstyle_onrender.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Chart Style](chart_style.md) > OnRender() | [Previous page](istransparent.md) [Return to chapter overview](chart_style.md) [Next page](setpropertyname.md) |
| --- | --- |
## Definition
An event driven method used to render content to a ChartStyle.  The OnRender() method is called every time the chart values are updated.  These updates are driven by incoming data to the chart bars or by a user manually interacting with the chart control or chart scale.
 
## Method Return Value
This method does not return a value.
 
## Syntax
You must override the method in your ChartStyle with the following syntax:
 
protected override void OnRender(ChartControl chartControl, ChartScale chartScale, ChartBars chartBars)  

{  

   

}
## 
## Method Parameters
| chartControl | A ChartControl representing the x-axis |
| --- | --- |
| chartScale | A ChartScale representing the y-axis |
| chartBars | A ChartBars representing the Bars series for the chart |

 
## 
## Examples
| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale, ChartBars chartBars) {      // Rendering logic for our chart style } |
