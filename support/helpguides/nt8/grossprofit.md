



GrossProfit

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](grossprofit.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Strategy](strategy.htm) > [TradeCollection](tradecollection.htm) > [TradesPerformance](tradesperformance.htm) >  GrossProfit | [Previous page](grossloss.htm) [Return to chapter overview](tradesperformance.htm) [Next page](longestflatperiod.htm) |

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