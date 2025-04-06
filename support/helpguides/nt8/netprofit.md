



NetProfit

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](netprofit.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Strategy](strategy.htm) > [TradeCollection](tradecollection.htm) > [TradesPerformance](tradesperformance.htm) >  NetProfit | [Previous page](monthlyulcer.htm) [Return to chapter overview](tradesperformance.htm) [Next page](percent.htm) |

Definition
----------

Returns the net profit.

Property Value
--------------

A double value that represents the net profit.

Syntax 
<TradeCollection>.TradesPerformance.NetProfit
-----------------------------------------------------

Examples
--------

| ns |
| --- |
| protected override void OnBarUpdate()  {       // Print out the net profit of all trades       Print("Net profit is: " + SystemPerformance.AllTrades.TradesPerformance.NetProfit);  } |