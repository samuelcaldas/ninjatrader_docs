# IsYAxisDisplayedOverlay

## Definition

Indicates any objects configured in the panel are using the Overlay scale justification.

## Property Value

A bool indicating any objects use the Overlay scale justification

## Syntax

ChartPanel.IsYAxisDisplayedOverlay

## Example

![Ns](../images/ns.png)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
    base.OnRender(chartControl, chartScale);
    // Trigger an alert when the Overlay scale justification is used
    if (ChartPanel.IsYAxisDisplayedOverlay)
    Alert("overlayAlert", Priority.Low, "It is not recommended to use 'Overlay' with this indicator", "", 300, Brushes.Yellow, Brushes.Black);
}
```

 

 

Based on the image below, IsYAxisDisplayedOverlay is set to True, since the SMA indicator is using the Overlay scale justification.

 

![ChartPanel_IsYAxisDisplayedOverlay](../images/chartpanel_isyaxisdisplayedoverlay.png)