
NinjaScript \> Language Reference \> Strategy \> TradesPerformanceValues \> Turnaround
Turnaround
| \<\< [Click to Display Table of Contents](turnaround.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> [TradesPerformanceValues](tradesperformancevalues.md) \> Turnaround | [Previous page](stddev.md) [Return to chapter overview](tradesperformancevalues.md) [Next page](ulcer.md) |
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
