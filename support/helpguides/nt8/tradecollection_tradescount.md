
NinjaScript > Language Reference > Strategy > TradeCollection > TradesCount
TradesCount
| << [Click to Display Table of Contents](tradecollection_tradescount.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Strategy](strategy.md) > [TradeCollection](tradecollection.md) > TradesCount | [Previous page](tradecollection.md) [Return to chapter overview](tradecollection.md) [Next page](eventrades.md) |
| --- | --- |
## Definition
Indicates the number of trades in the collection.
 
## Property Value
An int value that represents the number of trades in the collection.
 
## Syntax
<TradeCollection>.Count
 
## Examples
| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the number of long trades      Print("The strategy has taken " + SystemPerformance.LongTrades.TradesCount + " long trades."); } |
