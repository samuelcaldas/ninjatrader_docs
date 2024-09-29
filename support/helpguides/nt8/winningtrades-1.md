


NinjaScript \> Language Reference \> Strategy \> TradeCollection \> WinningTrades






















WinningTrades







| \<\< [Click to Display Table of Contents](winningtrades.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Strategy](strategy-1.md) \> [TradeCollection](tradecollection-1.md) \> WinningTrades | [Previous page](tradesperday-1.md) [Return to chapter overview](tradecollection-1.md) [Next page](tradesperformancevalues-1.md) |
| --- | --- |











## Definition


A subcollection of [Trade](trade-1.md) objects consisting of only the winning trades in a [TradeCollection](tradecollection-1.md). You can access a trade object by providing an index value. Trades are indexed sequentially meaning the oldest trade taken in a strategy will be at an index value of zero. The most recent trade taken will be at an index value of the total trades in the collection minus 1\.


 


## Methods and Properties




| [Count](tradecollection_tradescount-1.md) | An int value representing the number of trades in the collection |
| --- | --- |
| [GetTrades()](gettrades-1.md) | Gets a [TradeCollection](tradecollection-1.md) object representing a specified position |
| [TradesPerformance](tradesperformance-1.md) | Gets a [TradesPerformance](tradesperformance-1.md) object |



 


## Syntax
\<TradeCollection\>.WinningTrades


 


 


## Examples


## 




| ns |
| --- |
| protected override void OnBarUpdate() {      // Accesses the first/last winning trade in the strategy (oldest trade is at index 0\)      // and prints out the profit as a percentage to the output window      if (SystemPerformance.AllTrades.WinningTrades.Count \> 1)      {          Trade lastTrade \= SystemPerformance.AllTrades.WinningTrades\[SystemPerformance.AllTrades.Count \- 1];          Trade firstTrade \= SystemPerformance.AllTrades.WinningTrades\[0];            Print("The last winning trade's profit was " \+ lastTrade.ProfitPercent);          Print("The first winning trade's profit was " \+ firstTrade.ProfitPercent);      } } |









