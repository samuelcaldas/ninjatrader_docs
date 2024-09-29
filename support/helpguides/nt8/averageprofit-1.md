


NinjaScript \> Language Reference \> Strategy \> TradesPerformanceValues \> AverageProfit






















AverageProfit







| \<\< [Click to Display Table of Contents](averageprofit.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Strategy](strategy-1.md) \> [TradesPerformanceValues](tradesperformancevalues-1.md) \> AverageProfit | [Previous page](averagemfe-1.md) [Return to chapter overview](tradesperformancevalues-1.md) [Next page](cumprofit-1.md) |
| --- | --- |











## Definition


Returns the average profit of the collection.  

 


## Property Value


A double value that represents the average profit of the collection.


 


## Syntax
\<TradeCollection\>.TradesPerformance.\<TradesPerformanceValues\>.AverageProfit


 


 


## 


## Examples




| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the average profit of all trades in currency      Print("Average profit of all trades is: " \+ SystemPerformance.AllTrades.TradesPerformance.Currency.AverageProfit); } |









