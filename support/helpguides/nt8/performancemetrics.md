



PerformanceMetrics

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](performancemetrics.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Strategy](strategy.htm) > [TradeCollection](tradecollection.htm) > [TradesPerformance](tradesperformance.htm) >  PerformanceMetrics | [Previous page](percent.htm) [Return to chapter overview](tradesperformance.htm) [Next page](pips.htm) |

Definition
----------

Returns a collection of custom [Performance Metrics](performance_metrics.htm). These need to have been enabled in [Tools > Options > General](general_section.htm) to be able to use them.

Syntax 
<TradeCollection>.TradesPerformance.PerformanceMetrics
--------------------------------------------------------------

Examples
--------

| ns |
| --- |
| protected override void OnBarUpdate()  {       // Print out the number of enabled custom Performance Metrics       Print("Number of Performance Metrics: "           + SystemPerformance.AllTrades.TradesPerformance.PerformanceMetrics.Length);          // Find a the value of a specific custom Performance Metric named "MyPerformanceMetric"       for (int i = 0; i < SystemPerformance.AllTrades.TradesPerformance.PerformanceMetrics.Length; i++)       {           if (SystemPerformance.AllTrades.TradesPerformance.PerformanceMetrics[i] is                  NinjaTrader.NinjaScript.PerformanceMetrics.MyPerformanceMetric)           {                 Print((SystemPerformance.AllTrades.TradesPerformance.PerformanceMetrics[i] as                      NinjaTrader.NinjaScript.PerformanceMetrics.MyPerformanceMetric).Values[0]);           }       }  } |