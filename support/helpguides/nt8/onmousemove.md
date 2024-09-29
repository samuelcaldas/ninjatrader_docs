


NinjaScript \> Language Reference \> Drawing Tool \> OnMouseMove()






















OnMouseMove()







| \<\< [Click to Display Table of Contents](onmousemove.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Drawing Tool](drawing_tools.md) \> OnMouseMove() | [Previous page](onmousedown.md) [Return to chapter overview](drawing_tools.md) [Next page](onmouseup.md) |
| --- | --- |











## Definition


An event driven method which is called any time the mouse pointer is over the chart control and a mouse is moving.


 


## Method Return Value


This method does not return a value.


 




| Note:  For a combined single click operation, i.e. mouse down click, move and release the dataPoint reported will always be the initial starting one. |
| --- |



 


## Syntax
You must override the method in your Drawing Tool with the following syntax.


   

public override void OnMouseMove(ChartControl chartControl, ChartPanel chartPanel, ChartScale chartScale, ChartAnchor dataPoint)  

{  

   

}


## 


## Method Parameters




| chartControl | A [ChartControl](chartcontrol.md) representing the x\-axis |
| --- | --- |
| chartPanel | A [ChartPanel](chartpanel.md) representing the the panel for the chart |
| chartScale | A [ChartScale](chartscale.md) representing the y\-axis |
| dataPoint | A [ChartAnchor](chartanchor.md) representing a point where the user is moving the mouse |



## 


## 


## Examples




| ns |
| --- |
| private   ChartAnchor                     lastMouseMoveAnchor     \= new ChartAnchor(); private ChartAnchor MyAnchor; public override void OnMouseMove(ChartControl chartControl, ChartPanel chartPanel, ChartScale chartScale, ChartAnchor dataPoint) {    // add any logic for when the mouse is moved here    if (DrawingState \=\= DrawingState.Moving)    {      //move the chart anchor when the drawing tool is in a moving state        MyAnchor.MoveAnchor(lastMouseMoveAnchor, dataPoint, chartControl, chartPanel, chartScale, this);      // dont forget to update delta point to last used!      dataPoint.CopyDataValues(lastMouseMoveAnchor);    }          } |









