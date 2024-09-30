
NinjaScript \> Language Reference \> Strategy \> TradeCollection \> TradesPerformance \> MaxConsecutiveWinner

MaxConsecutiveWinner

| \<\< [Click to Display Table of Contents](maxconsecutivewinner.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> [TradeCollection](tradecollection.md) \> [TradesPerformance](tradesperformance.md) \> MaxConsecutiveWinner | [Previous page](maxconsecutiveloser.md) [Return to chapter overview](tradesperformance.md) [Next page](maxtimetorecover.md) |
| --- | --- |
## Definition
Returns the maximum number of consecutive winners seen.  

 
## Property Value
An int value that represents the maximum number of consecutive winners seen.
 
## Syntax
\<TradeCollection\>.TradesPerformance.MaxConsecutiveWinner

## 
## Examples

| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the max consecutive winners of all trades      Print("Max \# of consecutive winners is: " \+ SystemPerformance.AllTrades.TradesPerformance.MaxConsecutiveWinner); } |
