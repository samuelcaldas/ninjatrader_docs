# OnMouseDown()

## Definition

An event driven method which is called any time the mouse pointer over the chart control has the mouse button pressed.

## Method Return Value

This method does not return a value.

> **Note:** For a combined single click operation, i.e. mouse down click, move and release the dataPoint reported will always be the initial starting one.

## Syntax

`You must override the method in your Drawing Tool with the following syntax.`

   
public override void OnMouseDown(ChartControl chartControl, ChartPanel chartPanel, ChartScale chartScale, ChartAnchor dataPoint)  
{  
     
}

## Method Parameters

| Name / Option | Description |
| --- | --- |
| chartControl | A [ChartControl](../language_reference/chartcontrol.md) representing the x-axis |
| chartPanel | A [ChartPanel](../language_reference/chartpanel.md) representing the the panel for the chart |
| chartScale | A [ChartScale](../language_reference/chartscale.md) representing the y-axis |
| dataPoint | A [ChartAnchor](chartanchor.md) representing a point where the user clicked |

## Examples

```csharp
public override void OnMouseDown(ChartControl chartControl, ChartPanel chartPanel, ChartScale chartScale, ChartAnchor dataPoint)
{
    switch (DrawingState)
    {
        case DrawingState.Building:
        dataPoint.CopyDataValues(Anchor);
        Anchor.IsEditing
        = false;
        DrawingState
        = DrawingState.Normal;
        IsSelected
        = false;
        break;
        case DrawingState.Normal:
        // make sure they clicked near us. use GetCursor incase something has more than one point
        Point point = dataPoint.GetPoint(chartControl, chartPanel, chartScale);
        if (GetCursor(chartControl, chartPanel, chartScale, point) != null)
        DrawingState = DrawingState.Moving;
        else
        IsSelected = false;
        break;
    }
}
```
