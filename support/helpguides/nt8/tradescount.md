



TradesCount

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](tradescount.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Strategy](strategy.htm) > [TradeCollection](tradecollection.htm) > [TradesPerformance](tradesperformance.htm) >  TradesCount | [Previous page](totalslippage.htm) [Return to chapter overview](tradesperformance.htm) [Next page](tradesperday.htm) |

Definition
----------

Returns the total # of trades.

Property Value
--------------

A double value that represents the total # of trades.

Syntax 
<TradeCollection>.TradesPerformance.TradesCount
-------------------------------------------------------

Examples
--------

| ns |
| --- |
| protected override void OnBarUpdate()  {       // Print out the total # of trades       Print("Trades count is: " + SystemPerformance.AllTrades.TradesPerformance.TradesCount);  } |