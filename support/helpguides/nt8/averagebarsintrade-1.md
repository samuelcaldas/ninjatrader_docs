



AverageBarsInTrade

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\averagebarsintrade.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Strategy](strategy-1.htm) > [TradeCollection](tradecollection-1.htm) > [TradesPerformance](tradesperformance-1.htm) >  AverageBarsInTrade | [Previous page](tradesperformance-1.htm) [Return to chapter overview](tradesperformance-1.htm) [Next page](averageentryefficiency-1.htm) |

Definition
----------

Returns the average number of bars per trade.

Property Value
--------------

A double value that represents the average number of bars per trade.

Syntax 
<TradeCollection>.TradesPerformance.AverageBarsInTrade
--------------------------------------------------------------

Examples
--------

| ns |
| --- |
| protected override void OnBarUpdate()  {       // Print out the average number of bars per trade of all trades       Print("Average # bars per trade is: " + SystemPerformance.AllTrades.TradesPerformance.AverageBarsInTrade);  } |