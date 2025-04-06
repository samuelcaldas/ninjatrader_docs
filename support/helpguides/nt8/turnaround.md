



Turnaround

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](turnaround.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Strategy](strategy.htm) > [TradesPerformanceValues](tradesperformancevalues.htm) >  Turnaround | [Previous page](stddev.htm) [Return to chapter overview](tradesperformancevalues.htm) [Next page](ulcer.htm) |

Definition
----------

Returns the amount of turnaround.

Property Value
--------------

A double value that represents the amount of turnaround.

Syntax 
<TradeCollection>.TradesPerformance.<TradesPerformanceValues>.Turnaround
--------------------------------------------------------------------------------

Examples
--------

| ns |
| --- |
| protected override void OnBarUpdate()  {       // Print out the turnaround of all trades       Print("Turnaround of all trades is: " + SystemPerformance.AllTrades.TradesPerformance.Currency.Turnaround);  } |