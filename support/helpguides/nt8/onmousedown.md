



OnMouseDown()

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](onmousedown.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Drawing Tool](drawing_tools.htm) >  OnMouseDown() | [Previous page](onbarschanged.htm) [Return to chapter overview](drawing_tools.htm) [Next page](onmousemove.htm) |

Definition
----------

An event driven method which is called any time the mouse pointer over the chart control has the mouse button pressed.

Method Return Value
-------------------

This method does not return a value.

|  |
| --- |
| Note:  For a combined single click operation, i.e. mouse down click, move and release the dataPoint reported will always be the initial starting one. |

Syntax 
You must override the method in your Drawing Tool with the following syntax.
------------------------------------------------------------------------------------

   
public override void OnMouseDown(ChartControl chartControl, ChartPanel chartPanel, ChartScale chartScale, ChartAnchor dataPoint)  
{  
     
}

Method Parameters
-----------------

|  |  |
| --- | --- |
| chartControl | A [ChartControl](chartcontrol.htm) representing the x-axis |
| chartPanel | A [ChartPanel](chartpanel.htm) representing the the panel for the chart |
| chartScale | A [ChartScale](chartscale.htm) representing the y-axis |
| dataPoint | A [ChartAnchor](chartanchor.htm) representing a point where the user clicked |

Examples
--------

| ns |
| --- |
| public override void OnMouseDown(ChartControl chartControl, ChartPanel chartPanel, ChartScale chartScale, ChartAnchor dataPoint)  {     switch (DrawingState)     {       case DrawingState.Building:           dataPoint.CopyDataValues(Anchor);           Anchor.IsEditing   = false;           DrawingState     = DrawingState.Normal;           IsSelected         = false;           break;       case DrawingState.Normal:           // make sure they clicked near us. use GetCursor incase something has more than one point           Point point = dataPoint.GetPoint(chartControl, chartPanel, chartScale);           if (GetCursor(chartControl, chartPanel, chartScale, point) != null)             DrawingState = DrawingState.Moving;           else             IsSelected = false;           break;     }  } |