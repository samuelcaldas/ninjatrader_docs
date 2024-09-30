
NinjaScript > Language Reference > Performance Metrics > OnCopyTo()

OnCopyTo()

| << [Click to Display Table of Contents](oncopyto.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Performance Metrics](performance_metrics-1.md) > OnCopyTo() | [Previous page](onaddtrade-1.md) [Return to chapter overview](performance_metrics-1.md) [Next page](onmergeperformancemetric-1.md) |
| --- | --- |
## Definition
Called as the values of a trade metric are saved.
 
## Syntax
protected override void OnCopyTo(PerformanceMetricBase target)  

{  

     

}
## 
## Examples

| ns |
| --- |
| protected override void OnCopyTo(PerformanceMetricBase target) {    // You need to cast, in order to access the right type    SampleCumProfit targetMetrics = (target as SampleCumProfit);      if (targetMetrics != null)      Array.Copy(Values, targetMetrics.Values, Values.Length); } |
