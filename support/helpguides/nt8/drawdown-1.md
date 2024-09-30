
NinjaScript > Language Reference > Strategy > TradesPerformanceValues > Drawdown

Drawdown
| << [Click to Display Table of Contents](drawdown.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Strategy](strategy-1.md) > [TradesPerformanceValues](tradesperformancevalues-1.md) > Drawdown | [Previous page](cumprofit-1.md) [Return to chapter overview](tradesperformancevalues-1.md) [Next page](largestloser-1.md) |
| --- | --- |
## Definition
Returns the draw down of the trade collection.  

 
## Property Value
A double value that represents the average ETD of the collection.
 
## Syntax
<TradeCollection>.TradesPerformance.<TradesPerformanceValues>.Drawdown

## 
## Examples
| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the draw down of all trades in currency      Print("Draw down of all trades is: " + SystemPerformance.AllTrades.TradesPerformance.Currency.Drawdown); } |
