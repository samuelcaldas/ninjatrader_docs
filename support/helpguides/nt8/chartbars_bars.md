



Bars

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](chartbars_bars.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Common](common.htm) > [Charts](chart.htm) > [ChartBars](chartbars.htm) >  Bars | [Previous page](chartbars.htm) [Return to chapter overview](chartbars.htm) [Next page](chartbars_count.htm) |

Definition
----------

Represents the data returned from the historical data repository in relation to the primary [ChartBars](chartbars.htm) object configured on the chart.  See also [Bars](bars.htm)

Property Value
--------------

A [Bars](bars.htm) object

Syntax
------

ChartBars.Bars

Examples
--------

| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale)  {     if(ChartBars != null && ChartBars.Bars != null)     {       Print("The configured bars period type represented on the chart is" + ChartBars.Bars.BarsPeriod.BarsPeriodType);     }  } |