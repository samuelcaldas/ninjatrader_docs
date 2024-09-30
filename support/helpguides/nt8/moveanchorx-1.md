
NinjaScript > Language Reference > Drawing Tool > ChartAnchor > MoveAnchorX()

MoveAnchorX()

| << [Click to Display Table of Contents](moveanchorx.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Drawing Tool](drawing_tools-1.md) > [ChartAnchor](chartanchor-1.md) > MoveAnchorX() | [Previous page](moveanchor-1.md) [Return to chapter overview](chartanchor-1.md) [Next page](moveanchory-1.md) |
| --- | --- |
## Definition
Moves an anchor's x value from start point by a delta point amount.
 
## Method Return Value
This method does not return a value.
 
## Syntax
# <ChartAnchor>.MoveAnchorX(Point startPoint, Point deltaPoint, ChartControl chartControl, ChartPanel chartPanel, ChartScale chartScale)
## 
## Method Parameters

| startPoint | The chart anchor's original starting point value |
| --- | --- |
| deltaPoint | The chart anchor's new point value to be updated |
| chartControl | A ChartControl representing the x-axis |
| chartScale | A ChartScale representing the y-axis |
## 
## 
## Examples

| ns |
| --- |
| //move only the chart anchors x (bar/time) value MyAnchor.MoveAnchorX(lastPoint, newPoint, chartControl, chartScale); |
