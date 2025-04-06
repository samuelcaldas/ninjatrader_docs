



ProfitPerMonth

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](profitpermonth.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Strategy](strategy.htm) > [TradesPerformanceValues](tradesperformancevalues.htm) >  ProfitPerMonth | [Previous page](largestwinner.htm) [Return to chapter overview](tradesperformancevalues.htm) [Next page](stddev.htm) |

Definition
----------

Returns the profit per month of the collection. This value is always returned as a percentage.

Property Value
--------------

A double value that represents the profit per month of the collection as a percentage.

Syntax 
<TradeCollection>.TradesPerformance.<TradesPerformanceValues>.ProfitPerMonth
------------------------------------------------------------------------------------

Examples
--------

| ns |
| --- |
| protected override void OnBarUpdate()  {       // Print out the profit per month of all trades       Print("Profit per month of all trades is: " + SystemPerformance.AllTrades.TradesPerformance.Currency.ProfitPerMonth);  } |