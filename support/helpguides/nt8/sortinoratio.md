
NinjaScript \> Language Reference \> Strategy \> TradeCollection \> TradesPerformance \> SortinoRatio

SortinoRatio

| \<\< [Click to Display Table of Contents](sortinoratio.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> [TradeCollection](tradecollection.md) \> [TradesPerformance](tradesperformance.md) \> SortinoRatio | [Previous page](sharperatio.md) [Return to chapter overview](tradesperformance.md) [Next page](ticks.md) |
| --- | --- |
## Definition
Returns the Sortino ratio using a [risk free return](riskfreereturn.md).  

 
## Property Value
A double value that represents the Sortino ratio using a risk free return.
 
## Syntax
\<TradeCollection\>.TradesPerformance.SortinoRatio

## Examples

| ns |
| --- |
| protected override void OnBarUpdate() {      // Set a 0% risk free return      SystemPerformance.AllTrades.TradesPerformance.RiskFreeReturn \= 0;        // Print out the Sortino ratio of all trades based on a zero risk free return      Print("Sortino ratio is: " \+ SystemPerformance.AllTrades.TradesPerformance.SortinoRatio); } |
 
