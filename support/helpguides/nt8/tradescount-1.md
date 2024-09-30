
NinjaScript \> Language Reference \> Strategy \> TradeCollection \> TradesPerformance \> TradesCount
TradesCount
| \<\< [Click to Display Table of Contents](tradescount.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Strategy](strategy-1.md) \> [TradeCollection](tradecollection-1.md) \> [TradesPerformance](tradesperformance-1.md) \> TradesCount | [Previous page](totalslippage-1.md) [Return to chapter overview](tradesperformance-1.md) [Next page](tradesperday-1.md) |
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

 
