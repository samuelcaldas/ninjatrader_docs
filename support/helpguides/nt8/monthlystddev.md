
NinjaScript > Language Reference > Strategy > TradeCollection > TradesPerformance > MonthlyStdDev

MonthlyStdDev

| << [Click to Display Table of Contents](monthlystddev.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Strategy](strategy.md) > [TradeCollection](tradecollection.md) > [TradesPerformance](tradesperformance.md) > MonthlyStdDev | [Previous page](maxtimetorecover.md) [Return to chapter overview](tradesperformance.md) [Next page](monthlyulcer.md) |
| --- | --- |
## Definition
Returns the monthly standard deviation.
 
## Property Value
A double value that represents the monthly standard deviation.
 
## Syntax
<TradeCollection>.TradesPerformance.MonthlyStdDev

## 
## Examples

| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the monthly standard deviation      Print("Monthly standard deviation is: " + SystemPerformance.AllTrades.TradesPerformance.MonthlyStdDev); } |
