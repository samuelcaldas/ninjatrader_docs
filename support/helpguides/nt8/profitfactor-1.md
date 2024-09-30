
NinjaScript > Language Reference > Strategy > TradeCollection > TradesPerformance > ProfitFactor

ProfitFactor

| << [Click to Display Table of Contents](profitfactor.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Strategy](strategy-1.md) > [TradeCollection](tradecollection-1.md) > [TradesPerformance](tradesperformance-1.md) > ProfitFactor | [Previous page](points-1.md) [Return to chapter overview](tradesperformance-1.md) [Next page](rsquared-1.md) |
| --- | --- |
## Definition
Returns the profit factor.  

 
## Property Value
A double value that represents the profit factor.
 
## Syntax
<TradeCollection>.TradesPerformance.ProfitFactor

## Examples

| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the profit factor of all trades      Print("Profit factor is: " + SystemPerformance.AllTrades.TradesPerformance.ProfitFactor); } |
 
