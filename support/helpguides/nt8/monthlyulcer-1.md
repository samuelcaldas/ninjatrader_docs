
NinjaScript \> Language Reference \> Strategy \> TradeCollection \> TradesPerformance \> MonthlyUlcer

MonthlyUlcer

| \<\< [Click to Display Table of Contents](monthlyulcer.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Strategy](strategy-1.md) \> [TradeCollection](tradecollection-1.md) \> [TradesPerformance](tradesperformance-1.md) \> MonthlyUlcer | [Previous page](monthlystddev-1.md) [Return to chapter overview](tradesperformance-1.md) [Next page](netprofit-1.md) |
| --- | --- |
## Definition
Returns the monthly Ulcer index.
 
## Property Value
A double value that represents the monthly Ulcer index.
 
## Syntax
\<TradeCollection\>.TradesPerformance.MonthlyUlcer

## 
## Examples

| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the monthly Ulcer index      Print("Monthly Ulcer index is: " \+ SystemPerformance.AllTrades.TradesPerformance.MonthlyUlcer); } |
