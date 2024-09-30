
NinjaScript \> Language Reference \> Strategy \> AddPerformanceMetric()

AddPerformanceMetric()
| \<\< [Click to Display Table of Contents](addperformancemetric.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> AddPerformanceMetric() | [Previous page](addchartindicator.md) [Return to chapter overview](strategy.md) [Next page](atm_strategy_methods.md) |
| --- | --- |
## Definition
Adds an instance of custom [Performance Metric](performancemetrics.md) to a strategy used in strategy calculations.
 
## Method Return Value
This method does not return a value.
 
## Syntax
AddPerformanceMetric(PerformanceMetricBase performanceMetric)
 
| Warning:  This method should ONLY be called from the [OnStateChange()](onstatechange.md) method during State.Configure |
| --- |

## Parameters
| performanceMetric | The performance metric object to be added |
| --- | --- |

## 
## 
## 
## Examples
| ns |
| --- |
| protected override void OnStateChange() {      if (State \=\= State.Configure)      {          AddPerformanceMetric(new NinjaTrader.NinjaScript.PerformanceMetrics.SampleCumProfit());      } } |

 
