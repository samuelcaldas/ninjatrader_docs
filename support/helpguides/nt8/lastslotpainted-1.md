


NinjaScript \> Language Reference \> Common \> Charts \> ChartControl \> LastSlotPainted






















LastSlotPainted







| \<\< [Click to Display Table of Contents](lastslotpainted.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [Charts](chart-1.md) \> [ChartControl](chartcontrol-1.md) \> LastSlotPainted | [Previous page](isyaxisdisplayedright-1.md) [Return to chapter overview](chartcontrol-1.md) [Next page](lasttimepainted-1.md) |
| --- | --- |











## Definition


Indicates the most recent (last) slot index of the Data Series on the chart, regardless if a bar is actually painted in that slot.


 




| Note: LastSlotPainted differs from [ChartBars.ToIndex](chartbars_toindex-1.md), which returns the last index containing a bar painted in the visible area of the chart. |
| --- |



## 


## Property Value


A int representing the most recent (last) slot index on the chart


## 


## Syntax


\<ChartControl\>.LastSlotPainted


## 


## Example




| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale) {    int lastSlot \= chartControl.LastSlotPainted;      // Print the index of the last slot on the chart    Print(lastSlot); } |









