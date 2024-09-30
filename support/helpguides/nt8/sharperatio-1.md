
NinjaScript \> Language Reference \> Strategy \> TradeCollection \> TradesPerformance \> SharpeRatio

SharpeRatio

| \<\< [Click to Display Table of Contents](sharperatio.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Strategy](strategy-1.md) \> [TradeCollection](tradecollection-1.md) \> [TradesPerformance](tradesperformance-1.md) \> SharpeRatio | [Previous page](riskfreereturn-1.md) [Return to chapter overview](tradesperformance-1.md) [Next page](sortinoratio-1.md) |
| --- | --- |
## Definition
Returns the Sharpe ratio using a [risk free return](riskfreereturn-1.md).  

 
## Property Value
A double value that represents the Sharpe ratio using a risk free return.
 
## Syntax
\<TradeCollection\>.TradesPerformance.SharpeRatio

## Examples

| ns |
| --- |
| protected override void OnBarUpdate() {      // Set a 0% risk free return      SystemPerformance.AllTrades.TradesPerformance.RiskFreeReturn \= 0;        // Print out the Sharpe ratio of all trades based on a zero risk free return      Print("Sharpe ratio is: " \+ SystemPerformance.AllTrades.TradesPerformance.SharpeRatio); } |
 
