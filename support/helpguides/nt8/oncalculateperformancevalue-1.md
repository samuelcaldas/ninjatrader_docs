



OnCalculatePerformanceValue()

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\oncalculateperformancevalue.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Optimization Fitness](optimization_fitness-1.htm) >  OnCalculatePerformanceValue() | [Previous page](optimization_fitness-1.htm) [Return to chapter overview](optimization_fitness-1.htm) [Next page](optimization_fitness_value-1.htm) |

Definition
----------

This method calculates the value for the Optimization Fitness.

Syntax
------

protected override void OnCalculatePerformanceValue(StrategyBase strategy)   
{

}

Examples
--------

| ns |
| --- |
| protected override void OnCalculatePerformanceValue(StrategyBase strategy)  {      Value = strategy.SystemPerformance.AllTrades.TradesPerformance.Percent.Drawdown;  } |