# IsYAxisDisplayedLeft

## Definition

Indicates the y-axis displays (in any chart panel) to the left side of the chart.

## Property Value

A boolean value. When True, indicates that the y-axis displays to the left of the chart canvas; otherwise False.

## Syntax

<ChartControl>.IsYAxisDisplayedLeft

## Examples

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
    // Print the value of IsYAxisDisplayedLeft
    Print("Y-Axis visible to the left of the chart canvas? " + chartControl.IsYAxisDisplayedLeft);
}
```

 

 

Based on the image below, IsYAxisDisplayedLeft confirms that the y-axis displays to the left of the chart canvas.

![[[ChartControl_isYAxisDisplayedLeft](../images/chartcontrol_isyaxisdisplayedleft.png)
