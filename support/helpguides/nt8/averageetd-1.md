
NinjaScript \> Language Reference \> Strategy \> TradesPerformanceValues \> AverageEtd

AverageEtd
| \<\< [Click to Display Table of Contents](averageetd.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Strategy](strategy-1.md) \> [TradesPerformanceValues](tradesperformancevalues-1.md) \> AverageEtd | [Previous page](tradesperformancevalues-1.md) [Return to chapter overview](tradesperformancevalues-1.md) [Next page](averagemae-1.md) |
| --- | --- |
## Definition
Returns the average ETD (end trade draw down) of the collection.  

 
## Property Value
A double value that represents the average ETD of the collection.
 
## Syntax
\<TradeCollection\>.TradesPerformance.\<TradesPerformanceValues\>.AverageEtd

## 
## Examples
| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the average ETD of all trades in currency      Print("Average ETD of all trades is: " \+ SystemPerformance.AllTrades.TradesPerformance.Currency.AverageEtd); } |
