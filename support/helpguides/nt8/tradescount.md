
NinjaScript \> Language Reference \> Strategy \> TradeCollection \> TradesPerformance \> TradesCount
TradesCount
| \<\< [Click to Display Table of Contents](tradescount.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> [TradeCollection](tradecollection.md) \> [TradesPerformance](tradesperformance.md) \> TradesCount | [Previous page](totalslippage.md) [Return to chapter overview](tradesperformance.md) [Next page](tradesperday.md) |
| --- | --- |
## Definition
Returns the total \# of trades.
 
## Property Value
A double value that represents the total \# of trades.
 
## Syntax
\<TradeCollection\>.TradesPerformance.TradesCount

## Examples
| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the total \# of trades      Print("Trades count is: " \+ SystemPerformance.AllTrades.TradesPerformance.TradesCount); } |

 
