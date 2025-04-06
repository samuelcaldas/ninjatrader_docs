



RSquared

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](rsquared.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Strategy](strategy.htm) > [TradeCollection](tradecollection.htm) > [TradesPerformance](tradesperformance.htm) >  RSquared | [Previous page](profitfactor.htm) [Return to chapter overview](tradesperformance.htm) [Next page](riskfreereturn.htm) |

Definition
----------

Returns the trade performance R-Squared value.

Property Value
--------------

A double value that represents the R-Squared (R2)

Syntax 
<TradeCollection>.TradesPerformance.RSquared
----------------------------------------------------

Examples
--------

| ns |
| --- |
| protected override void OnBarUpdate()  {       // Print out the R2 value of all trades       Print("R-Squared is: " + SystemPerformance.AllTrades.TradesPerformance.RSquared);  } |