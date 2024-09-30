
NinjaScript \> Language Reference \> Strategy \> TradeCollection \> TradesPerformance \> GrossLoss
GrossLoss
| \<\< [Click to Display Table of Contents](grossloss.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> [TradeCollection](tradecollection.md) \> [TradesPerformance](tradesperformance.md) \> GrossLoss | [Previous page](currency.md) [Return to chapter overview](tradesperformance.md) [Next page](grossprofit.md) |
| --- | --- |
## Definition
Returns the gross loss.  

 
## Property Value
A double value that represents the gross loss.
 
## Syntax
\<TradeCollection\>.TradesPerformance.GrossLoss

## 
## Examples
| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the gross loss of all trades      Print("Gross loss is: " \+ SystemPerformance.AllTrades.TradesPerformance.GrossLoss); } |

