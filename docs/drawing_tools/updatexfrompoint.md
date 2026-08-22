# UpdateXFromPoint()

## Definition

Updates an anchor's X value from a given point (in device pixels).

## Method Return Value

This method does not return a value.

## Syntax

<ChartAnchor>.UpdateXFromPoint(Point point, ChartControl chartControl, ChartScale chartScale)

## Method Parameters

| Name / Option | Description |
| --- | --- |
| point | The chart anchor's point value to be updated |
| chartControl | A ChartControl representing the x-axis |
| chartScale | A ChartScale representing the y-axis |

 

## Examples

![Ns](../images/ns.png)

```csharp
//set the chart anchors x point value
MyAnchor.UpdateXFromPoint(point, chartControl, chartScale);
```