
NinjaScript \> Language Reference \> Strategy \> TradesPerformanceValues \> AverageEtd

AverageEtd
| \<\< [Click to Display Table of Contents](averageetd.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> [TradesPerformanceValues](tradesperformancevalues.md) \> AverageEtd | [Previous page](tradesperformancevalues.md) [Return to chapter overview](tradesperformancevalues.md) [Next page](averagemae.md) |
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
