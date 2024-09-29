


NinjaScript \> Language Reference \> Strategy \> TradeCollection \> TradesPerformance \> AverageTimeInMarket






















AverageTimeInMarket







| \<\< [Click to Display Table of Contents](averagetimeinmarket.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> [TradeCollection](tradecollection.md) \> [TradesPerformance](tradesperformance.md) \> AverageTimeInMarket | [Previous page](averageexitefficiency.md) [Return to chapter overview](tradesperformance.md) [Next page](averagetotalefficiency.md) |
| --- | --- |











## Definition


Returns the average duration of a trade weighted by quantity.  

 


## Property Value


A TimeSpan value that represents the quantity\-weighted average duration of a trade.


 


## Syntax
\<TradeCollection\>.TradesPerformance.AverageTimeInMarket


 


 


## 


## Examples




| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the quantity\-weighted average duration of all trades      Print("Average time in market: " \+ SystemPerformance.AllTrades.TradesPerformance.AverageTimeInMarket); } |









