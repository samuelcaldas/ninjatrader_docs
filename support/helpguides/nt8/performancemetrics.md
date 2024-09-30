
NinjaScript > Language Reference > Strategy > TradeCollection > TradesPerformance > PerformanceMetrics

PerformanceMetrics

| << [Click to Display Table of Contents](performancemetrics.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Strategy](strategy.md) > [TradeCollection](tradecollection.md) > [TradesPerformance](tradesperformance.md) > PerformanceMetrics | [Previous page](percent.md) [Return to chapter overview](tradesperformance.md) [Next page](pips.md) |
| --- | --- |
## Definition
Returns a collection of custom [Performance Metrics](performance_metrics.md). These need to have been enabled in [Tools > Options > General](general_section.md) to be able to use them.
 
## Syntax
<TradeCollection>.TradesPerformance.PerformanceMetrics

## Examples

| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the number of enabled custom Performance Metrics      Print("Number of Performance Metrics: "          + SystemPerformance.AllTrades.TradesPerformance.PerformanceMetrics.Length);        // Find a the value of a specific custom Performance Metric named "MyPerformanceMetric"      for (int i = 0; i < SystemPerformance.AllTrades.TradesPerformance.PerformanceMetrics.Length; i++)      {          if (SystemPerformance.AllTrades.TradesPerformance.PerformanceMetrics[i] is                 NinjaTrader.NinjaScript.PerformanceMetrics.MyPerformanceMetric)          {                Print((SystemPerformance.AllTrades.TradesPerformance.PerformanceMetrics[i] as                     NinjaTrader.NinjaScript.PerformanceMetrics.MyPerformanceMetric).Values[0]);          }      } } |
 
