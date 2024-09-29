


NinjaScript \> Language Reference \> Strategy \> TradeCollection \> TradesPerformance \> RSquared






















RSquared







| \<\< [Click to Display Table of Contents](rsquared.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> [TradeCollection](tradecollection.md) \> [TradesPerformance](tradesperformance.md) \> RSquared | [Previous page](profitfactor.md) [Return to chapter overview](tradesperformance.md) [Next page](riskfreereturn.md) |
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



 








