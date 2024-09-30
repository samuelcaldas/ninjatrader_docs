
NinjaScript > Language Reference > Strategy > TradeCollection > TradesPerformance > GrossLoss
GrossLoss
| << [Click to Display Table of Contents](grossloss.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Strategy](strategy-1.md) > [TradeCollection](tradecollection-1.md) > [TradesPerformance](tradesperformance-1.md) > GrossLoss | [Previous page](currency-1.md) [Return to chapter overview](tradesperformance-1.md) [Next page](grossprofit-1.md) |
| --- | --- |
## Definition
Returns the gross loss.  

 
## Property Value
A double value that represents the gross loss.
 
## Syntax
<TradeCollection>.TradesPerformance.GrossLoss

## 
## Examples
| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the gross loss of all trades      Print("Gross loss is: " + SystemPerformance.AllTrades.TradesPerformance.GrossLoss); } |

