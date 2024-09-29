


NinjaScript \> Language Reference \> Strategy \> TradeCollection \> TradesPerformance \> TotalCommission






















TotalCommission







| \<\< [Click to Display Table of Contents](totalcommission.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Strategy](strategy-1.md) \> [TradeCollection](tradecollection-1.md) \> [TradesPerformance](tradesperformance-1.md) \> TotalCommission | [Previous page](ticks-1.md) [Return to chapter overview](tradesperformance-1.md) [Next page](totalquantity-1.md) |
| --- | --- |











## Definition


Returns the total commission.  

 


## Property Value


A double value that represents the total commission.


 


## Syntax
\<TradeCollection\>.TradesPerformance.TotalCommission


 


 


## Examples




| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the total commission of all trades      Print("Total commission is: " \+ SystemPerformance.AllTrades.TradesPerformance.TotalCommission); } |



 








