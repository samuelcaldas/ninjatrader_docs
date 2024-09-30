
NinjaScript > Language Reference > Strategy > TradeCollection > TradesPerformance > NetProfit
NetProfit
| << [Click to Display Table of Contents](netprofit.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Strategy](strategy.md) > [TradeCollection](tradecollection.md) > [TradesPerformance](tradesperformance.md) > NetProfit | [Previous page](monthlyulcer.md) [Return to chapter overview](tradesperformance.md) [Next page](percent.md) |
| --- | --- |
## Definition
Returns the net profit.  

 
## Property Value
A double value that represents the net profit.
 
## Syntax
<TradeCollection>.TradesPerformance.NetProfit

## Examples
| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the net profit of all trades      Print("Net profit is: " + SystemPerformance.AllTrades.TradesPerformance.NetProfit); } |
