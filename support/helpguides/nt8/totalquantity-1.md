


NinjaScript \> Language Reference \> Strategy \> TradeCollection \> TradesPerformance \> TotalQuantity






















TotalQuantity







| \<\< [Click to Display Table of Contents](totalquantity.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Strategy](strategy-1.md) \> [TradeCollection](tradecollection-1.md) \> [TradesPerformance](tradesperformance-1.md) \> TotalQuantity | [Previous page](totalcommission-1.md) [Return to chapter overview](tradesperformance-1.md) [Next page](totalslippage-1.md) |
| --- | --- |











## Definition


Returns the total quantity.


 


## Property Value


A double value that represents the total quantity.


 


## Syntax
\<TradeCollection\>.TradesPerformance.TotalQuantity


 


 


## Examples




| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the total quantity of all trades      Print("Total quantity is: " \+ SystemPerformance.AllTrades.TradesPerformance.TotalQuantity); } |



 








