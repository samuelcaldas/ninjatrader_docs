
NinjaScript \> Language Reference \> Strategy \> TradeCollection \> TradesPerformance \> SharpeRatio

SharpeRatio

| \<\< [Click to Display Table of Contents](sharperatio.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> [TradeCollection](tradecollection.md) \> [TradesPerformance](tradesperformance.md) \> SharpeRatio | [Previous page](riskfreereturn.md) [Return to chapter overview](tradesperformance.md) [Next page](sortinoratio.md) |
| --- | --- |
## Definition
Returns the Sharpe ratio using a [risk free return](riskfreereturn.md).  

 
## Property Value
A double value that represents the Sharpe ratio using a risk free return.
 
## Syntax
\<TradeCollection\>.TradesPerformance.SharpeRatio

## Examples

| ns |
| --- |
| protected override void OnBarUpdate() {      // Set a 0% risk free return      SystemPerformance.AllTrades.TradesPerformance.RiskFreeReturn \= 0;        // Print out the Sharpe ratio of all trades based on a zero risk free return      Print("Sharpe ratio is: " \+ SystemPerformance.AllTrades.TradesPerformance.SharpeRatio); } |
 
