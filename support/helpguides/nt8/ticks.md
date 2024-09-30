
NinjaScript > Language Reference > Strategy > TradeCollection > TradesPerformance > Ticks
Ticks
| << [Click to Display Table of Contents](ticks.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Strategy](strategy.md) > [TradeCollection](tradecollection.md) > [TradesPerformance](tradesperformance.md) > Ticks | [Previous page](sortinoratio.md) [Return to chapter overview](tradesperformance.md) [Next page](totalcommission.md) |
| --- | --- |
## Definition
Returns a [TradesPerformanceValues](tradesperformancevalues.md) object in ticks.  

 
## Property Value
A TradesPerformanceValues object that is represented in ticks.
 
## Syntax
<TradeCollection>.TradesPerformance.Ticks

## Examples
| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the avg. profit of all trades in ticks      Print("Average profit: " + SystemPerformance.AllTrades.TradesPerformance.Ticks.AverageProfit); } |

 
