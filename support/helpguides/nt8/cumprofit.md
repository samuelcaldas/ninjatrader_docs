
NinjaScript \> Language Reference \> Strategy \> TradesPerformanceValues \> CumProfit
CumProfit
| \<\< [Click to Display Table of Contents](cumprofit.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> [TradesPerformanceValues](tradesperformancevalues.md) \> CumProfit | [Previous page](averageprofit.md) [Return to chapter overview](tradesperformancevalues.md) [Next page](drawdown.md) |
| --- | --- |
## Definition
Returns the cumulative profit of the collection.  

 
## Property Value
A double value that represents the cumulative profit of the collection.
 
## Syntax
\<TradeCollection\>.TradesPerformance.\<TradesPerformanceValues\>.CumProfit

## 
## Examples
| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the cumulative profit of all trades in currency      Print("Average cumulative profit of all trades is: " \+ SystemPerformance.AllTrades.TradesPerformance.Currency.CumProfit); } |

