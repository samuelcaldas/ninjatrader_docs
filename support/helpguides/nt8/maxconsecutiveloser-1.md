
NinjaScript > Language Reference > Strategy > TradeCollection > TradesPerformance > MaxConsecutiveLoser

MaxConsecutiveLoser

| << [Click to Display Table of Contents](maxconsecutiveloser.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Strategy](strategy-1.md) > [TradeCollection](tradecollection-1.md) > [TradesPerformance](tradesperformance-1.md) > MaxConsecutiveLoser | [Previous page](longestflatperiod-1.md) [Return to chapter overview](tradesperformance-1.md) [Next page](maxconsecutivewinner-1.md) |
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
