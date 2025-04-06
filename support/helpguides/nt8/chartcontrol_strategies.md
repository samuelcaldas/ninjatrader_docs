



Strategies

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](chartcontrol_strategies.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Common](common.htm) > [Charts](chart.htm) > [ChartControl](chartcontrol.htm) >  Strategies | [Previous page](slotspainted.htm) [Return to chapter overview](chartcontrol.htm) [Next page](timepainted.htm) |

Definition
----------

A collection of strategies configured on the chart.

Property Value
--------------

A ChartObjectCollection of StrategyRenderBase objects containing information on all configured strategies on the chart.

Syntax
------

<ChartControl>.Strategies

Examples
--------

| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale)  {     // Print the number of strategies configured on the chart     if (chartControl.Strategies.Count > 0)              Print(chartControl.Strategies[0].Name);  } |