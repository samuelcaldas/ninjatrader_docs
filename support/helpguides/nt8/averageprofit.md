
NinjaScript \> Language Reference \> Strategy \> TradesPerformanceValues \> AverageProfit
AverageProfit
| \<\< [Click to Display Table of Contents](averageprofit.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> [TradesPerformanceValues](tradesperformancevalues.md) \> AverageProfit | [Previous page](averagemfe.md) [Return to chapter overview](tradesperformancevalues.md) [Next page](cumprofit.md) |
| --- | --- |
## Definition
Returns the average profit of the collection.  

 
## Property Value
A double value that represents the average profit of the collection.
 
## Syntax
\<TradeCollection\>.TradesPerformance.\<TradesPerformanceValues\>.AverageProfit

## 
## Examples
| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the average profit of all trades in currency      Print("Average profit of all trades is: " \+ SystemPerformance.AllTrades.TradesPerformance.Currency.AverageProfit); } |

