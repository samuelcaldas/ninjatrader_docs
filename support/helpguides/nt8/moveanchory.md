



MoveAnchorY()

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](moveanchory.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Drawing Tool](drawing_tools.htm) > [ChartAnchor](chartanchor.htm) >  MoveAnchorY() | [Previous page](moveanchorx.htm) [Return to chapter overview](chartanchor.htm) [Next page](price.htm) |

Definition
----------

Moves an anchor's y value from start point by a delta point amount.

Method Return Value
-------------------

This method does not return a value.

Syntax
------

<ChartAnchor>.MoveAnchorY(Point startPoint, Point deltaPoint, ChartControl chartControl, ChartScale chartScale)

Method Parameters
-----------------

|  |  |
| --- | --- |
| startPoint | The chart anchor's original starting point value |
| deltaPoint | The chart anchor's new point value to be updated |
| chartControl | A ChartControl representing the x-axis |
| chartScale | A ChartScale representing the y-axis |

Examples
--------

| ns |
| --- |
| //move only the chart anchors Y (price) value  MyAnchor.MoveAnchorY(lastPoint, newPoint, chartControl, chartPanel, chartScale); |