



Ulcer

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\ulcer.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Strategy](strategy-1.htm) > [TradesPerformanceValues](tradesperformancevalues-1.htm) >  Ulcer | [Previous page](turnaround-1.htm) [Return to chapter overview](tradesperformancevalues-1.htm) [Next page](waitforococlosingbracket-1.htm) |

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