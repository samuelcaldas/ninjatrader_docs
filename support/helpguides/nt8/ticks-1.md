



Ticks

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\ticks.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Strategy](strategy-1.htm) > [TradeCollection](tradecollection-1.htm) > [TradesPerformance](tradesperformance-1.htm) >  Ticks | [Previous page](sortinoratio-1.htm) [Return to chapter overview](tradesperformance-1.htm) [Next page](totalcommission-1.htm) |

Definition
----------

Returns a [TradesPerformanceValues](tradesperformancevalues-1.htm) object in ticks.

Property Value
--------------

A TradesPerformanceValues object that is represented in ticks.

Syntax 
<TradeCollection>.TradesPerformance.Ticks
-------------------------------------------------

Examples
--------

| ns |
| --- |
| protected override void OnBarUpdate()  {       // Print out the avg. profit of all trades in ticks       Print("Average profit: " + SystemPerformance.AllTrades.TradesPerformance.Ticks.AverageProfit);  } |