



TradesPerformance

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\tradesperformance.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Strategy](strategy-1.htm) > [TradeCollection](tradecollection-1.htm) >  TradesPerformance | [Previous page](losingtrades-1.htm) [Return to chapter overview](tradecollection-1.htm) [Next page](averagebarsintrade-1.htm) |

Definition
----------

Performance profile of a [collection](tradecollection-1.htm) of [Trade](trade-1.htm) objects.

Methods and Properties
----------------------

|  |  |
| --- | --- |
| [AverageBarsInTrade](averagebarsintrade-1.htm) | A double value representing the average number of bars per trade |
| [AverageEntryEfficiency](averageentryefficiency-1.htm) | A double value representing the average entry efficiency |
| [AverageExitEfficiency](averageexitefficiency-1.htm) | A double value representing the average exit efficiency |
| [AverageTimeInMarket](averagetimeinmarket-1.htm) | A [TimeSpan](http://msdn.microsoft.com/en-us/library/system.timespan.aspx) value representing quantity-weighted average duration of a trade |
| [AverageTotalEfficiency](averagetotalefficiency-1.htm) | A double value representing the average total efficiency |
| [TotalCommission](totalcommission-1.htm) | A double value representing the total commission |
| [Currency](currency-1.htm) | Gets a [TradesPerformanceValues](tradesperformancevalues-1.htm) object in currency |
| [GrossLoss](grossloss-1.htm) | A double value representing the gross loss |
| [GrossProfit](grossprofit-1.htm) | A double value representing the gross profit |
| [LongestFlatPeriod](longestflatperiod-1.htm) | A [TimeSpan](http://msdn2.microsoft.com/en-us/library/system.timespan.aspx) value representing longest duration of being flat |
| [MaxConsecutiveLoser](maxconsecutiveloser-1.htm) | An int value representing the maximum number of consecutive losses seen |
| [MaxConsecutiveWinner](maxconsecutivewinner-1.htm) | An int value representing the maximum number of consecutive winners seen |
| [MaxTime2Recover](maxtimetorecover-1.htm) | A [TimeSpan](http://msdn2.microsoft.com/en-us/library/system.timespan.aspx) value representing maximum time to recover from a draw down |
| [MonthlyStdDev](monthlystddev-1.htm) | A double value representing the monthly standard deviation |
| [MonthlyUlcer](monthlyulcer-1.htm) | A double value representing the monthly Ulcer index |
| [NetProfit](netprofit-1.htm) | A double value representing the net profit |
| [Percent](percent-1.htm) | Gets a [TradesPerformanceValues](tradesperformancevalues-1.htm) object in percent |
| [PerformanceMetrics](performancemetrics-1.htm) | An array of custom NinjaScript performance metrics |
| [Pips](pips-1.htm) | Gets a [TradesPerformanceValues](tradesperformancevalues-1.htm) object in pips |
| [Points](points-1.htm) | Gets a [TradesPerformanceValues](tradesperformancevalues-1.htm) object in points |
| [ProfitFactor](profitfactor-1.htm) | A double value representing the profit factor |
| [R2](rsquared-1.htm) | A double value representing the R-squared value |
| [RiskFreeReturn](riskfreereturn-1.htm) | A double value representing the risk free return rate |
| [SharpeRatio](sharperatio-1.htm) | A double value representing the Sharpe Ratio |
| [SortinoRatio](sortinoratio-1.htm) | A double value representing the Sortino Ratio |
| [Ticks](ticks-1.htm) | Gets a [TradesPerformanceValues](tradesperformancevalues-1.htm) object in ticks |
| [TotalQuantity](totalquantity-1.htm) | An int value representing the total quantity |
| [TotalSlippage](totalslippage-1.htm) | An double value representing the total slippage. This is presented in points, I.E. 0.25 for 1 execution on E-mini S&P 500 Futures. |
| [TradesCount](tradescount-1.htm) | An int value representing the trades count |
| [TradesPerDay](tradesperday-1.htm) | An int value representing the avg trades per day |

Examples
--------

| ns |
| --- |
| protected override void OnBarUpdate(){    // Only trade if you have less than 5 consecutive losers in a row    if (SystemPerformance.RealTimeTrades.TradesPerformance.MaxConsecutiveLoser < 5)    {        // Trade logic here    }} |