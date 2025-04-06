



NetProfit

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\netprofit.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Strategy](strategy-1.htm) > [TradeCollection](tradecollection-1.htm) > [TradesPerformance](tradesperformance-1.htm) >  NetProfit | [Previous page](monthlyulcer-1.htm) [Return to chapter overview](tradesperformance-1.htm) [Next page](percent-1.htm) |

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