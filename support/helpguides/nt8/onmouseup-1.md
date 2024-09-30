
NinjaScript > Language Reference > Drawing Tool > OnMouseUp()

OnMouseUp()

| << [Click to Display Table of Contents](onmouseup.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Drawing Tool](drawing_tools-1.md) > OnMouseUp() | [Previous page](onmousemove-1.md) [Return to chapter overview](drawing_tools-1.md) [Next page](supportsalerts-1.md) |
| --- | --- |
## Definition
An event driven method is called any time the mouse pointer is over the chart control and a mouse button is being released.
 
## Method Return Value
This method does not return a value
 

| Note:  For a combined single click operation, i.e. mouse down click, move and release the dataPoint reported will always be the initial starting one. |
| --- |
 
## Syntax
You must override the method with the following syntax.
   

public override void OnMouseUp(ChartControl chartControl, ChartPanel chartPanel, ChartScale chartScale, ChartAnchor dataPoint)  

{  

   

}
## 
## Method Parameters

| chartControl | A [ChartControl](chartcontrol-1.md) representing the x-axis |
| --- | --- |
| chartPanel | A [ChartPanel](chartpanel-1.md) representing the the panel for the chart |
| chartScale | A [ChartScale](chartscale-1.md) representing the y-axis |
| dataPoint | A [ChartAnchor](chartanchor-1.md) representing a point where the user is releasing the mouse |
## 
## 
## Examples

| ns |
| --- |
| public override void OnMouseUp(ChartControl chartControl, ChartPanel chartPanel, ChartScale chartScale, ChartAnchor dataPoint) {    //when the user releases the mouse, ensure the drawing state is set to normal    if (DrawingState == DrawingState.Editing || DrawingState == DrawingState.Moving)      DrawingState = DrawingState.Normal; } |
