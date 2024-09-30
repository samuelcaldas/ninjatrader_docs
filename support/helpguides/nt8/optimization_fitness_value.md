
NinjaScript \> Language Reference \> Optimization Fitness \> Value

Value

| \<\< [Click to Display Table of Contents](optimization_fitness_value.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Optimization Fitness](optimization_fitness.md) \> Value | [Previous page](oncalculateperformancevalue.md) [Return to chapter overview](optimization_fitness.md) [Next page](optimizer.md) |
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
