



TotalQuantity

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\totalquantity.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Strategy](strategy-1.htm) > [TradeCollection](tradecollection-1.htm) > [TradesPerformance](tradesperformance-1.htm) >  TotalQuantity | [Previous page](totalcommission-1.htm) [Return to chapter overview](tradesperformance-1.htm) [Next page](totalslippage-1.htm) |

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