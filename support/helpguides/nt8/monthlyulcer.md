
NinjaScript > Language Reference > Strategy > TradeCollection > TradesPerformance > MonthlyUlcer

MonthlyUlcer

| << [Click to Display Table of Contents](monthlyulcer.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Strategy](strategy.md) > [TradeCollection](tradecollection.md) > [TradesPerformance](tradesperformance.md) > MonthlyUlcer | [Previous page](monthlystddev.md) [Return to chapter overview](tradesperformance.md) [Next page](netprofit.md) |
| --- | --- |
## Definition
Returns the monthly Ulcer index.
 
## Property Value
A double value that represents the monthly Ulcer index.
 
## Syntax
<TradeCollection>.TradesPerformance.MonthlyUlcer

## 
## Examples

| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the monthly Ulcer index      Print("Monthly Ulcer index is: " + SystemPerformance.AllTrades.TradesPerformance.MonthlyUlcer); } |
