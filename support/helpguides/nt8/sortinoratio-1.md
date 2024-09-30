
NinjaScript > Language Reference > Strategy > TradeCollection > TradesPerformance > SortinoRatio

SortinoRatio

| << [Click to Display Table of Contents](sortinoratio.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Strategy](strategy-1.md) > [TradeCollection](tradecollection-1.md) > [TradesPerformance](tradesperformance-1.md) > SortinoRatio | [Previous page](sharperatio-1.md) [Return to chapter overview](tradesperformance-1.md) [Next page](ticks-1.md) |
| --- | --- |
## Definition
Returns the Sortino ratio using a [risk free return](riskfreereturn-1.md).  

 
## Property Value
A double value that represents the Sortino ratio using a risk free return.
 
## Syntax
<TradeCollection>.TradesPerformance.SortinoRatio

## Examples

| ns |
| --- |
| protected override void OnBarUpdate() {      // Set a 0% risk free return      SystemPerformance.AllTrades.TradesPerformance.RiskFreeReturn = 0;        // Print out the Sortino ratio of all trades based on a zero risk free return      Print("Sortino ratio is: " + SystemPerformance.AllTrades.TradesPerformance.SortinoRatio); } |
 
