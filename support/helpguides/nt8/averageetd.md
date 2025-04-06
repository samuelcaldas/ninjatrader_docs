



AverageEtd

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](averageetd.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Strategy](strategy.htm) > [TradesPerformanceValues](tradesperformancevalues.htm) >  AverageEtd | [Previous page](tradesperformancevalues.htm) [Return to chapter overview](tradesperformancevalues.htm) [Next page](averagemae.htm) |

Definition
----------

Returns the average ETD (end trade draw down) of the collection.

Property Value
--------------

A double value that represents the average ETD of the collection.

Syntax 
<TradeCollection>.TradesPerformance.<TradesPerformanceValues>.AverageEtd
--------------------------------------------------------------------------------

Examples
--------

| ns |
| --- |
| protected override void OnBarUpdate()  {       // Print out the average ETD of all trades in currency       Print("Average ETD of all trades is: " + SystemPerformance.AllTrades.TradesPerformance.Currency.AverageEtd);  } |