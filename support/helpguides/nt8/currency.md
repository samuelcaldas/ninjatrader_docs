
NinjaScript > Language Reference > Strategy > TradeCollection > TradesPerformance > Currency
Currency
| << [Click to Display Table of Contents](currency.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Strategy](strategy.md) > [TradeCollection](tradecollection.md) > [TradesPerformance](tradesperformance.md) > Currency | [Previous page](averagetotalefficiency.md) [Return to chapter overview](tradesperformance.md) [Next page](grossloss.md) |
| --- | --- |
## Definition
Returns a [TradesPerformanceValues](tradesperformancevalues.md) object in currency.  

 
## Property Value
A TradesPerformanceValues object that is represented in currency.
 
## Syntax
<TradeCollection>.TradesPerformance.Currency

## 
## Examples
| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the avg. profit of all trades in currency      Print("Average profit: " + SystemPerformance.AllTrades.TradesPerformance.Currency.AverageProfit); } |

