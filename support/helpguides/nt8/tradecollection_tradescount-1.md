
NinjaScript \> Language Reference \> Strategy \> TradeCollection \> TradesCount
TradesCount
| \<\< [Click to Display Table of Contents](tradecollection_tradescount.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Strategy](strategy-1.md) \> [TradeCollection](tradecollection-1.md) \> TradesCount | [Previous page](tradecollection-1.md) [Return to chapter overview](tradecollection-1.md) [Next page](eventrades-1.md) |
| --- | --- |
## Definition
Indicates the number of trades in the collection.
 
## Property Value
An int value that represents the number of trades in the collection.
 
## Syntax
\<TradeCollection\>.Count
 
## Examples
| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the number of long trades      Print("The strategy has taken " \+ SystemPerformance.LongTrades.TradesCount \+ " long trades."); } |
