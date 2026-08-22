# UpdateFromPoint()

## Definition

Updates an anchor's x and y values from a given point (in device pixels).

## Method Return Value

This method does not return a value.

## Syntax

<ChartAnchor>.UpdateFromPoint(Point point, ChartControl chartControl, ChartScale chartScale)

## Method Parameters

|  |  |
| --- | --- |
| point | The chart anchor's point value to be updated |
| chartControl | A ChartControl representing the x-axis |
| chartScale | A ChartScale representing the y-axis |

 

## Examples

```csharp
//set the chart anchors x and y point value
MyAnchor.UpdateFromPoint(point, chartControl, chartScale);
```
