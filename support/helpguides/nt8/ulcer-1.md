
NinjaScript \> Language Reference \> Strategy \> TradesPerformanceValues \> Ulcer
Ulcer
| \<\< [Click to Display Table of Contents](ulcer.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Strategy](strategy-1.md) \> [TradesPerformanceValues](tradesperformancevalues-1.md) \> Ulcer | [Previous page](turnaround-1.md) [Return to chapter overview](tradesperformancevalues-1.md) [Next page](waitforococlosingbracket-1.md) |
| --- | --- |
## Definition
Returns the Ulcer.  

 
## Property Value
A double value that represents the Ulcer.
 
## Syntax
\<TradeCollection\>.TradesPerformance.\<TradesPerformanceValues\>.Ulcer

## Examples
| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the Ulcer index of all trades      Print("Turnaround of all trades is: " \+ SystemPerformance.AllTrades.TradesPerformance.Currency.Ulcer); } |
