# Value

## Definition

The value an optimization would be calculating against when using this Optimization Fitness.

## Property Value

A double value.

## Syntax

Value

## Examples

```csharp
protected override void OnCalculatePerformanceValue(StrategyBase strategy)
{
    Value = strategy.SystemPerformance.AllTrades.TradesPerformance.Percent.Drawdown;
}
```
