



LongestFlatPeriod

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\longestflatperiod.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Strategy](strategy-1.htm) > [TradeCollection](tradecollection-1.htm) > [TradesPerformance](tradesperformance-1.htm) >  LongestFlatPeriod | [Previous page](grossprofit-1.htm) [Return to chapter overview](tradesperformance-1.htm) [Next page](maxconsecutiveloser-1.htm) |

Definition
----------

Returns the longest duration of being flat.

Property Value
--------------

A TimeSpan value that represents the longest duration of being flat.

Syntax 
<TradeCollection>.TradesPerformance.LongestFlatPeriod
-------------------------------------------------------------

Examples
--------

| ns |
| --- |
| protected override void OnBarUpdate()  {       // Print out the longest duration of being flat       Print("Longest flat period: " + SystemPerformance.AllTrades.TradesPerformance.LongestFlatPeriod);  } |