
NinjaScript > Language Reference > Strategy > TradesPerformanceValues > ProfitPerMonth

ProfitPerMonth

| << [Click to Display Table of Contents](profitpermonth.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Strategy](strategy-1.md) > [TradesPerformanceValues](tradesperformancevalues-1.md) > ProfitPerMonth | [Previous page](largestwinner-1.md) [Return to chapter overview](tradesperformancevalues-1.md) [Next page](stddev-1.md) |
| --- | --- |
## Definition
Returns the profit per month of the collection. This value is always returned as a percentage.  

 
## Property Value
A double value that represents the profit per month of the collection as a percentage.
 
## Syntax
<TradeCollection>.TradesPerformance.<TradesPerformanceValues>.ProfitPerMonth

## Examples

| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the profit per month of all trades      Print("Profit per month of all trades is: " + SystemPerformance.AllTrades.TradesPerformance.Currency.ProfitPerMonth); } |
