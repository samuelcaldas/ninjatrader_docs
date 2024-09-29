


NinjaScript \> Language Reference \> Strategy \> TradeCollection \> TradesPerformance \> ProfitFactor






















ProfitFactor







| \<\< [Click to Display Table of Contents](profitfactor.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> [TradeCollection](tradecollection.md) \> [TradesPerformance](tradesperformance.md) \> ProfitFactor | [Previous page](points.md) [Return to chapter overview](tradesperformance.md) [Next page](rsquared.md) |
| --- | --- |











## Definition


Returns the profit factor.  

 


## Property Value


A double value that represents the profit factor.


 


## Syntax
\<TradeCollection\>.TradesPerformance.ProfitFactor


 


 


## Examples




| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the profit factor of all trades      Print("Profit factor is: " \+ SystemPerformance.AllTrades.TradesPerformance.ProfitFactor); } |



 








