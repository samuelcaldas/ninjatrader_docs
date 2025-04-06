



Count

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\chartbars_count.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [Charts](chart-1.htm) > [ChartBars](chartbars-1.htm) >  Count | [Previous page](chartbars_bars-1.htm) [Return to chapter overview](chartbars-1.htm) [Next page](chartbars_fromindex-1.htm) |

Definition
----------

The total number of [ChartBars](chartbars-1.htm) in the charts primary data series

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