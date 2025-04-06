



TotalCommission

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\totalcommission.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Strategy](strategy-1.htm) > [TradeCollection](tradecollection-1.htm) > [TradesPerformance](tradesperformance-1.htm) >  TotalCommission | [Previous page](ticks-1.htm) [Return to chapter overview](tradesperformance-1.htm) [Next page](totalquantity-1.htm) |

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