
NinjaScript > Language Reference > Strategy > TradesPerformanceValues > LargestWinner

LargestWinner

| << [Click to Display Table of Contents](largestwinner.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Strategy](strategy.md) > [TradesPerformanceValues](tradesperformancevalues.md) > LargestWinner | [Previous page](largestloser.md) [Return to chapter overview](tradesperformancevalues.md) [Next page](profitpermonth.md) |
| --- | --- |
## Definition
Returns the largest win amount of the collection.  

 
## Property Value
A double value that represents the largest win amount of the collection.
 
## Syntax
<TradeCollection>.TradesPerformance.<TradesPerformanceValues>.LargestWinner

## 
## Examples

| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the largest win of all trades in currency      Print("Largest win of all trades is: " + SystemPerformance.AllTrades.TradesPerformance.Currency.LargestWinner); } |
