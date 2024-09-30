
NinjaScript > Language Reference > Strategy > TradeCollection > TradesPerformance > MaxConsecutiveWinner

MaxConsecutiveWinner

| << [Click to Display Table of Contents](maxconsecutivewinner.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Strategy](strategy-1.md) > [TradeCollection](tradecollection-1.md) > [TradesPerformance](tradesperformance-1.md) > MaxConsecutiveWinner | [Previous page](maxconsecutiveloser-1.md) [Return to chapter overview](tradesperformance-1.md) [Next page](maxtimetorecover-1.md) |
| --- | --- |
## Definition
Returns the maximum number of consecutive winners seen.  

 
## Property Value
An int value that represents the maximum number of consecutive winners seen.
 
## Syntax
<TradeCollection>.TradesPerformance.MaxConsecutiveWinner

## 
## Examples

| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the max consecutive winners of all trades      Print("Max # of consecutive winners is: " + SystemPerformance.AllTrades.TradesPerformance.MaxConsecutiveWinner); } |
