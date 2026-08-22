# AddPerformanceMetric()

## Definition

Adds an instance of custom [Performance Metric](performancemetrics.md) to a strategy used in strategy calculations.

## Method Return Value

This method does not return a value.

## Syntax

`AddPerformanceMetric(PerformanceMetricBaseperformanceMetric)`

> State.Configure

## Parameters

| Name / Option | Description |
| --- | --- |
| performanceMetric | The performance metric object to be added |

## Examples

![Ns](../images/ns.png)

```csharp
OnStateChange()
{
    State.Configure)
    {
        NinjaTrader.NinjaScript.PerformanceMetrics.SampleCumProfit());
    }
}
```