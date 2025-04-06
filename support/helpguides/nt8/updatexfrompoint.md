



UpdateXFromPoint()

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](updatexfrompoint.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Drawing Tool](drawing_tools.htm) > [ChartAnchor](chartanchor.htm) >  UpdateXFromPoint() | [Previous page](updatefrompoint.htm) [Return to chapter overview](chartanchor.htm) [Next page](updateyfrompoint.htm) |

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