
NinjaScript > Language Reference > Common > Charts > ChartControl > IsYAxisDisplayedOverlay
IsYAxisDisplayedOverlay

| << [Click to Display Table of Contents](isyaxisdisplayedoverlay.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [Charts](chart-1.md) > [ChartControl](chartcontrol-1.md) > IsYAxisDisplayedOverlay | [Previous page](isyaxisdisplayedleft-1.md) [Return to chapter overview](chartcontrol-1.md) [Next page](isyaxisdisplayedright-1.md) |
| --- | --- |

## Definition
Indicates an object on the chart is using the Overlay scale justification.
## 
## Property Value
A boolean value. When True, indicates that one or more objects on the chart are using the Overlay scale justification; otherwise False.
## 
## Syntax
<ChartControl>.IsYAxisDisplayedOverlay
## 
## Examples
| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale) {    // Print the value of IsYAxisDisplayedOverlay    Print("Is Overlay used? " + chartControl.IsYAxisDisplayedOverlay); } |

Based on the image below, IsYAxisDisplayedOverlay confirms that the an object on the chart, in this case an SMA indicator, is using the Overlay scale justification.
 
![ChartControl_IsXAxisDisplayedOverlay](chartcontrol_isxaxisdisplayedoverlay.png)
