
NinjaScript > Language Reference > Strategy > TradeCollection > TradesPerformance > AverageBarsInTrade
AverageBarsInTrade
| << [Click to Display Table of Contents](averagebarsintrade.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Strategy](strategy.md) > [TradeCollection](tradecollection.md) > [TradesPerformance](tradesperformance.md) > AverageBarsInTrade | [Previous page](tradesperformance.md) [Return to chapter overview](tradesperformance.md) [Next page](averageentryefficiency.md) |
| --- | --- |
## Definition
Returns the average number of bars per trade.  

 
## Property Value
A double value that represents the average number of bars per trade.
 
## Syntax
<TradeCollection>.TradesPerformance.AverageBarsInTrade

## 
## Examples
| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the average number of bars per trade of all trades      Print("Average # bars per trade is: " + SystemPerformance.AllTrades.TradesPerformance.AverageBarsInTrade); } |

