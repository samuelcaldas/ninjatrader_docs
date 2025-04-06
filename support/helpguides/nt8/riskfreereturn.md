



RiskFreeReturn

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](riskfreereturn.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Strategy](strategy.htm) > [TradeCollection](tradecollection.htm) > [TradesPerformance](tradesperformance.htm) >  RiskFreeReturn | [Previous page](rsquared.htm) [Return to chapter overview](tradesperformance.htm) [Next page](sharperatio.htm) |

Definition
----------

The risk free return used in calculations of [Sharpe](sharperatio.htm) and [Sortino](sortinoratio.htm) ratios.

Property Value
--------------

A double value that represents the risk free return.

Syntax 
<TradeCollection>.TradesPerformance.RiskFreeReturn
----------------------------------------------------------

Examples
--------

| ns |
| --- |
| protected override void OnBarUpdate()  {       // Set a 3.5% risk free return       SystemPerformance.AllTrades.TradesPerformance.RiskFreeReturn = 0.035;          // Print out the Sharpe ratio of all trades based on a 3.5% risk free return       Print("Sharpe ratio is: " + SystemPerformance.AllTrades.TradesPerformance.SharpeRatio);  } |