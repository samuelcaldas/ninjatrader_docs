# CreateAnchor()

## Definition

Used to create a new chart anchor at a specified mouse point.

## Method Return Value

A new [ChartAnchor](chartanchor.md) at a specified point in device pixels.

## Syntax

CreateAnchor(Point point, ChartControl chartControl, ChartScale chartScale)  

## Method Parameters

| Name / Option | Description |
| --- | --- |
| point | A Point in device pixels representing the current mouse cursor position |
| chartControl | A ChartControl representing the x-axis |
| chartScale | A ChartScale representing the y-axis |

## Examples

```csharp
public override void OnMouseDown(ChartControl chartControl, ChartPanel chartPanel, ChartScale chartScale, ChartAnchor dataPoint)
{
    // get the point where the mouse was clicked
    Point myPoint = dataPoint.GetPoint(chartControl, chartPanel, chartScale);
    // create an anchor at that point
    ChartAnchor MyAnchor = CreateAnchor(myPoint, chartControl, chartScale);
    Print(MyAnchor.Time); // 3/16/2015 8:18:48 AM
}
```