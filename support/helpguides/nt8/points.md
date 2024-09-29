


NinjaScript \> Language Reference \> Strategy \> TradeCollection \> TradesPerformance \> Points






















Points







| \<\< [Click to Display Table of Contents](points.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> [TradeCollection](tradecollection.md) \> [TradesPerformance](tradesperformance.md) \> Points | [Previous page](pips.md) [Return to chapter overview](tradesperformance.md) [Next page](profitfactor.md) |
| --- | --- |











## Definition


Returns a [TradesPerformanceValues](tradesperformancevalues.md) object in points.  

 


## Property Value


A TradesPerformanceValues object that is represented in points.


 


## Syntax
\<TradeCollection\>.TradesPerformance.Points


 


 


## Examples




| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the avg. profit of all trades in points      Print("Average profit: " \+ SystemPerformance.AllTrades.TradesPerformance.Points.AverageProfit); } |



 








