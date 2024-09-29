


NinjaScript \> Language Reference \> Performance Metrics






















Performance Metrics







| \<\< [Click to Display Table of Contents](performance_metrics.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> Performance Metrics | [Previous page](supportsmultiobjectiveoptimiza-1.md) [Return to chapter overview](language_reference_wip-1.md) [Next page](format-1.md) |
| --- | --- |











Custom Performance Metrics can be used when generating Trade Performance statistics. 


 


Once custom performance metrics are created be sure to enable their usage in [Tools \> Options \> General](general_section-1.md) or else they will not be available in the [Strategy Analyzer](strategy_analyzer-1.md) or [Trade Performance](trade_performance-1.md) windows.


 


## In this section




| [Format()](format-1.md) | This method allows you to customize the rendering of the performance value on the Summary grid. |
| --- | --- |
| [OnAddTrade()](onaddtrade-1.md) | This method is called as each trade is added. |
| [OnCopyTo()](oncopyto-1.md) | Called as the values of a trade metric are saved. |
| [OnMergePerformanceMetric()](onmergeperformancemetric-1.md) | This method is called when the Performance Metric would be aggregated and merged together. |
| [PerformanceUnit](performanceunit-1.md) | Enumeration defining each type of PerformanceUnit calculated by NinjaTrader. Used to store a value for this performance type in PerformanceMetrics. |
| [Values](performancemetric_values-1.md) | The Values array holds an 5 values corresponding to each Cbi.PerformanceUnit. |









