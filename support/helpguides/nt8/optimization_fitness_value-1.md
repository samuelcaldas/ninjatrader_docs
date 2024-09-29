


NinjaScript \> Language Reference \> Optimization Fitness \> Value






















Value







| \<\< [Click to Display Table of Contents](optimization_fitness_value.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Optimization Fitness](optimization_fitness-1.md) \> Value | [Previous page](oncalculateperformancevalue-1.md) [Return to chapter overview](optimization_fitness-1.md) [Next page](optimizer-1.md) |
| --- | --- |











## Definition


The value an optimization would be calculating against when using this Optimization Fitness.


 


## Property Value


A double value.


 


## Syntax


Value


 


 


## Examples




| ns |
| --- |
| protected override void OnCalculatePerformanceValue(StrategyBase strategy) {      Value \= strategy.SystemPerformance.AllTrades.TradesPerformance.Percent.Drawdown; } |









