



GrossLoss

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](grossloss.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Strategy](strategy.htm) > [TradeCollection](tradecollection.htm) > [TradesPerformance](tradesperformance.htm) >  GrossLoss | [Previous page](currency.htm) [Return to chapter overview](tradesperformance.htm) [Next page](grossprofit.htm) |

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