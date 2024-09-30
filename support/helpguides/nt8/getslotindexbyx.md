
NinjaScript \> Language Reference \> Common \> Charts \> ChartControl \> GetSlotIndexByX()
GetSlotIndexByX()
| \<\< [Click to Display Table of Contents](getslotindexbyx.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Charts](chart.md) \> [ChartControl](chartcontrol.md) \> GetSlotIndexByX() | [Previous page](getslotindexbytime.md) [Return to chapter overview](chartcontrol.md) [Next page](gettimebyslotindex.md) |
| --- | --- |
## Definition
Returns the slot index relative to the chart control corresponding to a specified x\-coordinate
 
| Notes:  - A "Slot" is used in Equidistant [bar spacing](barspacingtype.md) and represents a position on the chart canvas background which may or may not contain a bar. The concept of "Slots" does NOT exist on a TimeBased bar spacing type.  - If you are looking for information on a bar series, please see [ChartBars.GetBarIdxByX()](chartbars_getbaridxbyx.md)- Since the slot index is based on the chart canvas, the value returned by GetSlotIndexByX() can be expected to change as new bars are painted, or as the chart is scrolled backward or forward on the x\-axis. |
| --- |

## Method Return Value
A double representing a slot index; returns \-1 on a time based bar spacing type
## 
## Syntax
\<ChartControl\>.GetSlotIndexByX(int x)
## 
## Method Parameters
| x | An int used to determine a slot index |
| --- | --- |
 
## 
## Example
| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale) {    // Find the index of the bar painted at x\-coordinate 35    double slotIndex \= chartControl.GetSlotIndexByX(35);      // Print the slot index of the specified time    Print(slotIndex); } |

