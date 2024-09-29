


NinjaScript \> Language Reference \> Strategy \> TradeCollection \> TradesPerformance \> AverageEntryEfficiency






















AverageEntryEfficiency







| \<\< [Click to Display Table of Contents](averageentryefficiency.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Strategy](strategy-1.md) \> [TradeCollection](tradecollection-1.md) \> [TradesPerformance](tradesperformance-1.md) \> AverageEntryEfficiency | [Previous page](averagebarsintrade-1.md) [Return to chapter overview](tradesperformance-1.md) [Next page](averageexitefficiency-1.md) |
| --- | --- |











## Definition


Returns the average entry efficiency.  

 


## Property Value


A double value that represents the average entry efficiency.


 


## Syntax
\<TradeCollection\>.TradesPerformance.AverageEntryEfficiency


 


 


## 


## Examples




| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the average entry efficiency      Print("Average entry efficiency is: " \+ SystemPerformance.AllTrades.TradesPerformance.AverageEntryEfficiency); } |









