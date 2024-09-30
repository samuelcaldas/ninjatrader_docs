
NinjaScript > Language Reference > Strategy > TradeCollection > TradesPerformance > MaxConsecutiveLoser

MaxConsecutiveLoser

| << [Click to Display Table of Contents](maxconsecutiveloser.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Strategy](strategy.md) > [TradeCollection](tradecollection.md) > [TradesPerformance](tradesperformance.md) > MaxConsecutiveLoser | [Previous page](longestflatperiod.md) [Return to chapter overview](tradesperformance.md) [Next page](maxconsecutivewinner.md) |
| --- | --- |
## Definition
Returns the maximum number of consecutive losers seen.  

 
## Property Value
An int value that represents the maximum number of consecutive losers seen.
 
## Syntax
<TradeCollection>.TradesPerformance.MaxConsecutiveLoser

## 
## Examples

| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the max consecutive losers of all trades      Print("Max # of consecutive losers is: " + SystemPerformance.AllTrades.TradesPerformance.MaxConsecutiveLoser); } |
