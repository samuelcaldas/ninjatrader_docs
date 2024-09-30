
NinjaScript > Language Reference > Optimization Fitness > OnCalculatePerformanceValue()

OnCalculatePerformanceValue()

| << [Click to Display Table of Contents](oncalculateperformancevalue.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Optimization Fitness](optimization_fitness.md) > OnCalculatePerformanceValue() | [Previous page](optimization_fitness.md) [Return to chapter overview](optimization_fitness.md) [Next page](optimization_fitness_value.md) |
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
| protected override void OnCalculatePerformanceValue(StrategyBase strategy) {      Value = strategy.SystemPerformance.AllTrades.TradesPerformance.Percent.Drawdown; } |
