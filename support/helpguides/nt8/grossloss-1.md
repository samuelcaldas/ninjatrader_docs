



GrossLoss

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\grossloss.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Strategy](strategy-1.htm) > [TradeCollection](tradecollection-1.htm) > [TradesPerformance](tradesperformance-1.htm) >  GrossLoss | [Previous page](currency-1.htm) [Return to chapter overview](tradesperformance-1.htm) [Next page](grossprofit-1.htm) |

Definition
----------

Returns the gross loss.

Property Value
--------------

A double value that represents the gross loss.

Syntax 
<TradeCollection>.TradesPerformance.GrossLoss
-----------------------------------------------------

Examples
--------

| ns |
| --- |
| protected override void OnBarUpdate()  {       // Print out the gross loss of all trades       Print("Gross loss is: " + SystemPerformance.AllTrades.TradesPerformance.GrossLoss);  } |