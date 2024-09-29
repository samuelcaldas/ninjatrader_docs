


NinjaScript \> Language Reference \> Drawing Tool \> GetSelectionPoints()






















GetSelectionPoints()







| \<\< [Click to Display Table of Contents](getselectionpoints.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Drawing Tool](drawing_tools.md) \> GetSelectionPoints() | [Previous page](getcursor.md) [Return to chapter overview](drawing_tools.md) [Next page](icon_drawingtool.md) |
| --- | --- |











## Definition


Returns the chart object's data points where the user can interact.   These points are used to visually indicate that the chart object is selected and allow the user to manipulate the chart object.  This method is only called when [IsSelected](isselected.md) is set to true.


 


## Method Return Value


A collection of [Points](https://msdn.microsoft.com/en-us/library/system.drawing.point%28v=vs.110%29.aspx) representing the x\- and y\-coordinates of the chart object. 


## 


## Syntax
You must override the method using the following syntax:


public override Point\[] GetSelectionPoints(ChartControl chartControl, ChartScale chartScale)  

{  

   

}


## 


## Method Parameters




| chartControl | A [ChartControl](chartcontrol.md) representing the x\-axis |
| --- | --- |
| chartScale | A [ChartScale](chartscale.md) representing the y\-axis |



## 


## 


## Examples




| ns |
| --- |
| public override Point\[] GetSelectionPoints(ChartControl chartControl, ChartScale chartScale) {            ChartPanel chartPanel \= chartControl.ChartPanels\[chartScale.PanelIndex];                   // get the anchor point to be displayed on the drawing tool  Point anchorPoint \= Anchor.GetPoint(chartControl, chartPanel, chartScale, false);          return new\[] { anchorPoint } ; } |









