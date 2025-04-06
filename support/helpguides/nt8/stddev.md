



StdDev

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](stddev.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Strategy](strategy.htm) > [TradesPerformanceValues](tradesperformancevalues.htm) >  StdDev | [Previous page](profitpermonth.htm) [Return to chapter overview](tradesperformancevalues.htm) [Next page](turnaround.htm) |

Definition
----------

Returns the standard deviation of the collection on a per unit basis.

Property Value
--------------

A double value that represents the standard deviation of the collection on a per unit basis.

Syntax 
<TradeCollection>.TradesPerformance.<TradesPerformanceValues>.StdDev
----------------------------------------------------------------------------

Examples
--------

| ns |
| --- |
| protected override void OnBarUpdate()  {       // Print out the standard deviation of all trades       Print("Standard deviation of all trades is: " + SystemPerformance.AllTrades.TradesPerformance.Currency.StdDev);  } |