



AverageExitEfficiency

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\averageexitefficiency.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Strategy](strategy-1.htm) > [TradeCollection](tradecollection-1.htm) > [TradesPerformance](tradesperformance-1.htm) >  AverageExitEfficiency | [Previous page](averageentryefficiency-1.htm) [Return to chapter overview](tradesperformance-1.htm) [Next page](averagetimeinmarket-1.htm) |

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