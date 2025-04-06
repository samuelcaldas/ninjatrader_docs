



MaxConsecutiveLoser

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](maxconsecutiveloser.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Strategy](strategy.htm) > [TradeCollection](tradecollection.htm) > [TradesPerformance](tradesperformance.htm) >  MaxConsecutiveLoser | [Previous page](longestflatperiod.htm) [Return to chapter overview](tradesperformance.htm) [Next page](maxconsecutivewinner.htm) |

Definition
----------

Returns the maximum number of consecutive losers seen.

Property Value
--------------

An int value that represents the maximum number of consecutive losers seen.

Syntax 
<TradeCollection>.TradesPerformance.MaxConsecutiveLoser
---------------------------------------------------------------

Examples
--------

| ns |
| --- |
| protected override void OnBarUpdate()  {       // Print out the max consecutive losers of all trades       Print("Max # of consecutive losers is: " + SystemPerformance.AllTrades.TradesPerformance.MaxConsecutiveLoser);  } |