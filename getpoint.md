# GetPoint()

## Definition

Returns a chart anchor's data point in device pixels

## Method Return Value

A [Point](https://msdn.microsoft.com/en-us/library/system.drawing.point%28v=vs.110%29.aspx) structure; a point value in device pixels for a chart's given panel & scale

## Syntax

<chartAnchor>.GetPoint(ChartControl chartControl, ChartPanel chartPanel, ChartScale, [bool pixelAlign])

## Method Parameters

|  |  |
| --- | --- |
| chartControl | A [ChartControl](chartcontrol.md) representing the x-axis |
| chartPanel | A [ChartPanel](chartpanel.md) representing the a panel of the chart |
| chartScale | A [ChartScale](chartscale.md) representing the y-axis |
| pixelAlign | An optional bool determining if the data point should be rounded to closest .5 pixel point |

## Examples

```csharp
//gets the chart anchors data points
Point anchorPoint = MyAnchor.GetPoint(chartControl, chartPanel, chartScale);
```
