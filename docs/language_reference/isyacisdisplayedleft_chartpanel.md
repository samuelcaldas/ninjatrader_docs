# IsYAxisDisplayedLeft

## Definition

Indicates the y-axis is visible on the left side of the chart panel.

## Property Value

A bool indicating the y-axis is visible to the left

## Syntax

ChartPanel.IsYAxisDisplayedLeft

## Example

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
    base.OnRender(chartControl, chartScale);
    // Print a message if the y-axis is visible on the left
    if (ChartPanel.IsYAxisDisplayedLeft)
    Print("The y-axis is visible on the left");
}
```

 

 

Based on the image below, IsYAxisDisplayedLeft confirms that the y-axis displays to the left. In this image, the property would be set to true when applied to either chart panel.

 

![[[ChartPanel_IsYAxisDisplayedLeft](../images/chartpanel_isyaxisdisplayedleft.png)
