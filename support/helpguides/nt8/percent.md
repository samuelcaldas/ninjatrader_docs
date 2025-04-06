



Percent

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](percent.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Strategy](strategy.htm) > [TradeCollection](tradecollection.htm) > [TradesPerformance](tradesperformance.htm) >  Percent | [Previous page](netprofit.htm) [Return to chapter overview](tradesperformance.htm) [Next page](performancemetrics.htm) |

Definition
----------

Returns a [TradesPerformanceValues](tradesperformancevalues.htm) object in percent.

Property Value
--------------

A TradesPerformanceValues object that is represented in percent.

Syntax 
<TradeCollection>.TradesPerformance.Percent
---------------------------------------------------

Examples
--------

| ns |
| --- |
| protected override void OnBarUpdate()  {       // Print out the avg. profit of all trades in percent       Print("Average profit: " + SystemPerformance.AllTrades.TradesPerformance.Percent.AverageProfit);  } |