



PerformanceUnit

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](performanceunit.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Performance Metrics](performance_metrics.htm) >  PerformanceUnit | [Previous page](onmergeperformancemetric.htm) [Return to chapter overview](performance_metrics.htm) [Next page](performancemetric_values.htm) |

Definition
----------

Enumeration defining each type of PerformanceUnit calculated by NinjaTrader. Used to store a value for this performance type in PerformanceMetrics.

Syntax
------

PerformanceUnit.Currency

PerformanceUnit.Percent

PerformanceUnit.Pips

PerformanceUnit.Points

PerformanceUnit.Ticks

Examples
--------

| ns |
| --- |
| //Prints unrealized PnL in ticks at the close of each bar  Print(Position.GetUnrealizedProfitLoss(PerformanceUnit.Ticks, Close[0])); |