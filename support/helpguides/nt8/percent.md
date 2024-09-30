
NinjaScript > Language Reference > Strategy > TradeCollection > TradesPerformance > Percent

Percent

| << [Click to Display Table of Contents](percent.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Strategy](strategy.md) > [TradeCollection](tradecollection.md) > [TradesPerformance](tradesperformance.md) > Percent | [Previous page](netprofit.md) [Return to chapter overview](tradesperformance.md) [Next page](performancemetrics.md) |
| --- | --- |
## Definition
Returns a [TradesPerformanceValues](tradesperformancevalues.md) object in percent.  

 
## Property Value
A TradesPerformanceValues object that is represented in percent.
 
## Syntax
<TradeCollection>.TradesPerformance.Percent

## Examples

| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the avg. profit of all trades in percent      Print("Average profit: " + SystemPerformance.AllTrades.TradesPerformance.Percent.AverageProfit); } |
