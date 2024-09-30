
NinjaScript \> Language Reference \> Strategy \> TradesPerformanceValues \> LargestLoser

LargestLoser

| \<\< [Click to Display Table of Contents](largestloser.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> [TradesPerformanceValues](tradesperformancevalues.md) \> LargestLoser | [Previous page](drawdown.md) [Return to chapter overview](tradesperformancevalues.md) [Next page](largestwinner.md) |
| --- | --- |
## Definition
Returns the largest loss amount of the collection.  

 
## Property Value
A double value that represents the largest loss amount of the collection.
 
## Syntax
\<TradeCollection\>.TradesPerformance.\<TradesPerformanceValues\>.LargestLoser

## 
## Examples

| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the largest loss of all trades in currency      Print("Largest loss of all trades is: " \+ SystemPerformance.AllTrades.TradesPerformance.Currency.LargestLoser); } |
