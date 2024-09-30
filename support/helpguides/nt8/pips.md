
NinjaScript \> Language Reference \> Strategy \> TradeCollection \> TradesPerformance \> Pips
Pips
| \<\< [Click to Display Table of Contents](pips.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> [TradeCollection](tradecollection.md) \> [TradesPerformance](tradesperformance.md) \> Pips | [Previous page](performancemetrics.md) [Return to chapter overview](tradesperformance.md) [Next page](points.md) |
| --- | --- |
## Definition
Returns a [TradesPerformanceValues](tradesperformancevalues.md) object in pips.  

 
## Property Value
A TradesPerformanceValues object that is represented in pips.
 
## Syntax
\<TradeCollection\>.TradesPerformance.Pips

## Examples
| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the avg. profit of all trades in pips      Print("Average profit: " \+ SystemPerformance.AllTrades.TradesPerformance.Pips.AverageProfit); } |

 
