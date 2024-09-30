
NinjaScript \> Language Reference \> Strategy \> TradeCollection \> TradesPerformance \> RSquared

RSquared

| \<\< [Click to Display Table of Contents](rsquared.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Strategy](strategy-1.md) \> [TradeCollection](tradecollection-1.md) \> [TradesPerformance](tradesperformance-1.md) \> RSquared | [Previous page](profitfactor-1.md) [Return to chapter overview](tradesperformance-1.md) [Next page](riskfreereturn-1.md) |
| --- | --- |
## Definition
Returns the trade performance R\-Squared value.  

 
## Property Value
A double value that represents the R\-Squared (R2\)
 
## Syntax
\<TradeCollection\>.TradesPerformance.RSquared

## Examples

| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the R2 value of all trades      Print("R\-Squared is: " \+ SystemPerformance.AllTrades.TradesPerformance.RSquared); } |
 
