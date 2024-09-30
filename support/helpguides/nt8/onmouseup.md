
NinjaScript \> Language Reference \> Drawing Tool \> OnMouseUp()

OnMouseUp()

| \<\< [Click to Display Table of Contents](onmouseup.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Drawing Tool](drawing_tools.md) \> OnMouseUp() | [Previous page](onmousemove.md) [Return to chapter overview](drawing_tools.md) [Next page](supportsalerts.md) |
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

| chartControl | A [ChartControl](chartcontrol.md) representing the x\-axis |
| --- | --- |
| chartPanel | A [ChartPanel](chartpanel.md) representing the the panel for the chart |
| chartScale | A [ChartScale](chartscale.md) representing the y\-axis |
| dataPoint | A [ChartAnchor](chartanchor.md) representing a point where the user is releasing the mouse |
## 
## 
## Examples

| ns |
| --- |
| public override void OnMouseUp(ChartControl chartControl, ChartPanel chartPanel, ChartScale chartScale, ChartAnchor dataPoint) {    //when the user releases the mouse, ensure the drawing state is set to normal    if (DrawingState \=\= DrawingState.Editing \|\| DrawingState \=\= DrawingState.Moving)      DrawingState \= DrawingState.Normal; } |
