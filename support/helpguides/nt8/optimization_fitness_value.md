



Value

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](optimization_fitness_value.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Optimization Fitness](optimization_fitness.htm) >  Value | [Previous page](oncalculateperformancevalue.htm) [Return to chapter overview](optimization_fitness.htm) [Next page](optimizer.htm) |

Definition
----------

The value an optimization would be calculating against when using this Optimization Fitness.

Property Value
--------------

A double value.

Syntax
------

Value

Examples
--------

| ns |
| --- |
| protected override void OnCalculatePerformanceValue(StrategyBase strategy)  {      Value = strategy.SystemPerformance.AllTrades.TradesPerformance.Percent.Drawdown;  } |