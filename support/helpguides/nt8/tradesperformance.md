


NinjaScript \> Language Reference \> Strategy \> TradeCollection \> TradesPerformance






















TradesPerformance







| \<\< [Click to Display Table of Contents](tradesperformance.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> [TradeCollection](tradecollection.md) \> TradesPerformance | [Previous page](losingtrades.md) [Return to chapter overview](tradecollection.md) [Next page](averagebarsintrade.md) |
| --- | --- |











## Definition


Performance profile of a [collection](tradecollection.md) of [Trade](trade.md) objects.


 


## Methods and Properties




| [AverageBarsInTrade](averagebarsintrade.md) | A double value representing the average number of bars per trade |
| --- | --- |
| [AverageEntryEfficiency](averageentryefficiency.md) | A double value representing the average entry efficiency |
| [AverageExitEfficiency](averageexitefficiency.md) | A double value representing the average exit efficiency |
| [AverageTimeInMarket](averagetimeinmarket.md) | A [TimeSpan](http://msdn.microsoft.com/en-us/library/system.timespan.aspx) value representing quantity\-weighted average duration of a trade |
| [AverageTotalEfficiency](averagetotalefficiency.md) | A double value representing the average total efficiency |
| [TotalCommission](totalcommission.md) | A double value representing the total commission |
| [Currency](currency.md) | Gets a [TradesPerformanceValues](tradesperformancevalues.md) object in currency |
| [GrossLoss](grossloss.md) | A double value representing the gross loss |
| [GrossProfit](grossprofit.md) | A double value representing the gross profit |
| [LongestFlatPeriod](longestflatperiod.md) | A [TimeSpan](http://msdn2.microsoft.com/en-us/library/system.timespan.aspx) value representing longest duration of being flat |
| [MaxConsecutiveLoser](maxconsecutiveloser.md) | An int value representing the maximum number of consecutive losses seen |
| [MaxConsecutiveWinner](maxconsecutivewinner.md) | An int value representing the maximum number of consecutive winners seen |
| [MaxTime2Recover](maxtimetorecover.md) | A [TimeSpan](http://msdn2.microsoft.com/en-us/library/system.timespan.aspx) value representing maximum time to recover from a draw down |
| [MonthlyStdDev](monthlystddev.md) | A double value representing the monthly standard deviation |
| [MonthlyUlcer](monthlyulcer.md) | A double value representing the monthly Ulcer index |
| [NetProfit](netprofit.md) | A double value representing the net profit |
| [Percent](percent.md) | Gets a [TradesPerformanceValues](tradesperformancevalues.md) object in percent |
| [PerformanceMetrics](performancemetrics.md) | An array of custom NinjaScript performance metrics |
| [Pips](pips.md) | Gets a [TradesPerformanceValues](tradesperformancevalues.md) object in pips |
| [Points](points.md) | Gets a [TradesPerformanceValues](tradesperformancevalues.md) object in points |
| [ProfitFactor](profitfactor.md) | A double value representing the profit factor |
| [R2](rsquared.md) | A double value representing the R\-squared value |
| [RiskFreeReturn](riskfreereturn.md) | A double value representing the risk free return rate |
| [SharpeRatio](sharperatio.md) | A double value representing the Sharpe Ratio |
| [SortinoRatio](sortinoratio.md) | A double value representing the Sortino Ratio |
| [Ticks](ticks.md) | Gets a [TradesPerformanceValues](tradesperformancevalues.md) object in ticks |
| [TotalQuantity](totalquantity.md) | An int value representing the total quantity |
| [TotalSlippage](totalslippage.md) | An double value representing the total slippage. This is presented in points, I.E. 0\.25 for 1 execution on E\-mini S\&P 500 Futures. |
| [TradesCount](tradescount.md) | An int value representing the trades count |
| [TradesPerDay](tradesperday.md) | An int value representing the avg trades per day |



 


 


## Examples




| ns |
| --- |
| protected override void OnBarUpdate() {     // Only trade if you have less than 5 consecutive losers in a row     if (SystemPerformance.RealTimeTrades.TradesPerformance.MaxConsecutiveLoser \< 5\)     {         // Trade logic here     } } |









