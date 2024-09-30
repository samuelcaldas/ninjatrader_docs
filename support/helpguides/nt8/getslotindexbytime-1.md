
NinjaScript > Language Reference > Common > Charts > ChartControl > GetSlotIndexByTime()
GetSlotIndexByTime()
| << [Click to Display Table of Contents](getslotindexbytime.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [Charts](chart-1.md) > [ChartControl](chartcontrol-1.md) > GetSlotIndexByTime() | [Previous page](chartcontrol_getbarpaintwidth-1.md) [Return to chapter overview](chartcontrol-1.md) [Next page](getslotindexbyx-1.md) |
| --- | --- |
## Definition
Returns the slot index relative to the chart control corresponding to a specified time value. 
 
| Notes:  - A "Slot" is used in Equidistant [bar spacing](barspacingtype-1.md) and represents a position on the chart canvas background which may or may not contain a bar. The concept of "Slots" does NOT exist on a TimeBased bar spacing type.  - If you are looking for information on a bar series, please see [ChartBars.GetBarIdxByTime()](chartbars_getbaridxbytime-1.md) |
| --- |

## Method Return Value
A double representing a slot index
## 
## Syntax
<ChartControl>.GetSlotIndexByTime(DateTime time)
## 
| Warning:  This method CANNOT be called on BarSpacingType.TimeBased charts.  You will need to ensure an Equidistant [bar spacing type](barspacingtype-1.md) is used, otherwise errors will be thrown. |
| --- |

## Method Parameters
| time | A [DateTime](https://msdn.microsoft.com/en-us/library/system.datetime(v=vs.110).aspx) Structure used to determine a slot index |
| --- | --- |
 
## 
## Example
| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale) {    // ensure that GetSlotIndexByTime is called on TimeBased charts    if(chartControl.BarSpacingType != BarSpacingType.TimeBased)    {      // get the slot index of the first time painted on the chart      double slotIndex = chartControl.GetSlotIndexByTime(chartControl.FirstTimePainted);             Print(slotIndex);    } } |

