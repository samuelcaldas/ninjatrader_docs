# OnMouseUp()

## Definition

An event driven method is called any time the mouse pointer is over the chart control and a mouse button is being released.

## Method Return Value

This method does not return a value

> **Note:** For a combined single click operation, i.e. mouse down click, move and release the dataPoint reported will always be the initial starting one.

## Syntax

`You must override the method with the following syntax.`

   
public override void OnMouseUp(ChartControl chartControl, ChartPanel chartPanel, ChartScale chartScale, ChartAnchor dataPoint)  
{  
   
}

## Method Parameters

|  |  |
| --- | --- |
| chartControl | A [[[ChartControl](../language_reference/chartcontrol.md) representing the x-axis |
| chartPanel | A [[[ChartPanel](../language_reference/chartpanel.md) representing the the panel for the chart |
| chartScale | A [[[ChartScale](../language_reference/chartscale.md) representing the y-axis |
| dataPoint | A [[[ChartAnchor](chartanchor.md) representing a point where the user is releasing the mouse |

## Examples

```csharp
public override void OnMouseUp(ChartControl chartControl, ChartPanel chartPanel, ChartScale chartScale, ChartAnchor dataPoint)
{
    //when the user releases the mouse, ensure the drawing state is set to normal
    if (DrawingState == DrawingState.Editing || DrawingState == DrawingState.Moving)
    DrawingState = DrawingState.Normal;
}
```
