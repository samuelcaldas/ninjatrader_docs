
NinjaScript \> Language Reference \> Strategy \> TradeCollection \> TradesPerformance \> TradesPerDay
TradesPerDay
| \<\< [Click to Display Table of Contents](tradesperday.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> [TradeCollection](tradecollection.md) \> [TradesPerformance](tradesperformance.md) \> TradesPerDay | [Previous page](tradescount.md) [Return to chapter overview](tradesperformance.md) [Next page](winningtrades.md) |
| --- | --- |
## Definition
Returns the average number of trades per day.  

 
## Property Value
An int value that represents the average number of trades per day.
 
## Syntax
\<TradeCollection\>.TradesPerformance.TradesPerDay

## Examples
| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the average number of trades per day of all trades      Print("Average \# of trades per day is: " \+ SystemPerformance.AllTrades.TradesPerformance.TradesPerDay); } |
