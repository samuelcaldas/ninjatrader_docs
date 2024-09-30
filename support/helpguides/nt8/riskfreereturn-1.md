
NinjaScript \> Language Reference \> Strategy \> TradeCollection \> TradesPerformance \> RiskFreeReturn
RiskFreeReturn
| \<\< [Click to Display Table of Contents](riskfreereturn.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Strategy](strategy-1.md) \> [TradeCollection](tradecollection-1.md) \> [TradesPerformance](tradesperformance-1.md) \> RiskFreeReturn | [Previous page](rsquared-1.md) [Return to chapter overview](tradesperformance-1.md) [Next page](sharperatio-1.md) |
| --- | --- |
## Definition
The risk free return used in calculations of [Sharpe](sharperatio-1.md) and [Sortino](sortinoratio-1.md) ratios.  

 
## Property Value
A double value that represents the risk free return.
 
## Syntax
\<TradeCollection\>.TradesPerformance.RiskFreeReturn

## Examples
| ns |
| --- |
| protected override void OnBarUpdate() {      // Set a 3\.5% risk free return      SystemPerformance.AllTrades.TradesPerformance.RiskFreeReturn \= 0\.035;        // Print out the Sharpe ratio of all trades based on a 3\.5% risk free return      Print("Sharpe ratio is: " \+ SystemPerformance.AllTrades.TradesPerformance.SharpeRatio); } |

 
