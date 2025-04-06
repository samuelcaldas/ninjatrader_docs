



WinningTrades

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\winningtrades.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Strategy](strategy-1.htm) > [TradeCollection](tradecollection-1.htm) >  WinningTrades | [Previous page](tradesperday-1.htm) [Return to chapter overview](tradecollection-1.htm) [Next page](tradesperformancevalues-1.htm) |

Definition
----------

A subcollection of [Trade](trade-1.htm) objects consisting of only the winning trades in a [TradeCollection](tradecollection-1.htm). You can access a trade object by providing an index value. Trades are indexed sequentially meaning the oldest trade taken in a strategy will be at an index value of zero. The most recent trade taken will be at an index value of the total trades in the collection minus 1.

Methods and Properties
----------------------

|  |  |
| --- | --- |
| [Count](tradecollection_tradescount-1.htm) | An int value representing the number of trades in the collection |
| [GetTrades()](gettrades-1.htm) | Gets a [TradeCollection](tradecollection-1.htm) object representing a specified position |
| [TradesPerformance](tradesperformance-1.htm) | Gets a [TradesPerformance](tradesperformance-1.htm) object |

Syntax 
<TradeCollection>.WinningTrades
---------------------------------------

Examples
--------

| ns |
| --- |
| protected override void OnBarUpdate()  {       // Accesses the first/last winning trade in the strategy (oldest trade is at index 0)       // and prints out the profit as a percentage to the output window       if (SystemPerformance.AllTrades.WinningTrades.Count > 1)       {           Trade lastTrade = SystemPerformance.AllTrades.WinningTrades[SystemPerformance.AllTrades.Count - 1];           Trade firstTrade = SystemPerformance.AllTrades.WinningTrades[0];              Print("The last winning trade's profit was " + lastTrade.ProfitPercent);           Print("The first winning trade's profit was " + firstTrade.ProfitPercent);       }  } |