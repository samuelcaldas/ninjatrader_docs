
NinjaScript > Language Reference > Strategy > TradesPerformanceValues > LargestLoser

LargestLoser

| << [Click to Display Table of Contents](largestloser.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Strategy](strategy-1.md) > [TradesPerformanceValues](tradesperformancevalues-1.md) > LargestLoser | [Previous page](drawdown-1.md) [Return to chapter overview](tradesperformancevalues-1.md) [Next page](largestwinner-1.md) |
| --- | --- |
## Definition
Returns the largest loss amount of the collection.  

 
## Property Value
A double value that represents the largest loss amount of the collection.
 
## Syntax
<TradeCollection>.TradesPerformance.<TradesPerformanceValues>.LargestLoser

## 
## Examples

| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the largest loss of all trades in currency      Print("Largest loss of all trades is: " + SystemPerformance.AllTrades.TradesPerformance.Currency.LargestLoser); } |
