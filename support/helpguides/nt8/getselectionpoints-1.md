



GetSelectionPoints()

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\getselectionpoints.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Drawing Tool](drawing_tools-1.htm) >  GetSelectionPoints() | [Previous page](getcursor-1.htm) [Return to chapter overview](drawing_tools-1.htm) [Next page](icon_drawingtool-1.htm) |

Definition
----------

Returns the chart object's data points where the user can interact.   These points are used to visually indicate that the chart object is selected and allow the user to manipulate the chart object.  This method is only called when [IsSelected](isselected-1.htm) is set to true.

Method Return Value
-------------------

A collection of [Points](https://msdn.microsoft.com/en-us/library/system.drawing.point%28v=vs.110%29.aspx) representing the x- and y-coordinates of the chart object.

Syntax 
You must override the method using the following syntax:
----------------------------------------------------------------

public override Point[] GetSelectionPoints(ChartControl chartControl, ChartScale chartScale)  
{  
   
}

Method Parameters
-----------------

|  |  |
| --- | --- |
| chartControl | A [ChartControl](chartcontrol-1.htm) representing the x-axis |
| chartScale | A [ChartScale](chartscale-1.htm) representing the y-axis |

Examples
--------

| ns |
| --- |
| public override Point[] GetSelectionPoints(ChartControl chartControl, ChartScale chartScale)  {              ChartPanel chartPanel = chartControl.ChartPanels[chartScale.PanelIndex];     // get the anchor point to be displayed on the drawing tool   Point anchorPoint = Anchor.GetPoint(chartControl, chartPanel, chartScale, false);           return new[] { anchorPoint } ;  } |