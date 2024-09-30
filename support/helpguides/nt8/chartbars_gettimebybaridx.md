
NinjaScript > Language Reference > Common > Charts > ChartBars > GetTimeByBarIdx()

GetTimeByBarIdx()
| << [Click to Display Table of Contents](chartbars_gettimebybaridx.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > [Charts](chart.md) > [ChartBars](chartbars.md) > GetTimeByBarIdx() | [Previous page](chartbars_getbaridxbyx.md) [Return to chapter overview](chartbars.md) [Next page](chartbars_panel.md) |
| --- | --- |
## Definition
Returns the [ChartBars](chartbars.md) time value calculated from a bar index parameter provided.
 
## Method Return Value
A [DateTime](https://msdn.microsoft.com/en-us/library/system.datetime(v=vs.110).aspx) struct representing a bar time value at a specific bar index value
## 
## Syntax
ChartBars.GetTimeByBarIdx(ChartControl chartControl, int barIndex)
## 
## Method Parameters
| chartControl | The [ChartControl](chartcontrol.md) object used to determine the chart's time axis |
| --- | --- |
| barIndex | An int value representing a bar index used to convert to a ChartBar index value |

## 
## 
## Examples
| ns |
| --- |
| protected override void OnBarUpdate() {    if (ChartBars != null)    {      Print(ChartBars.GetTimeByBarIdx(ChartControl, 50)); //8/11/2015 4:30:00 AM        } } |
