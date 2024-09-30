
NinjaScript \> Language Reference \> Strategy \> TradesPerformanceValues \> AverageMfe
AverageMfe
| \<\< [Click to Display Table of Contents](averagemfe.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Strategy](strategy-1.md) \> [TradesPerformanceValues](tradesperformancevalues-1.md) \> AverageMfe | [Previous page](averagemae-1.md) [Return to chapter overview](tradesperformancevalues-1.md) [Next page](averageprofit-1.md) |
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

