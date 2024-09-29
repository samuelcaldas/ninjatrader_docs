


NinjaScript \> Language Reference \> Strategy \> TradesPerformanceValues \> AverageMae






















AverageMae







| \<\< [Click to Display Table of Contents](averagemae.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Strategy](strategy-1.md) \> [TradesPerformanceValues](tradesperformancevalues-1.md) \> AverageMae | [Previous page](averageetd-1.md) [Return to chapter overview](tradesperformancevalues-1.md) [Next page](averagemfe-1.md) |
| --- | --- |











## Definition


Returns the average MAE (max adverse excursion) of the collection.  

 


## Property Value


A double value that represents the average MAE of the collection.


 


## Syntax
\<TradeCollection\>.TradesPerformance.\<TradesPerformanceValues\>.AverageMae


 


 


## 


## Examples




| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the average MAE of all trades in currency      Print("Average MAE of all trades is: " \+ SystemPerformance.AllTrades.TradesPerformance.Currency.AverageMae); } |









