
NinjaScript \> Language Reference \> Strategy \> TradeCollection \> TradesPerformance \> Pips
Pips
| \<\< [Click to Display Table of Contents](pips.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Strategy](strategy-1.md) \> [TradeCollection](tradecollection-1.md) \> [TradesPerformance](tradesperformance-1.md) \> Pips | [Previous page](performancemetrics-1.md) [Return to chapter overview](tradesperformance-1.md) [Next page](points-1.md) |
| --- | --- |
## Definition
Returns a [TradesPerformanceValues](tradesperformancevalues-1.md) object in pips.  

 
## Property Value
A TradesPerformanceValues object that is represented in pips.
 
## Syntax
\<TradeCollection\>.TradesPerformance.Pips

## Examples
| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the avg. profit of all trades in pips      Print("Average profit: " \+ SystemPerformance.AllTrades.TradesPerformance.Pips.AverageProfit); } |

 
