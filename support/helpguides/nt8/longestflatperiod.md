
NinjaScript > Language Reference > Strategy > TradeCollection > TradesPerformance > LongestFlatPeriod

LongestFlatPeriod

| << [Click to Display Table of Contents](longestflatperiod.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Strategy](strategy.md) > [TradeCollection](tradecollection.md) > [TradesPerformance](tradesperformance.md) > LongestFlatPeriod | [Previous page](grossprofit.md) [Return to chapter overview](tradesperformance.md) [Next page](maxconsecutiveloser.md) |
| --- | --- |
## Definition
Returns the longest duration of being flat.  

 
## Property Value
A TimeSpan value that represents the longest duration of being flat.
 
## Syntax
<TradeCollection>.TradesPerformance.LongestFlatPeriod

## 
## Examples

| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the longest duration of being flat      Print("Longest flat period: " + SystemPerformance.AllTrades.TradesPerformance.LongestFlatPeriod); } |
