
NinjaScript > Language Reference > Strategy > TradesPerformanceValues > StdDev

StdDev

| << [Click to Display Table of Contents](stddev.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Strategy](strategy.md) > [TradesPerformanceValues](tradesperformancevalues.md) > StdDev | [Previous page](profitpermonth.md) [Return to chapter overview](tradesperformancevalues.md) [Next page](turnaround.md) |
| --- | --- |
## Definition
Returns the standard deviation of the collection on a per unit basis.  

 
## Property Value
A double value that represents the standard deviation of the collection on a per unit basis.
 
## Syntax
<TradeCollection>.TradesPerformance.<TradesPerformanceValues>.StdDev

## Examples

| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the standard deviation of all trades      Print("Standard deviation of all trades is: " + SystemPerformance.AllTrades.TradesPerformance.Currency.StdDev); } |
