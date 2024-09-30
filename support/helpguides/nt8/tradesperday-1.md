
NinjaScript > Language Reference > Strategy > TradeCollection > TradesPerformance > TradesPerDay
TradesPerDay
| << [Click to Display Table of Contents](tradesperday.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Strategy](strategy-1.md) > [TradeCollection](tradecollection-1.md) > [TradesPerformance](tradesperformance-1.md) > TradesPerDay | [Previous page](tradescount-1.md) [Return to chapter overview](tradesperformance-1.md) [Next page](winningtrades-1.md) |
| --- | --- |
## Definition
Returns the average number of trades per day.  

 
## Property Value
An int value that represents the average number of trades per day.
 
## Syntax
<TradeCollection>.TradesPerformance.TradesPerDay

## Examples
| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the average number of trades per day of all trades      Print("Average # of trades per day is: " + SystemPerformance.AllTrades.TradesPerformance.TradesPerDay); } |
