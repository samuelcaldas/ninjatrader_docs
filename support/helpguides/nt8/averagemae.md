
NinjaScript \> Language Reference \> Strategy \> TradesPerformanceValues \> AverageMae

AverageMae
| \<\< [Click to Display Table of Contents](averagemae.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> [TradesPerformanceValues](tradesperformancevalues.md) \> AverageMae | [Previous page](averageetd.md) [Return to chapter overview](tradesperformancevalues.md) [Next page](averagemfe.md) |
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
