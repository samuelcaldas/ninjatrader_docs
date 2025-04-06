



SharpeRatio

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](sharperatio.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Strategy](strategy.htm) > [TradeCollection](tradecollection.htm) > [TradesPerformance](tradesperformance.htm) >  SharpeRatio | [Previous page](riskfreereturn.htm) [Return to chapter overview](tradesperformance.htm) [Next page](sortinoratio.htm) |

Definition
----------

Returns the Sharpe ratio using a [risk free return](riskfreereturn.htm).

Property Value
--------------

A double value that represents the Sharpe ratio using a risk free return.

Syntax 
<TradeCollection>.TradesPerformance.SharpeRatio
-------------------------------------------------------

Examples
--------

| ns |
| --- |
| protected override void OnBarUpdate()  {       // Set a 0% risk free return       SystemPerformance.AllTrades.TradesPerformance.RiskFreeReturn = 0;          // Print out the Sharpe ratio of all trades based on a zero risk free return       Print("Sharpe ratio is: " + SystemPerformance.AllTrades.TradesPerformance.SharpeRatio);  } |