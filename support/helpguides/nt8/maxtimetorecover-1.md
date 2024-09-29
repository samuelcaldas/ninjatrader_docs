


NinjaScript \> Language Reference \> Strategy \> TradeCollection \> TradesPerformance \> MaxTimeToRecover






















MaxTimeToRecover







| \<\< [Click to Display Table of Contents](maxtimetorecover.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Strategy](strategy-1.md) \> [TradeCollection](tradecollection-1.md) \> [TradesPerformance](tradesperformance-1.md) \> MaxTimeToRecover | [Previous page](maxconsecutivewinner-1.md) [Return to chapter overview](tradesperformance-1.md) [Next page](monthlystddev-1.md) |
| --- | --- |











## Definition


Returns the maximum time to recover from a draw down.  

 


## Property Value


A TimeSpan value that represents the maximum time to recover from a draw down.


 


## Syntax
\<TradeCollection\>.TradesPerformance.MaxTimeToRecover


 


## 


## Examples




| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the maximum time to recover from a draw down      Print("Max time to recover is: " \+ SystemPerformance.AllTrades.TradesPerformance.MaxTimeToRecover); } |









