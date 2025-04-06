



AverageMfe

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](averagemfe.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Strategy](strategy.htm) > [TradesPerformanceValues](tradesperformancevalues.htm) >  AverageMfe | [Previous page](averagemae.htm) [Return to chapter overview](tradesperformancevalues.htm) [Next page](averageprofit.htm) |

Definition
----------

Returns the average MFE (max favorable excursion) of the collection.

Property Value
--------------

A double value that represents the average MFE of the collection.

Syntax 
<TradeCollection>.TradesPerformance.<TradesPerformanceValues>.AverageMfe
--------------------------------------------------------------------------------

Examples
--------

| ns |
| --- |
| protected override void OnBarUpdate()  {       // Print out the average MFE of all trades in currency       Print("Average MFE of all trades is: " + SystemPerformance.AllTrades.TradesPerformance.Currency.AverageMfe);  } |