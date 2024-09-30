
NinjaScript \> Language Reference \> Strategy \> TradeCollection \> TradesPerformance \> Ticks
Ticks
| \<\< [Click to Display Table of Contents](ticks.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Strategy](strategy-1.md) \> [TradeCollection](tradecollection-1.md) \> [TradesPerformance](tradesperformance-1.md) \> Ticks | [Previous page](sortinoratio-1.md) [Return to chapter overview](tradesperformance-1.md) [Next page](totalcommission-1.md) |
| --- | --- |
## Definition
Returns a [TradesPerformanceValues](tradesperformancevalues-1.md) object in ticks.  

 
## Property Value
A TradesPerformanceValues object that is represented in ticks.
 
## Syntax
\<TradeCollection\>.TradesPerformance.Ticks

## Examples
| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the avg. profit of all trades in ticks      Print("Average profit: " \+ SystemPerformance.AllTrades.TradesPerformance.Ticks.AverageProfit); } |

 
