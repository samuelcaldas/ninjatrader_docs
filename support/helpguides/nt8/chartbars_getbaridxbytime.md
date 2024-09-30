
NinjaScript \> Language Reference \> Common \> Charts \> ChartBars \> GetBarIdxByTime()
GetBarIdxByTime()
| \<\< [Click to Display Table of Contents](chartbars_getbaridxbytime.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Charts](chart.md) \> [ChartBars](chartbars.md) \> GetBarIdxByTime() | [Previous page](chartbars_fromindex.md) [Return to chapter overview](chartbars.md) [Next page](chartbars_getbaridxbyx.md) |
| --- | --- |
## Definition
Returns the [ChartBars](chartbars.md) index value calculated from the time parameter provided.
 
## Method Return Value
An int representing the bar index value at a specific time
## 
## Syntax
ChartBars.GetBarIdxByTime(ChartControl chartControl, DateTime time)
## 
## Method Parameters
| chartControl | The [ChartControl](chartcontrol.md) object used to determine the chart's time axis |
| --- | --- |
| time | The [DateTime](https://msdn.microsoft.com/en-us/library/system.datetime(v=vs.110).aspx) value used to convert to a ChartBar index value |
## 
## 
## Examples
| ns |
| --- |
| protected override void OnBarUpdate() {       if (ChartBars !\= null)       {               Print(ChartBars.GetBarIdxByTime(ChartControl, Time\[0]));      } } |

