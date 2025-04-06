



Y (Coordinate)

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](y_coordinate_chartpanel.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Common](common.htm) > [Charts](chart.htm) > [ChartPanel](chartpanel.htm) >  Y (Coordinate) | [Previous page](x_coordinate_chartpanel.htm) [Return to chapter overview](chartpanel.htm) [Next page](chartscale.htm) |

Definition
----------

Indicates the y-coordinate on the chart canvas at which the chart panel begins.

Property Value
--------------

A int representing the y-coordinate at which the panel begins.

Syntax
------

ChartPanel.Y

Example
-------

| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale)  {     base.OnRender(chartControl, chartScale);           // Print the coordinates of the top-left corner of the panel     Print(String.Format("The panel begins at coordinates {0},{1}",ChartPanel.X ,ChartPanel.Y));  } |

 

 

Based on the image below, Y reveals that the chart panel begins at y-coordinate 232.

 

![ChartPanel_Y](chartpanel_y.png)