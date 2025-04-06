



OnMouseMove()

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](onmousemove.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Drawing Tool](drawing_tools.htm) >  OnMouseMove() | [Previous page](onmousedown.htm) [Return to chapter overview](drawing_tools.htm) [Next page](onmouseup.htm) |

Definition
----------

An event driven method which is called any time the mouse pointer is over the chart control and a mouse is moving.

Method Return Value
-------------------

This method does not return a value.

|  |
| --- |
| Note:  For a combined single click operation, i.e. mouse down click, move and release the dataPoint reported will always be the initial starting one. |

Syntax 
You must override the method in your Drawing Tool with the following syntax.
------------------------------------------------------------------------------------

   
public override void OnMouseMove(ChartControl chartControl, ChartPanel chartPanel, ChartScale chartScale, ChartAnchor dataPoint)  
{  
   
}

Method Parameters
-----------------

|  |  |
| --- | --- |
| chartControl | A [ChartControl](chartcontrol.htm) representing the x-axis |
| chartPanel | A [ChartPanel](chartpanel.htm) representing the the panel for the chart |
| chartScale | A [ChartScale](chartscale.htm) representing the y-axis |
| dataPoint | A [ChartAnchor](chartanchor.htm) representing a point where the user is moving the mouse |

Examples
--------

| ns |
| --- |
| private   ChartAnchor                     lastMouseMoveAnchor     = new ChartAnchor();  private ChartAnchor MyAnchor;  public override void OnMouseMove(ChartControl chartControl, ChartPanel chartPanel, ChartScale chartScale, ChartAnchor dataPoint)  {     // add any logic for when the mouse is moved here     if (DrawingState == DrawingState.Moving)     {       //move the chart anchor when the drawing tool is in a moving state          MyAnchor.MoveAnchor(lastMouseMoveAnchor, dataPoint, chartControl, chartPanel, chartScale, this);       // dont forget to update delta point to last used!       dataPoint.CopyDataValues(lastMouseMoveAnchor);     }           } |