
NinjaScript \> Language Reference \> Strategy \> TradesPerformanceValues \> LargestWinner

LargestWinner

| \<\< [Click to Display Table of Contents](largestwinner.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Strategy](strategy-1.md) \> [TradesPerformanceValues](tradesperformancevalues-1.md) \> LargestWinner | [Previous page](largestloser-1.md) [Return to chapter overview](tradesperformancevalues-1.md) [Next page](profitpermonth-1.md) |
| --- | --- |
## Definition
Returns the largest win amount of the collection.  

 
## Property Value
A double value that represents the largest win amount of the collection.
 
## Syntax
\<TradeCollection\>.TradesPerformance.\<TradesPerformanceValues\>.LargestWinner

## 
## Examples

| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the largest win of all trades in currency      Print("Largest win of all trades is: " \+ SystemPerformance.AllTrades.TradesPerformance.Currency.LargestWinner); } |
