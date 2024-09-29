


NinjaScript \> Language Reference \> Strategy \> TradeCollection \> TradesPerformance \> MaxTimeToRecover






















MaxTimeToRecover







| \<\< [Click to Display Table of Contents](maxtimetorecover.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> [TradeCollection](tradecollection.md) \> [TradesPerformance](tradesperformance.md) \> MaxTimeToRecover | [Previous page](maxconsecutivewinner.md) [Return to chapter overview](tradesperformance.md) [Next page](monthlystddev.md) |
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









