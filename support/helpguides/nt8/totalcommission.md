
NinjaScript > Language Reference > Strategy > TradeCollection > TradesPerformance > TotalCommission
TotalCommission
| << [Click to Display Table of Contents](totalcommission.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Strategy](strategy.md) > [TradeCollection](tradecollection.md) > [TradesPerformance](tradesperformance.md) > TotalCommission | [Previous page](ticks.md) [Return to chapter overview](tradesperformance.md) [Next page](totalquantity.md) |
| --- | --- |
## Definition
Returns the total commission.  

 
## Property Value
A double value that represents the total commission.
 
## Syntax
<TradeCollection>.TradesPerformance.TotalCommission

## Examples
| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the total commission of all trades      Print("Total commission is: " + SystemPerformance.AllTrades.TradesPerformance.TotalCommission); } |

 
