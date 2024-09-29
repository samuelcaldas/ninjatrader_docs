


NinjaScript \> Language Reference \> Strategy \> TradesPerformanceValues \> StdDev






















StdDev







| \<\< [Click to Display Table of Contents](stddev.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Strategy](strategy-1.md) \> [TradesPerformanceValues](tradesperformancevalues-1.md) \> StdDev | [Previous page](profitpermonth-1.md) [Return to chapter overview](tradesperformancevalues-1.md) [Next page](turnaround-1.md) |
| --- | --- |











## Definition


Returns the standard deviation of the collection on a per unit basis.  

 


## Property Value


A double value that represents the standard deviation of the collection on a per unit basis.


 


## Syntax
\<TradeCollection\>.TradesPerformance.\<TradesPerformanceValues\>.StdDev


 


 


## Examples




| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the standard deviation of all trades      Print("Standard deviation of all trades is: " \+ SystemPerformance.AllTrades.TradesPerformance.Currency.StdDev); } |









