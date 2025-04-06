



TotalQuantity

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](totalquantity.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Strategy](strategy.htm) > [TradeCollection](tradecollection.htm) > [TradesPerformance](tradesperformance.htm) >  TotalQuantity | [Previous page](totalcommission.htm) [Return to chapter overview](tradesperformance.htm) [Next page](totalslippage.htm) |

Definition
----------

Returns the total quantity.

Property Value
--------------

A double value that represents the total quantity.

Syntax 
<TradeCollection>.TradesPerformance.TotalQuantity
---------------------------------------------------------

Examples
--------

| ns |
| --- |
| protected override void OnBarUpdate()  {       // Print out the total quantity of all trades       Print("Total quantity is: " + SystemPerformance.AllTrades.TradesPerformance.TotalQuantity);  } |