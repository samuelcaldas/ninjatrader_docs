


NinjaScript \> Language Reference \> Optimization Fitness \> OnCalculatePerformanceValue()






















OnCalculatePerformanceValue()







| \<\< [Click to Display Table of Contents](oncalculateperformancevalue.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Optimization Fitness](optimization_fitness-1.md) \> OnCalculatePerformanceValue() | [Previous page](optimization_fitness-1.md) [Return to chapter overview](optimization_fitness-1.md) [Next page](optimization_fitness_value-1.md) |
| --- | --- |











## Definition


This method calculates the value for the Optimization Fitness.


 


## Syntax


protected override void OnCalculatePerformanceValue(StrategyBase strategy)   

{


   

}


 


 


## Examples




| ns |
| --- |
| protected override void OnCalculatePerformanceValue(StrategyBase strategy) {      Value \= strategy.SystemPerformance.AllTrades.TradesPerformance.Percent.Drawdown; } |









