



UpdateXFromPoint()

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\updatexfrompoint.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Drawing Tool](drawing_tools-1.htm) > [ChartAnchor](chartanchor-1.htm) >  UpdateXFromPoint() | [Previous page](updatefrompoint-1.htm) [Return to chapter overview](chartanchor-1.htm) [Next page](updateyfrompoint-1.htm) |

Definition
----------

Updates an anchor's X value from a given point (in device pixels).

Method Return Value
-------------------

This method does not return a value.

Syntax
------

<ChartAnchor>.UpdateXFromPoint(Point point, ChartControl chartControl, ChartScale chartScale)

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
| //set the chart anchors x point value  MyAnchor.UpdateXFromPoint(point, chartControl, chartScale); |