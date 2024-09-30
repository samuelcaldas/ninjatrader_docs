
NinjaScript \> Language Reference \> Performance Metrics \> OnMergePerformanceMetric()

OnMergePerformanceMetric()

| \<\< [Click to Display Table of Contents](onmergeperformancemetric.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Performance Metrics](performance_metrics-1.md) \> OnMergePerformanceMetric() | [Previous page](oncopyto-1.md) [Return to chapter overview](performance_metrics-1.md) [Next page](performanceunit-1.md) |
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
