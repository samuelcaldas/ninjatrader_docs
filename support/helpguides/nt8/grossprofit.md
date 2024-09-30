
NinjaScript \> Language Reference \> Strategy \> TradeCollection \> TradesPerformance \> GrossProfit
GrossProfit
| \<\< [Click to Display Table of Contents](grossprofit.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> [TradeCollection](tradecollection.md) \> [TradesPerformance](tradesperformance.md) \> GrossProfit | [Previous page](grossloss.md) [Return to chapter overview](tradesperformance.md) [Next page](longestflatperiod.md) |
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

