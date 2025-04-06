



AverageMfe

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\averagemfe.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Strategy](strategy-1.htm) > [TradesPerformanceValues](tradesperformancevalues-1.htm) >  AverageMfe | [Previous page](averagemae-1.htm) [Return to chapter overview](tradesperformancevalues-1.htm) [Next page](averageprofit-1.htm) |

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