



BarsPeriod

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](chartcontrol_barsperiod.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Common](common.htm) > [Charts](chart.htm) > [ChartControl](chartcontrol.htm) >  BarsPeriod | [Previous page](barspacingtype.htm) [Return to chapter overview](chartcontrol.htm) [Next page](chartcontrol_barwidth.htm) |

Definition
----------

Provides the period (interval) used for the primary [Bars](bars.htm) object on the chart.

Property Value
--------------

A NinjaTrader.Data.BarsPeriod object containing information on the period used by the Bars object on the chart.

Syntax
------

<ChartControl>.BarsPeriod

Examples
--------

| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale)  {     BarsPeriod period = chartControl.BarsPeriod;        // Print the period (interval) of the Bars object on the chart     Print(period);  } |

 

 

Based on the image below, BarsPeriod confirms that the primary Bars object on the chart is configured to a 5-minute interval.

 

![ChartControl_BarsPeriod](chartcontrol_barsperiod.png)