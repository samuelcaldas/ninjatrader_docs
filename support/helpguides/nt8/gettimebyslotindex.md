
NinjaScript > Language Reference > Common > Charts > ChartControl > GetTimeBySlotIndex()

GetTimeBySlotIndex()

| << [Click to Display Table of Contents](gettimebyslotindex.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > [Charts](chart.md) > [ChartControl](chartcontrol.md) > GetTimeBySlotIndex() | [Previous page](getslotindexbyx.md) [Return to chapter overview](chartcontrol.md) [Next page](gettimebyx.md) |
| --- | --- |
## Definition
Returns a time value relative to the chart control corresponding to a specified slot index.
 

| Notes:  - A "Slot" is used in Equidistant [bar spacing](barspacingtype.md) and represents a position on the chart canvas background which may or may not contain a bar. The concept of "Slots" does NOT exist on a TimeBased bar spacing type.  - If you are looking for information on a bar series, please see [ChartBars.GetTimeByBarIdx()](chartbars_gettimebybaridx.md)- For slot index values in the future, an estimation of time will be returned.  It is not possible to predict the future time of a bar for all bar series (i.e., tick/volume based bars) |
| --- |

## Method Return Value
A DateTime object corresponding the a specified slot index; returns DateTime value for 'now' on a time based bar spacing type
## 
## Syntax
<ChartControl>.GetTimeBySlotIndex(double slotIndex)
## 
## Method Parameters

| slotIndex | The slot index used to determine a time value |
| --- | --- |
 
## 
## Example

| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale) {    // Find the timestamp of the bar at index 150    DateTime slotTime = chartControl.GetTimeBySlotIndex(150);      // Print the date of slotTime    Print(slotTime.Date); } |
