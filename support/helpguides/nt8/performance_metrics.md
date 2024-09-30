
NinjaScript > Language Reference > Performance Metrics

Performance Metrics

| << [Click to Display Table of Contents](performance_metrics.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > Performance Metrics | [Previous page](supportsmultiobjectiveoptimiza.md) [Return to chapter overview](language_reference_wip.md) [Next page](format.md) |
| --- | --- |
Custom Performance Metrics can be used when generating Trade Performance statistics. 
 
Once custom performance metrics are created be sure to enable their usage in [Tools > Options > General](general_section.md) or else they will not be available in the [Strategy Analyzer](strategy_analyzer.md) or [Trade Performance](trade_performance.md) windows.
 
## In this section

| [Format()](format.md) | This method allows you to customize the rendering of the performance value on the Summary grid. |
| --- | --- |
| [OnAddTrade()](onaddtrade.md) | This method is called as each trade is added. |
| [OnCopyTo()](oncopyto.md) | Called as the values of a trade metric are saved. |
| [OnMergePerformanceMetric()](onmergeperformancemetric.md) | This method is called when the Performance Metric would be aggregated and merged together. |
| [PerformanceUnit](performanceunit.md) | Enumeration defining each type of PerformanceUnit calculated by NinjaTrader. Used to store a value for this performance type in PerformanceMetrics. |
| [Values](performancemetric_values.md) | The Values array holds an 5 values corresponding to each Cbi.PerformanceUnit. |
