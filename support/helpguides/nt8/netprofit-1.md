
NinjaScript > Language Reference > Strategy > TradeCollection > TradesPerformance > NetProfit
NetProfit
| << [Click to Display Table of Contents](netprofit.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Strategy](strategy-1.md) > [TradeCollection](tradecollection-1.md) > [TradesPerformance](tradesperformance-1.md) > NetProfit | [Previous page](monthlyulcer-1.md) [Return to chapter overview](tradesperformance-1.md) [Next page](percent-1.md) |
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
