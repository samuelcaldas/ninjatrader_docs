



MonthlyStdDev

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\monthlystddev.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Strategy](strategy-1.htm) > [TradeCollection](tradecollection-1.htm) > [TradesPerformance](tradesperformance-1.htm) >  MonthlyStdDev | [Previous page](maxtimetorecover-1.htm) [Return to chapter overview](tradesperformance-1.htm) [Next page](monthlyulcer-1.htm) |

Definition
----------

Returns the monthly standard deviation.

Property Value
--------------

A double value that represents the monthly standard deviation.

Syntax 
<TradeCollection>.TradesPerformance.MonthlyStdDev
---------------------------------------------------------

Examples
--------

| ns |
| --- |
| protected override void OnBarUpdate()  {       // Print out the monthly standard deviation       Print("Monthly standard deviation is: " + SystemPerformance.AllTrades.TradesPerformance.MonthlyStdDev);  } |