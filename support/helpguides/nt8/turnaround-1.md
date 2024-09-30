
NinjaScript \> Language Reference \> Strategy \> TradesPerformanceValues \> Turnaround
Turnaround
| \<\< [Click to Display Table of Contents](turnaround.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Strategy](strategy-1.md) \> [TradesPerformanceValues](tradesperformancevalues-1.md) \> Turnaround | [Previous page](stddev-1.md) [Return to chapter overview](tradesperformancevalues-1.md) [Next page](ulcer-1.md) |
| --- | --- |
## Definition
Returns the amount of turnaround.  

 
## Property Value
A double value that represents the amount of turnaround.
 
## Syntax
\<TradeCollection\>.TradesPerformance.\<TradesPerformanceValues\>.Turnaround

## Examples
| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the turnaround of all trades      Print("Turnaround of all trades is: " \+ SystemPerformance.AllTrades.TradesPerformance.Currency.Turnaround); } |
