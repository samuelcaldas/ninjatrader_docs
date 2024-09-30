
NinjaScript \> Language Reference \> Strategy \> TradeCollection \> TradesPerformance \> AverageTotalEfficiency
AverageTotalEfficiency
| \<\< [Click to Display Table of Contents](averagetotalefficiency.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Strategy](strategy-1.md) \> [TradeCollection](tradecollection-1.md) \> [TradesPerformance](tradesperformance-1.md) \> AverageTotalEfficiency | [Previous page](averagetimeinmarket-1.md) [Return to chapter overview](tradesperformance-1.md) [Next page](currency-1.md) |
| --- | --- |
## Definition
Returns the average total efficiency.  

 
## Property Value
A double value that represents the average total efficiency.
 
## Syntax
\<TradeCollection\>.TradesPerformance.AverageTotalEfficiency

## 
## Examples
| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the average total efficiency      Print("Average total efficiency is: " \+ SystemPerformance.AllTrades.TradesPerformance.AverageTotalEfficiency); } |
