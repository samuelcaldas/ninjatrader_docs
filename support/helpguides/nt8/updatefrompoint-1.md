



UpdateFromPoint()

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\updatefrompoint.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Drawing Tool](drawing_tools-1.htm) > [ChartAnchor](chartanchor-1.htm) >  UpdateFromPoint() | [Previous page](time-1.htm) [Return to chapter overview](chartanchor-1.htm) [Next page](updatexfrompoint-1.htm) |

Definition
----------

Updates an anchor's x and y values from a given point (in device pixels).

Method Return Value
-------------------

This method does not return a value.

Syntax
------

<ChartAnchor>.UpdateFromPoint(Point point, ChartControl chartControl, ChartScale chartScale)

Method Parameters
-----------------

|  |  |
| --- | --- |
| point | The chart anchor's point value to be updated |
| chartControl | A ChartControl representing the x-axis |
| chartScale | A ChartScale representing the y-axis |

 

Examples
--------

| ns |
| --- |
| //set the chart anchors x and y point value  MyAnchor.UpdateFromPoint(point, chartControl, chartScale); |