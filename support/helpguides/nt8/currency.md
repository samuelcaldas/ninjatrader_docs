



Currency

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](currency.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Strategy](strategy.htm) > [TradeCollection](tradecollection.htm) > [TradesPerformance](tradesperformance.htm) >  Currency | [Previous page](averagetotalefficiency.htm) [Return to chapter overview](tradesperformance.htm) [Next page](grossloss.htm) |

Definition
----------

Returns a [TradesPerformanceValues](tradesperformancevalues.htm) object in currency.

Property Value
--------------

A TradesPerformanceValues object that is represented in currency.

Syntax 
<TradeCollection>.TradesPerformance.Currency
----------------------------------------------------

Examples
--------

| ns |
| --- |
| protected override void OnBarUpdate()  {       // Print out the avg. profit of all trades in currency       Print("Average profit: " + SystemPerformance.AllTrades.TradesPerformance.Currency.AverageProfit);  } |