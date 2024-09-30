
NinjaScript \> Language Reference \> Strategy \> TradeCollection \> TradesPerformance
TradesPerformance
| \<\< [Click to Display Table of Contents](tradesperformance.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Strategy](strategy-1.md) \> [TradeCollection](tradecollection-1.md) \> TradesPerformance | [Previous page](losingtrades-1.md) [Return to chapter overview](tradecollection-1.md) [Next page](averagebarsintrade-1.md) |
| --- | --- |
## Definition
Performance profile of a [collection](tradecollection-1.md) of [Trade](trade-1.md) objects.
 
## Methods and Properties
| [AverageBarsInTrade](averagebarsintrade-1.md) | A double value representing the average number of bars per trade |
| --- | --- |
| [AverageEntryEfficiency](averageentryefficiency-1.md) | A double value representing the average entry efficiency |
| [AverageExitEfficiency](averageexitefficiency-1.md) | A double value representing the average exit efficiency |
| [AverageTimeInMarket](averagetimeinmarket-1.md) | A [TimeSpan](http://msdn.microsoft.com/en-us/library/system.timespan.aspx) value representing quantity\-weighted average duration of a trade |
| [AverageTotalEfficiency](averagetotalefficiency-1.md) | A double value representing the average total efficiency |
| [TotalCommission](totalcommission-1.md) | A double value representing the total commission |
| [Currency](currency-1.md) | Gets a [TradesPerformanceValues](tradesperformancevalues-1.md) object in currency |
| [GrossLoss](grossloss-1.md) | A double value representing the gross loss |
| [GrossProfit](grossprofit-1.md) | A double value representing the gross profit |
| [LongestFlatPeriod](longestflatperiod-1.md) | A [TimeSpan](http://msdn2.microsoft.com/en-us/library/system.timespan.aspx) value representing longest duration of being flat |
| [MaxConsecutiveLoser](maxconsecutiveloser-1.md) | An int value representing the maximum number of consecutive losses seen |
| [MaxConsecutiveWinner](maxconsecutivewinner-1.md) | An int value representing the maximum number of consecutive winners seen |
| [MaxTime2Recover](maxtimetorecover-1.md) | A [TimeSpan](http://msdn2.microsoft.com/en-us/library/system.timespan.aspx) value representing maximum time to recover from a draw down |
| [MonthlyStdDev](monthlystddev-1.md) | A double value representing the monthly standard deviation |
| [MonthlyUlcer](monthlyulcer-1.md) | A double value representing the monthly Ulcer index |
| [NetProfit](netprofit-1.md) | A double value representing the net profit |
| [Percent](percent-1.md) | Gets a [TradesPerformanceValues](tradesperformancevalues-1.md) object in percent |
| [PerformanceMetrics](performancemetrics-1.md) | An array of custom NinjaScript performance metrics |
| [Pips](pips-1.md) | Gets a [TradesPerformanceValues](tradesperformancevalues-1.md) object in pips |
| [Points](points-1.md) | Gets a [TradesPerformanceValues](tradesperformancevalues-1.md) object in points |
| [ProfitFactor](profitfactor-1.md) | A double value representing the profit factor |
| [R2](rsquared-1.md) | A double value representing the R\-squared value |
| [RiskFreeReturn](riskfreereturn-1.md) | A double value representing the risk free return rate |
| [SharpeRatio](sharperatio-1.md) | A double value representing the Sharpe Ratio |
| [SortinoRatio](sortinoratio-1.md) | A double value representing the Sortino Ratio |
| [Ticks](ticks-1.md) | Gets a [TradesPerformanceValues](tradesperformancevalues-1.md) object in ticks |
| [TotalQuantity](totalquantity-1.md) | An int value representing the total quantity |
| [TotalSlippage](totalslippage-1.md) | An double value representing the total slippage. This is presented in points, I.E. 0\.25 for 1 execution on E\-mini S\&P 500 Futures. |
| [TradesCount](tradescount-1.md) | An int value representing the trades count |
| [TradesPerDay](tradesperday-1.md) | An int value representing the avg trades per day |

## Examples
| ns |
| --- |
| protected override void OnBarUpdate() {     // Only trade if you have less than 5 consecutive losers in a row     if (SystemPerformance.RealTimeTrades.TradesPerformance.MaxConsecutiveLoser \< 5\)     {         // Trade logic here     } } |
