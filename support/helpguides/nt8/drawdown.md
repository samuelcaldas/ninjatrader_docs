
NinjaScript > Language Reference > Strategy > TradesPerformanceValues > Drawdown

Drawdown
| << [Click to Display Table of Contents](drawdown.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Strategy](strategy.md) > [TradesPerformanceValues](tradesperformancevalues.md) > Drawdown | [Previous page](cumprofit.md) [Return to chapter overview](tradesperformancevalues.md) [Next page](largestloser.md) |
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
