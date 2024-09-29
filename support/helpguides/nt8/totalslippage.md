


NinjaScript \> Language Reference \> Strategy \> TradeCollection \> TradesPerformance \> TotalSlippage






















TotalSlippage







| \<\< [Click to Display Table of Contents](totalslippage.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> [TradeCollection](tradecollection.md) \> [TradesPerformance](tradesperformance.md) \> TotalSlippage | [Previous page](totalquantity.md) [Return to chapter overview](tradesperformance.md) [Next page](tradescount.md) |
| --- | --- |











## Definition


Returns the total slippage.


 


## Property Value


A double value that represents the total slippage. This is presented in points, I.E. 0\.25 for 1 execution on E\-mini S\&P 500 Futures.


 


## Syntax
\<TradeCollection\>.TradesPerformance.TotalSlippage


 


 


## Examples




| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the total slippage of all trades      Print("Total slippage is: " \+ SystemPerformance.AllTrades.TradesPerformance.TotalSlippage); } |



 








