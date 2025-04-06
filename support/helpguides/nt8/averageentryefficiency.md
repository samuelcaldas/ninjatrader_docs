



AverageEntryEfficiency

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](averageentryefficiency.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Strategy](strategy.htm) > [TradeCollection](tradecollection.htm) > [TradesPerformance](tradesperformance.htm) >  AverageEntryEfficiency | [Previous page](averagebarsintrade.htm) [Return to chapter overview](tradesperformance.htm) [Next page](averageexitefficiency.htm) |

Definition
----------

Returns the average entry efficiency.

Property Value
--------------

A double value that represents the average entry efficiency.

Syntax 
<TradeCollection>.TradesPerformance.AverageEntryEfficiency
------------------------------------------------------------------

Examples
--------

| ns |
| --- |
| protected override void OnBarUpdate()  {       // Print out the average entry efficiency       Print("Average entry efficiency is: " + SystemPerformance.AllTrades.TradesPerformance.AverageEntryEfficiency);  } |