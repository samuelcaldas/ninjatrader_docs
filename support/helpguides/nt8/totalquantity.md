
NinjaScript \> Language Reference \> Strategy \> TradeCollection \> TradesPerformance \> TotalQuantity
TotalQuantity
| \<\< [Click to Display Table of Contents](totalquantity.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> [TradeCollection](tradecollection.md) \> [TradesPerformance](tradesperformance.md) \> TotalQuantity | [Previous page](totalcommission.md) [Return to chapter overview](tradesperformance.md) [Next page](totalslippage.md) |
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

 
