


NinjaScript \> Language Reference \> Strategy \> PerformanceMetrics






















PerformanceMetrics







| \<\< [Click to Display Table of Contents](strategy_performancemetrics.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> PerformanceMetrics | [Previous page](orderfillresolutionvalue.md) [Return to chapter overview](strategy.md) [Next page](strategy_plots.md) |
| --- | --- |











## Definition


Holds an array of [PerformanceMetrics](performancemetrics.md) objects that represent custom metrics that can be used for strategy calcuations.


 


Index value is based on the the array of Bars objects added via the [AddPerformanceMetric](addperformancemetric.md) method. 


 


## Property Value


An array of [PerformanceMetrics](performancemetrics.md) objects.


 


## Syntax
PerformanceMetrics\[int index]


## 


 


## Examples




| ns |
| --- |
| // Define a new SampleCumProfit object NinjaTrader.NinjaScript.PerformanceMetrics.SampleCumProfit myProfit;   protected override void OnStateChange() {    if (State \=\= State.Configure)    {      // Instantiate myProfit to a new instance of SampleCumProfit      myProfit \= new NinjaTrader.NinjaScript.PerformanceMetrics.SampleCumProfit();             // Use AddPerformanceMetric to add myProfit to the strategy      AddPerformanceMetric(myProfit);    } }   protected override void OnBarUpdate() {    // Print a string representing the Type of the performance metric at Index 0 of the PerformanceMetrics collection    Print(PerformanceMetrics\[0]); } |









