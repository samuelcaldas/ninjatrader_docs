



Pips

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\pips.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Strategy](strategy-1.htm) > [TradeCollection](tradecollection-1.htm) > [TradesPerformance](tradesperformance-1.htm) >  Pips | [Previous page](performancemetrics-1.htm) [Return to chapter overview](tradesperformance-1.htm) [Next page](points-1.htm) |

Definition
----------

Returns a [TradesPerformanceValues](tradesperformancevalues-1.htm) object in pips.

Property Value
--------------

A TradesPerformanceValues object that is represented in pips.

Syntax 
<TradeCollection>.TradesPerformance.Pips
------------------------------------------------

Examples
--------

| ns |
| --- |
| protected override void OnBarUpdate()  {       // Print out the avg. profit of all trades in pips       Print("Average profit: " + SystemPerformance.AllTrades.TradesPerformance.Pips.AverageProfit);  } |