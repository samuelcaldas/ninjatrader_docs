



AverageExitEfficiency

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](averageexitefficiency.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Strategy](strategy.htm) > [TradeCollection](tradecollection.htm) > [TradesPerformance](tradesperformance.htm) >  AverageExitEfficiency | [Previous page](averageentryefficiency.htm) [Return to chapter overview](tradesperformance.htm) [Next page](averagetimeinmarket.htm) |

Definition
----------

Returns the average exit efficiency.

Property Value
--------------

A double value that represents the average exit efficiency.

Syntax 
<TradeCollection>.TradesPerformance.AverageExitEfficiency
-----------------------------------------------------------------

Examples
--------

| ns |
| --- |
| protected override void OnBarUpdate()  {       // Print out the average exit efficiency       Print("Average exit efficiency is: " + SystemPerformance.AllTrades.TradesPerformance.AverageExitEfficiency);  } |