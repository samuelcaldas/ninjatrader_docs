
NinjaScript \> Language Reference \> Common \> Charts \> ChartBars \> GetBarIdxByTime()
GetBarIdxByTime()
| \<\< [Click to Display Table of Contents](chartbars_getbaridxbytime.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [Charts](chart-1.md) \> [ChartBars](chartbars-1.md) \> GetBarIdxByTime() | [Previous page](chartbars_fromindex-1.md) [Return to chapter overview](chartbars-1.md) [Next page](chartbars_getbaridxbyx-1.md) |
| --- | --- |
## Definition
Returns the [ChartBars](chartbars-1.md) index value calculated from the time parameter provided.
 
## Method Return Value
An int representing the bar index value at a specific time
## 
## Syntax
ChartBars.GetBarIdxByTime(ChartControl chartControl, DateTime time)
## 
## Method Parameters
| chartControl | The [ChartControl](chartcontrol-1.md) object used to determine the chart's time axis |
| --- | --- |
| time | The [DateTime](https://msdn.microsoft.com/en-us/library/system.datetime(v=vs.110).aspx) value used to convert to a ChartBar index value |
## 
## 
## Examples
| ns |
| --- |
| protected override void OnBarUpdate() {       if (ChartBars !\= null)       {               Print(ChartBars.GetBarIdxByTime(ChartControl, Time\[0]));      } } |

