


NinjaScript \> Language Reference \> Strategy \> TradeCollection \> TradesPerformance \> Currency






















Currency







| \<\< [Click to Display Table of Contents](currency.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Strategy](strategy-1.md) \> [TradeCollection](tradecollection-1.md) \> [TradesPerformance](tradesperformance-1.md) \> Currency | [Previous page](averagetotalefficiency-1.md) [Return to chapter overview](tradesperformance-1.md) [Next page](grossloss-1.md) |
| --- | --- |











## Definition


Returns a [TradesPerformanceValues](tradesperformancevalues-1.md) object in currency.  

 


## Property Value


A TradesPerformanceValues object that is represented in currency.


 


## Syntax
\<TradeCollection\>.TradesPerformance.Currency


 


 


## 


## Examples




| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the avg. profit of all trades in currency      Print("Average profit: " \+ SystemPerformance.AllTrades.TradesPerformance.Currency.AverageProfit); } |









