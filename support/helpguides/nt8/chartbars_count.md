



Count

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](chartbars_count.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Common](common.htm) > [Charts](chart.htm) > [ChartBars](chartbars.htm) >  Count | [Previous page](chartbars_bars.htm) [Return to chapter overview](chartbars.htm) [Next page](chartbars_fromindex.htm) |

Definition
----------

The total number of [ChartBars](chartbars.htm) in the charts primary data series

Property Value
--------------

An int value representing the the total number of bars.

Syntax
------

ChartBars.Count

Examples
--------

| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale)  {     if(ChartBars != null)     {       Print("ChartBars contain " + ChartBars.Count + " bars");       //Output:  ChartBars contain 73 bars      }  } |