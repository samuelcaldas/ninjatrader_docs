



TotalCommission

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](totalcommission.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Strategy](strategy.htm) > [TradeCollection](tradecollection.htm) > [TradesPerformance](tradesperformance.htm) >  TotalCommission | [Previous page](ticks.htm) [Return to chapter overview](tradesperformance.htm) [Next page](totalquantity.htm) |

Definition
----------

Returns the total commission.

Property Value
--------------

A double value that represents the total commission.

Syntax 
<TradeCollection>.TradesPerformance.TotalCommission
-----------------------------------------------------------

Examples
--------

| ns |
| --- |
| protected override void OnBarUpdate()  {       // Print out the total commission of all trades       Print("Total commission is: " + SystemPerformance.AllTrades.TradesPerformance.TotalCommission);  } |