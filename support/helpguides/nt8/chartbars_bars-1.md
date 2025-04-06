



Bars

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\chartbars_bars.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [Charts](chart-1.htm) > [ChartBars](chartbars-1.htm) >  Bars | [Previous page](chartbars-1.htm) [Return to chapter overview](chartbars-1.htm) [Next page](chartbars_count-1.htm) |

Definition
----------

Represents the data returned from the historical data repository in relation to the primary [ChartBars](chartbars-1.htm) object configured on the chart.  See also [Bars](bars-1.htm)

Property Value
--------------

A [Bars](bars-1.htm) object

Syntax
------

ChartBars.Bars

Examples
--------

| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale)  {     if(ChartBars != null && ChartBars.Bars != null)     {       Print("The configured bars period type represented on the chart is" + ChartBars.Bars.BarsPeriod.BarsPeriodType);     }  } |