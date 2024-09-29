


NinjaScript \> Language Reference \> Strategy \> TradeCollection \> EvenTrades






















EvenTrades







| \<\< [Click to Display Table of Contents](eventrades.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> [TradeCollection](tradecollection.md) \> EvenTrades | [Previous page](tradecollection_tradescount.md) [Return to chapter overview](tradecollection.md) [Next page](gettrades.md) |
| --- | --- |











## Definition


A subcollection of [Trade](trade.md) objects consisting of only the non\-winning and non\-losing trades in a [TradeCollection](tradecollection.md). 


 




| Note: You can access a trade object by providing an index value. Trades are indexed sequentially meaning the oldest trade taken in a strategy will be at an index value of zero. The most recent trade taken will be at an index value of the total trades in the collection minus 1\. |
| --- |



 


 


## Methods and Properties




| [Count](tradecollection_tradescount.md) | An int value representing the number of trades in the collection |
| --- | --- |
| [GetTrades()](gettrades.md) | Gets a [TradeCollection](tradecollection.md) object representing a specified position |
| [TradesPerformance](tradesperformance.md) | Gets a [TradesPerformance](tradesperformance.md) object |



 


## Syntax
\<TradeCollection\>.EvenTrades


## 


## Examples




| ns |
| --- |
| protected override void OnBarUpdate() {      // Accesses the first/last losing trade in the strategy (oldest trade is at index 0\)      // and prints out the quantity NinjaScript Output window      if (SystemPerformance.AllTrades.EvenTrades.Count \> 1)      {          Trade lastTrade \= SystemPerformance.AllTrades.EvenTrades\[SystemPerformance.AllTrades.Count \- 1];          Trade firstTrade \= SystemPerformance.AllTrades.EvenTrades\[0];            Print("The last even trade's quantity was " \+ lastTrade.Quantity);          Print("The first even trade's quantity was " \+ firstTrade.Quantity);      } } |









