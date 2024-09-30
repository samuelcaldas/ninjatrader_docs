
NinjaScript > Language Reference > Strategy > TradeCollection > TradesPerformance > Percent

Percent

| << [Click to Display Table of Contents](percent.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Strategy](strategy-1.md) > [TradeCollection](tradecollection-1.md) > [TradesPerformance](tradesperformance-1.md) > Percent | [Previous page](netprofit-1.md) [Return to chapter overview](tradesperformance-1.md) [Next page](performancemetrics-1.md) |
| --- | --- |
## Definition
Returns a [TradesPerformanceValues](tradesperformancevalues-1.md) object in percent.  

 
## Property Value
A TradesPerformanceValues object that is represented in percent.
 
## Syntax
<TradeCollection>.TradesPerformance.Percent

## Examples

| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the avg. profit of all trades in percent      Print("Average profit: " + SystemPerformance.AllTrades.TradesPerformance.Percent.AverageProfit); } |
