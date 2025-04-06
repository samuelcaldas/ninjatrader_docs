



TradesCount

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\tradescount.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Strategy](strategy-1.htm) > [TradeCollection](tradecollection-1.htm) > [TradesPerformance](tradesperformance-1.htm) >  TradesCount | [Previous page](totalslippage-1.htm) [Return to chapter overview](tradesperformance-1.htm) [Next page](tradesperday-1.htm) |

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