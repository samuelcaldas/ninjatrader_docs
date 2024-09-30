
NinjaScript \> Language Reference \> Strategy \> TradeCollection \> TradesPerformance \> AverageTimeInMarket
AverageTimeInMarket
| \<\< [Click to Display Table of Contents](averagetimeinmarket.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Strategy](strategy-1.md) \> [TradeCollection](tradecollection-1.md) \> [TradesPerformance](tradesperformance-1.md) \> AverageTimeInMarket | [Previous page](averageexitefficiency-1.md) [Return to chapter overview](tradesperformance-1.md) [Next page](averagetotalefficiency-1.md) |
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

