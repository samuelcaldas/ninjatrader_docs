
NinjaScript > Language Reference > Strategy > TradeCollection > TradesPerformance > AverageTotalEfficiency

AverageTotalEfficiency

| << [Click to Display Table of Contents](averagetotalefficiency.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Strategy](strategy.md) > [TradeCollection](tradecollection.md) > [TradesPerformance](tradesperformance.md) > AverageTotalEfficiency | [Previous page](averagetimeinmarket.md) [Return to chapter overview](tradesperformance.md) [Next page](currency.md) |
| --- | --- |
## Definition
Returns the average total efficiency.  

 
## Property Value
A double value that represents the average total efficiency.
 
## Syntax
<TradeCollection>.TradesPerformance.AverageTotalEfficiency

## 
## Examples

| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the average total efficiency      Print("Average total efficiency is: " + SystemPerformance.AllTrades.TradesPerformance.AverageTotalEfficiency); } |
