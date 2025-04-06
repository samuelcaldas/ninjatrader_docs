



GetBarIdxByTime()

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](chartbars_getbaridxbytime.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Common](common.htm) > [Charts](chart.htm) > [ChartBars](chartbars.htm) >  GetBarIdxByTime() | [Previous page](chartbars_fromindex.htm) [Return to chapter overview](chartbars.htm) [Next page](chartbars_getbaridxbyx.htm) |

Definition
----------

Returns the [ChartBars](chartbars.htm) index value calculated from the time parameter provided.

Method Return Value
-------------------

An int representing the bar index value at a specific time

Syntax 
ChartBars.GetBarIdxByTime(ChartControl chartControl, DateTime time)
---------------------------------------------------------------------------

Method Parameters
-----------------

|  |  |
| --- | --- |
| chartControl | The [ChartControl](chartcontrol.htm) object used to determine the chart's time axis |
| time | The [DateTime](https://msdn.microsoft.com/en-us/library/system.datetime(v=vs.110).aspx) value used to convert to a ChartBar index value |

Examples
--------

| ns |
| --- |
| protected override void OnBarUpdate()  {        if (ChartBars != null)        {                Print(ChartBars.GetBarIdxByTime(ChartControl, Time[0]));       }  } |