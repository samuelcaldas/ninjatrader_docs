
NinjaScript \> Language Reference \> Strategy \> TradeCollection \> TradesPerformance \> AverageBarsInTrade

AverageBarsInTrade
| \<\< [Click to Display Table of Contents](averagebarsintrade.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Strategy](strategy-1.md) \> [TradeCollection](tradecollection-1.md) \> [TradesPerformance](tradesperformance-1.md) \> AverageBarsInTrade | [Previous page](tradesperformance-1.md) [Return to chapter overview](tradesperformance-1.md) [Next page](averageentryefficiency-1.md) |
| --- | --- |
## Definition
Returns the average number of bars per trade.  

 
## Property Value
A double value that represents the average number of bars per trade.
 
## Syntax
\<TradeCollection\>.TradesPerformance.AverageBarsInTrade

## 
## Examples
| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the average number of bars per trade of all trades      Print("Average \# bars per trade is: " \+ SystemPerformance.AllTrades.TradesPerformance.AverageBarsInTrade); } |
