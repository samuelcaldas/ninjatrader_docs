



Ulcer

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](ulcer.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Strategy](strategy.htm) > [TradesPerformanceValues](tradesperformancevalues.htm) >  Ulcer | [Previous page](turnaround.htm) [Return to chapter overview](tradesperformancevalues.htm) [Next page](waitforococlosingbracket.htm) |

Definition
----------

Returns the Ulcer.

Property Value
--------------

A double value that represents the Ulcer.

Syntax 
<TradeCollection>.TradesPerformance.<TradesPerformanceValues>.Ulcer
---------------------------------------------------------------------------

Examples
--------

| ns |
| --- |
| protected override void OnBarUpdate()  {       // Print out the Ulcer index of all trades       Print("Turnaround of all trades is: " + SystemPerformance.AllTrades.TradesPerformance.Currency.Ulcer);  } |