
NinjaScript > Language Reference > Strategy > TradesPerformanceValues > CumProfit
CumProfit
| << [Click to Display Table of Contents](cumprofit.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Strategy](strategy-1.md) > [TradesPerformanceValues](tradesperformancevalues-1.md) > CumProfit | [Previous page](averageprofit-1.md) [Return to chapter overview](tradesperformancevalues-1.md) [Next page](drawdown-1.md) |
| --- | --- |
## Definition
Returns the cumulative profit of the collection.  

 
## Property Value
A double value that represents the cumulative profit of the collection.
 
## Syntax
<TradeCollection>.TradesPerformance.<TradesPerformanceValues>.CumProfit

## 
## Examples
| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the cumulative profit of all trades in currency      Print("Average cumulative profit of all trades is: " + SystemPerformance.AllTrades.TradesPerformance.Currency.CumProfit); } |

