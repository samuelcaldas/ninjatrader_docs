



AverageEtd

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\averageetd.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Strategy](strategy-1.htm) > [TradesPerformanceValues](tradesperformancevalues-1.htm) >  AverageEtd | [Previous page](tradesperformancevalues-1.htm) [Return to chapter overview](tradesperformancevalues-1.htm) [Next page](averagemae-1.htm) |

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