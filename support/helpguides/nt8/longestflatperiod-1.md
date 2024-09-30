
NinjaScript > Language Reference > Strategy > TradeCollection > TradesPerformance > LongestFlatPeriod

LongestFlatPeriod

| << [Click to Display Table of Contents](longestflatperiod.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Strategy](strategy-1.md) > [TradeCollection](tradecollection-1.md) > [TradesPerformance](tradesperformance-1.md) > LongestFlatPeriod | [Previous page](grossprofit-1.md) [Return to chapter overview](tradesperformance-1.md) [Next page](maxconsecutiveloser-1.md) |
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
