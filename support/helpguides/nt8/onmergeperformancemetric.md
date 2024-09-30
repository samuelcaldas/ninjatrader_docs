
NinjaScript \> Language Reference \> Performance Metrics \> OnMergePerformanceMetric()

OnMergePerformanceMetric()

| \<\< [Click to Display Table of Contents](onmergeperformancemetric.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Performance Metrics](performance_metrics.md) \> OnMergePerformanceMetric() | [Previous page](oncopyto.md) [Return to chapter overview](performance_metrics.md) [Next page](performanceunit.md) |
| --- | --- |
## Definition
This method is called when the Performance Metric would be aggregated and merged together (E.g. on the Strategy Analyzer's total row).
 
## Syntax
protected override void OnMergePerformanceMetric(PerformanceMetricBase merge)   

{  

   

}
## 
## Examples

| ns |
| --- |
| protected override void OnMergePerformanceMetric(PerformanceMetricBase target) {    // You need to cast, in order to access the right type    SampleCumProfit targetMetrics \= (target as SampleCumProfit);      // This is just a simple weighted average sample    if (targetMetrics !\= null \&\& TradesPerformance.TradesCount \+ targetMetrics.TradesPerformance.TradesCount \> 0)      for (int i \= 0; i \< Values.Length; i\+\+)          targetMetrics.Values\[i] \= (targetMetrics.Values\[i] \* targetMetrics.TradesPerformance.TradesCount \+ Values\[i] \* TradesPerformance.TradesCount) / (TradesPerformance.TradesCount \+ targetMetrics.TradesPerformance.TradesCount); } |
