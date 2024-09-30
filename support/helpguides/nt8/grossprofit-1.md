
NinjaScript \> Language Reference \> Strategy \> TradeCollection \> TradesPerformance \> GrossProfit
GrossProfit
| \<\< [Click to Display Table of Contents](grossprofit.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Strategy](strategy-1.md) \> [TradeCollection](tradecollection-1.md) \> [TradesPerformance](tradesperformance-1.md) \> GrossProfit | [Previous page](grossloss-1.md) [Return to chapter overview](tradesperformance-1.md) [Next page](longestflatperiod-1.md) |
| --- | --- |
## Definition
Returns the gross profit.  

 
## Property Value
A double value that represents the gross profit.
 
## Syntax
\<TradeCollection\>.TradesPerformance.GrossProfit

## 
## Examples
| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the gross profit of all trades      Print("Gross profit is: " \+ SystemPerformance.AllTrades.TradesPerformance.GrossProfit); } |

