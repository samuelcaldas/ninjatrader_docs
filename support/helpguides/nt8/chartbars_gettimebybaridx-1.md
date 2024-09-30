
NinjaScript > Language Reference > Common > Charts > ChartBars > GetTimeByBarIdx()

GetTimeByBarIdx()
| << [Click to Display Table of Contents](chartbars_gettimebybaridx.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [Charts](chart-1.md) > [ChartBars](chartbars-1.md) > GetTimeByBarIdx() | [Previous page](chartbars_getbaridxbyx-1.md) [Return to chapter overview](chartbars-1.md) [Next page](chartbars_panel-1.md) |
| --- | --- |
## Definition
Returns the [ChartBars](chartbars-1.md) time value calculated from a bar index parameter provided.
 
## Method Return Value
A [DateTime](https://msdn.microsoft.com/en-us/library/system.datetime(v=vs.110).aspx) struct representing a bar time value at a specific bar index value
## 
## Syntax
ChartBars.GetTimeByBarIdx(ChartControl chartControl, int barIndex)
## 
## Method Parameters
| chartControl | The [ChartControl](chartcontrol-1.md) object used to determine the chart's time axis |
| --- | --- |
| barIndex | An int value representing a bar index used to convert to a ChartBar index value |

## 
## 
## Examples
| ns |
| --- |
| protected override void OnBarUpdate() {    if (ChartBars != null)    {      Print(ChartBars.GetTimeByBarIdx(ChartControl, 50)); //8/11/2015 4:30:00 AM        } } |
