


NinjaScript \> Language Reference \> Strategy \> TradeCollection \> TradesPerformance \> AverageExitEfficiency






















AverageExitEfficiency







| \<\< [Click to Display Table of Contents](averageexitefficiency.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> [TradeCollection](tradecollection.md) \> [TradesPerformance](tradesperformance.md) \> AverageExitEfficiency | [Previous page](averageentryefficiency.md) [Return to chapter overview](tradesperformance.md) [Next page](averagetimeinmarket.md) |
| --- | --- |











## Definition


Returns the average exit efficiency.  

 


## Property Value


A double value that represents the average exit efficiency.


 


## Syntax
\<TradeCollection\>.TradesPerformance.AverageExitEfficiency


 


 


## 


## Examples




| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the average exit efficiency      Print("Average exit efficiency is: " \+ SystemPerformance.AllTrades.TradesPerformance.AverageExitEfficiency); } |









