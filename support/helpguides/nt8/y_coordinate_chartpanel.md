﻿
NinjaScript > Language Reference > Common > Charts > ChartPanel > Y (Coordinate)
Y (Coordinate)

| << [Click to Display Table of Contents](y_coordinate_chartpanel.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > [Charts](chart.md) > [ChartPanel](chartpanel.md) > Y (Coordinate) | [Previous page](x_coordinate_chartpanel.md) [Return to chapter overview](chartpanel.md) [Next page](chartscale.md) |
| --- | --- |

## Definition
Indicates the y-coordinate on the chart canvas at which the chart panel begins. 
## 
## Property Value
A int representing the y-coordinate at which the panel begins. 
 
## Syntax
ChartPanel.Y
## 
## Example
| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale) {    base.OnRender(chartControl, chartScale);         // Print the coordinates of the top-left corner of the panel    Print(String.Format("The panel begins at coordinates {0},{1}",ChartPanel.X ,ChartPanel.Y)); } |

Based on the image below, Y reveals that the chart panel begins at y-coordinate 232.
 
![ChartPanel_Y](chartpanel_y.png)
