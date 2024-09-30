
NinjaScript \> Language Reference \> Strategy \> TradesPerformanceValues \> AverageMfe

AverageMfe
| \<\< [Click to Display Table of Contents](averagemfe.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> [TradesPerformanceValues](tradesperformancevalues.md) \> AverageMfe | [Previous page](averagemae.md) [Return to chapter overview](tradesperformancevalues.md) [Next page](averageprofit.md) |
| --- | --- |
## Definition
Returns the average MFE (max favorable excursion) of the collection.  

 
## Property Value
A double value that represents the average MFE of the collection.
 
## Syntax
\<TradeCollection\>.TradesPerformance.\<TradesPerformanceValues\>.AverageMfe

## 
## Examples
| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the average MFE of all trades in currency      Print("Average MFE of all trades is: " \+ SystemPerformance.AllTrades.TradesPerformance.Currency.AverageMfe); } |
