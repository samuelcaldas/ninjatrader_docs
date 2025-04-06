



RiskFreeReturn

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\riskfreereturn.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Strategy](strategy-1.htm) > [TradeCollection](tradecollection-1.htm) > [TradesPerformance](tradesperformance-1.htm) >  RiskFreeReturn | [Previous page](rsquared-1.htm) [Return to chapter overview](tradesperformance-1.htm) [Next page](sharperatio-1.htm) |

Definition
----------

The risk free return used in calculations of [Sharpe](sharperatio-1.htm) and [Sortino](sortinoratio-1.htm) ratios.

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