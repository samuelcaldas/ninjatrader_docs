
NinjaScript \> Language Reference \> Performance Metrics \> PerformanceUnit

PerformanceUnit

| \<\< [Click to Display Table of Contents](performanceunit.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Performance Metrics](performance_metrics-1.md) \> PerformanceUnit | [Previous page](onmergeperformancemetric-1.md) [Return to chapter overview](performance_metrics-1.md) [Next page](performancemetric_values-1.md) |
| --- | --- |
## Definition
Enumeration defining each type of PerformanceUnit calculated by NinjaTrader. Used to store a value for this performance type in PerformanceMetrics.
 
## Syntax
PerformanceUnit.Currency
PerformanceUnit.Percent
PerformanceUnit.Pips
PerformanceUnit.Points
PerformanceUnit.Ticks
 
## Examples

| ns |
| --- |
| //Prints unrealized PnL in ticks at the close of each bar Print(Position.GetUnrealizedProfitLoss(PerformanceUnit.Ticks, Close\[0])); |
