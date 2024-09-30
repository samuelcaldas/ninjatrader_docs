
NinjaScript \> Language Reference \> Strategy \> TradeCollection \> TradesPerformance \> Points

Points

| \<\< [Click to Display Table of Contents](points.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Strategy](strategy-1.md) \> [TradeCollection](tradecollection-1.md) \> [TradesPerformance](tradesperformance-1.md) \> Points | [Previous page](pips-1.md) [Return to chapter overview](tradesperformance-1.md) [Next page](profitfactor-1.md) |
| --- | --- |
## Definition
Returns a [TradesPerformanceValues](tradesperformancevalues-1.md) object in points.  

 
## Property Value
A TradesPerformanceValues object that is represented in points.
 
## Syntax
\<TradeCollection\>.TradesPerformance.Points

## Examples

| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the avg. profit of all trades in points      Print("Average profit: " \+ SystemPerformance.AllTrades.TradesPerformance.Points.AverageProfit); } |
 
