



AddPerformanceMetric()

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\addperformancemetric.md) >>  **Navigation:**  [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Strategy](strategy-1.md) >  AddPerformanceMetric() | [Previous page](addchartindicator-1.md) [Return to chapter overview](strategy-1.md) [Next page](atm_strategy_methods-1.md) |

Definition
----------

Adds an instance of custom [Performance Metric](performancemetrics-1.md) to a strategy used in strategy calculations.

Method Return Value
-------------------

This method does not return a value.

Syntax 
AddPerformanceMetric(PerformanceMetricBaseperformanceMetric)
--------------------------------------------------------------------

|  |
| --- |
| State.Configure |

Parameters
----------

|  |  |
| --- | --- |
| performanceMetric | The performance metric object to be added |

Examples
--------

|  |
| --- |
| OnStateChange()  {  State.Configure)  {  NinjaTrader.NinjaScript.PerformanceMetrics.SampleCumProfit());  }  } |