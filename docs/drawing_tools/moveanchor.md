# MoveAnchor()

## Definition

Moves a Chart Anchor's x and y values from start point by a delta point amount.

## Method Return Value

This method does not return a value.

## Syntax

<ChartAnchor>.MoveAnchor(ChartAnchor startDataPoint, ChartAnchor deltaDataPoint, ChartControl chartControl, ChartPanel chartPanel, ChartScale chartScale, DrawingTool drawingTool)

## Method Parameters

| Name / Option | Description |
| --- | --- |
| startPoint | The chart anchor's original starting location value represented by a point structure |
| startDataPoint | A chart anchor's original starting location value represented by a chart anchor |
| deltaPoint | The chart anchor's new location value to be updated represented by a point structure |
| deltaDataPoint | The chart anchor's new location value to be udpated represened by a chart anchor |
| chartControl | A ChartControl representing the x-axis |
| chartScale | A ChartScale representing the y-axis |
| chartPanel | A ChartPanel representing the the panel for the chart |
| drawingTool | The drawing tool which owns the chart anchor to be moved (usually this). |

## Examples

```csharp
//move the chart anchors x and y values
MyAnchor.MoveAnchor(lastPoint, newPoint, chartControl, chartPanel, chartScale, this);
```