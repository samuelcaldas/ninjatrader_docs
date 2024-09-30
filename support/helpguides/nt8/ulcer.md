
NinjaScript \> Language Reference \> Strategy \> TradesPerformanceValues \> Ulcer
Ulcer
| \<\< [Click to Display Table of Contents](ulcer.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> [TradesPerformanceValues](tradesperformancevalues.md) \> Ulcer | [Previous page](turnaround.md) [Return to chapter overview](tradesperformancevalues.md) [Next page](waitforococlosingbracket.md) |
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
