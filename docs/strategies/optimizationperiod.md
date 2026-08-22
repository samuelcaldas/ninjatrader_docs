# OptimizationPeriod

## Definition

Reserved for [Walk-Forward Optimization](walk_forward_optimize_a_strate.md), this property determines the number of days used for the "in sample" backtest period for a given strategy.  See also [TestPeriod](testperiod.md).

> **Note:** This property should ONLY be called from the [OnStateChange()](../language_reference/onstatechange.md) method during State.SetDefaults

## Property Value

An int value representing the number of "in sample" days used for walk-forward optimization; Default value is set to 10.

## Syntax

OptimizationPeriod

## Examples

```csharp
protected override void OnStateChange()
{
    if (State == State.SetDefaults)
    {
        //set the default optimization period to 20 days for WFOs
        OptimizationPeriod = 20;
    }
}
```
