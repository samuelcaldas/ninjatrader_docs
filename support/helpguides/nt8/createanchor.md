


NinjaScript \> Language Reference \> Drawing Tool \> CreateAnchor()






















CreateAnchor()







| \<\< [Click to Display Table of Contents](createanchor.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Drawing Tool](drawing_tools.md) \> CreateAnchor() | [Previous page](converttoverticalpixels.md) [Return to chapter overview](drawing_tools.md) [Next page](displayonchartsmenus.md) |
| --- | --- |











## Definition


Used to create a new chart anchor at a specified mouse point.


 


## Method Return Value


A new [ChartAnchor](chartanchor.md) at a specified point in device pixels.


## 


## Syntax


CreateAnchor(Point point, ChartControl chartControl, ChartScale chartScale)   


## 


## Method Parameters




| point | A Point in device pixels representing the current mouse cursor position |
| --- | --- |
| chartControl | A ChartControl representing the x\-axis |
| chartScale | A ChartScale representing the y\-axis |



 


## 


## Examples




| ns |
| --- |
| public override void OnMouseDown(ChartControl chartControl, ChartPanel chartPanel, ChartScale chartScale, ChartAnchor dataPoint) {    // get the point where the mouse was clicked    Point myPoint \= dataPoint.GetPoint(chartControl, chartPanel, chartScale);        // create an anchor at that point    ChartAnchor MyAnchor \= CreateAnchor(myPoint, chartControl, chartScale);        Print(MyAnchor.Time); // 3/16/2015 8:18:48 AM } |









