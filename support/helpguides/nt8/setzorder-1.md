
NinjaScript \> Language Reference \> Common \> Charts \> Rendering \> SetZOrder
SetZOrder
| \<\< [Click to Display Table of Contents](setzorder.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [Charts](chart-1.md) \> [Rendering](rendering-1.md) \> SetZOrder | [Previous page](rendertarget-1.md) [Return to chapter overview](rendering-1.md) [Next page](chart_zorder-1.md) |
| --- | --- |
## Definition
Used to assign a unique identifier representing the index in which chart objects are drawn on the chart's Z\-axis (front to back ordering). Objects with a higher ZOrder are drawn first.  
 
| Note:     1\. To check on which ZOrder index the object gets drawn use the [ZOrder](chart_zorder-1.md) property. 2\. Assigning specific ZOrder indices to draw at should be done once the [State](onstatechange-1.md) has reached State.Historical  3\. If you want to draw your object behind the bars, assign to use index \-1 (like in the example below) 4\. If you want to draw your object topmost, assign to use index int.MaxValue 5\. Any levels in between can be directly assigned, the starting / default levels used by NinjaTrader can be seen [here](chart_zorder-1.md). 6\. You can see the highest ZOrder currently in a chart with code such our second example below \- setting higher values than this value will result in the ZOrder to be set to this value, so this can be thought of as the current 'top'. |
| --- |

 
## Method Return Value
This method does not return a value
 
## Syntax
SetZOrder(int DesiredZOrderLevel)
 
## Examples
| ns |
| --- |
| protected override void OnStateChange() {    if (State \=\= State.Historical)    {        // Make sure our object plots behind the chart bars        SetZOrder(\-1);    } } |

| ns |
| --- |
| protected override void OnRender(ChartControl cc, ChartScale cs) {    Print(ChartPanel.ChartObjects.Max(co \=\> co.ZOrder)); } |
