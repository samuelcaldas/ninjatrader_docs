
NinjaScript \> Language Reference \> Strategy \> TradesPerformanceValues \> ProfitPerMonth

ProfitPerMonth

| \<\< [Click to Display Table of Contents](profitpermonth.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> [TradesPerformanceValues](tradesperformancevalues.md) \> ProfitPerMonth | [Previous page](largestwinner.md) [Return to chapter overview](tradesperformancevalues.md) [Next page](stddev.md) |
| --- | --- |
## Definition
Returns the profit per month of the collection. This value is always returned as a percentage.  

 
## Property Value
A double value that represents the profit per month of the collection as a percentage.
 
## Syntax
\<TradeCollection\>.TradesPerformance.\<TradesPerformanceValues\>.ProfitPerMonth

## Examples

| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the profit per month of all trades      Print("Profit per month of all trades is: " \+ SystemPerformance.AllTrades.TradesPerformance.Currency.ProfitPerMonth); } |
