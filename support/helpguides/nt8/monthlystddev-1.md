


NinjaScript \> Language Reference \> Strategy \> TradeCollection \> TradesPerformance \> MonthlyStdDev






















MonthlyStdDev







| \<\< [Click to Display Table of Contents](monthlystddev.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Strategy](strategy-1.md) \> [TradeCollection](tradecollection-1.md) \> [TradesPerformance](tradesperformance-1.md) \> MonthlyStdDev | [Previous page](maxtimetorecover-1.md) [Return to chapter overview](tradesperformance-1.md) [Next page](monthlyulcer-1.md) |
| --- | --- |











## Definition


Returns the monthly standard deviation.


 


## Property Value


A double value that represents the monthly standard deviation.


 


## Syntax
\<TradeCollection\>.TradesPerformance.MonthlyStdDev


 


 


## 


## Examples




| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the monthly standard deviation      Print("Monthly standard deviation is: " \+ SystemPerformance.AllTrades.TradesPerformance.MonthlyStdDev); } |









