



SortinoRatio

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\sortinoratio.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Strategy](strategy-1.htm) > [TradeCollection](tradecollection-1.htm) > [TradesPerformance](tradesperformance-1.htm) >  SortinoRatio | [Previous page](sharperatio-1.htm) [Return to chapter overview](tradesperformance-1.htm) [Next page](ticks-1.htm) |

Definition
----------

Returns the Sortino ratio using a [risk free return](riskfreereturn-1.htm).

Property Value
--------------

A double value that represents the Sortino ratio using a risk free return.

Syntax 
<TradeCollection>.TradesPerformance.SortinoRatio
--------------------------------------------------------

Examples
--------

| ns |
| --- |
| protected override void OnBarUpdate()  {       // Set a 0% risk free return       SystemPerformance.AllTrades.TradesPerformance.RiskFreeReturn = 0;          // Print out the Sortino ratio of all trades based on a zero risk free return       Print("Sortino ratio is: " + SystemPerformance.AllTrades.TradesPerformance.SortinoRatio);  } |