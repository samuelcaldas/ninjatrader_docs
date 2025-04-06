



GrossProfit

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\grossprofit.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Strategy](strategy-1.htm) > [TradeCollection](tradecollection-1.htm) > [TradesPerformance](tradesperformance-1.htm) >  GrossProfit | [Previous page](grossloss-1.htm) [Return to chapter overview](tradesperformance-1.htm) [Next page](longestflatperiod-1.htm) |

Definition
----------

Returns the gross profit.

Property Value
--------------

A double value that represents the gross profit.

Syntax 
<TradeCollection>.TradesPerformance.GrossProfit
-------------------------------------------------------

Examples
--------

| ns |
| --- |
| protected override void OnBarUpdate()  {       // Print out the gross profit of all trades       Print("Gross profit is: " + SystemPerformance.AllTrades.TradesPerformance.GrossProfit);  } |