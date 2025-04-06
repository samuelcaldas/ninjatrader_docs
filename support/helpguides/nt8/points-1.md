



Points

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\points.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Strategy](strategy-1.htm) > [TradeCollection](tradecollection-1.htm) > [TradesPerformance](tradesperformance-1.htm) >  Points | [Previous page](pips-1.htm) [Return to chapter overview](tradesperformance-1.htm) [Next page](profitfactor-1.htm) |

Definition
----------

Returns a [TradesPerformanceValues](tradesperformancevalues-1.htm) object in points.

Property Value
--------------

A TradesPerformanceValues object that is represented in points.

Syntax 
<TradeCollection>.TradesPerformance.Points
--------------------------------------------------

Examples
--------

| ns |
| --- |
| protected override void OnBarUpdate()  {       // Print out the avg. profit of all trades in points       Print("Average profit: " + SystemPerformance.AllTrades.TradesPerformance.Points.AverageProfit);  } |