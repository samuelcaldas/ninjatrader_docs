
Operations > Trade Performance > Statistics Definitions

Statistics Definitions

| << [Click to Display Table of Contents](statistics_definitions.md) >> **Navigation:**     [Operations](operations.md) > [Trade Performance](trade_performance.md) > Statistics Definitions | [Previous page](performance_displays.md) [Return to chapter overview](trade_performance.md) [Next page](profit_and_loss_calculation_modes.md) |
| --- | --- |
The following are definitions and formulas used for Trade Performance statistics. 
 

| Notes:   - Quantity is defined as the number of contracts traded- Point value is defined as the monetary conversion of each point (e.g. 100 for currency pairs)- FX lot size is the default Forex Lot Size for the account- Please also review the information on [Profit and Loss Calculation Modes](profit_and_loss_calculation_modes.md) where noted as applicable |
| --- |
 
![tog_minus](tog_minus.gif)

| Profit The difference in price between the entry and exit execution.  This value may be positive or negative and is used to determine winning vs losing trades   - (exit price – entry price) for long trades  - (entry price – exit price) for short trades     | Note:  This statistic may also display in selected Display Units (percent, points, pips or ticks).  To see the base calculation behind each execution, view the [Profit and Loss Calculation Modes](profit_and_loss_calculation_modes.md) page. | | --- | |
| --- | --- |
![tog_minus](tog_minus.gif)

| Total net profit This statistic returns a monetary value representing a final cumulative profit of the all profitable trades and all unprofitable trades.     | Currency, Pips, Points, Ticks | SUM(gross profit and gross loss) of all trades | | --- | --- | | Percentage | SUM((1 + gross profit in percent) * ( 1 + gross loss in percent) - 1) of all trades |        | Notes:   - See also Understanding Gross Profit and Understanding Gross Loss on this page- This statistic may also display in selected Display Units (percent, points, pips or ticks).  To see the base calculation behind each execution, view the [Profit and Loss Calculation Modes](profit_and_loss_calculation_modes.md) page. | | --- | |
| --- | --- | --- | --- | --- | --- |
![tog_minus](tog_minus.gif)

| Gross Profit This statistic returns a monetary value representing a summation of all the money earned across all your trades.     | Currency, Pips, Points, Ticks | SUM(profit * quantity) of all winning trades | | --- | --- | | Percentage | SUM((1 + Current gross profit in percent) * ( 1 + gross profit in percent) - 1) of all winning trades |        | Note:  This statistic may also display in selected Display Units (percent, points, pips or ticks).  To see the base calculation behind each execution, view the [Profit and Loss Calculation Modes](profit_and_loss_calculation_modes.md) page. | | --- | |
| --- | --- | --- | --- | --- | --- |
![tog_minus](tog_minus.gif)        [Understanding Gross Loss](javascript:HMToggle('toggle','UnderstandingGrossLoss','UnderstandingGrossLoss_ICON'))

| Gross Loss This statistic returns a monetary value representing a summation of all the money lost across all your trades.     | Currency, Pips, Points, Ticks | SUM(profit * quantity) of all losing trades | | --- | --- | | Percentage | SUM((1 + Current gross loss in percent) * ( 1 + gross loss in percent) - 1) of all losing trades |        | Note:  This statistic may also display in selected Display Units (percent, points, pips or ticks).  To see the base calculation behind each execution, view the [Profit and Loss Calculation Modes](profit_and_loss_calculation_modes.md) page. | | --- | |
| --- | --- | --- | --- | --- | --- |
![tog_minus](tog_minus.gif)        [Understanding Commission](javascript:HMToggle('toggle','UnderstandingCommission','UnderstandingCommission_ICON'))

| Commission This statistic returns a monetary value that is the summation of all the commission fees associated with the trades executed.   SUM(commission of all traded executions)     | Note:  Commissions must be setup on the account using a [Commission template](understanding_commissions.md) | | --- | |
| --- | --- |
![tog_minus](tog_minus.gif)        [Understanding Profit Factor](javascript:HMToggle('toggle','UnderstandingProfitFactor','UnderstandingProfitFactor_ICON'))

| Profit Factor This statistic returns a ratio that can be used as a performance measure for your strategy. It gives you an idea of how much more money your strategy earns then it loses. A higher ratio can be considered characteristic of a high performing strategy. A ratio less than one indicates your strategy loses more money than it earns.   Gross Profit / Gross Loss |
| --- |
![tog_minus](tog_minus.gif)        [Understanding Max. Drawdown](javascript:HMToggle('toggle','UnderstandingMaxDrawdown','UnderstandingMaxDrawdown_ICON'))

| Max. Drawdown The maximum drawdown statistic provides you with information regarding the biggest decrease (drawdown) in account size experienced from the highest high seen. Drawdown is often used as an indicator of risk.   Drawdown = local maximum realized profit – local minimum realized loss Max Drawdown = single largest Drawdown   As an example, your account rises from $25,000 to $50,000. It then subsequently drops to $40,000 but rises again to $60,000. The drawdown in this case would be $10,000 or -20%. Take note that drawdown does not necessarily have to correspond with a loss in your original account principal.     | Note:  This statistic may also display in selected Display Units (percent, points, pips or ticks).  To see the base calculation behind each execution, view the [Profit and Loss Calculation Modes](profit_and_loss_calculation_modes.md) page. | | --- | |
| --- | --- |
![tog_minus](tog_minus.gif)        [Understanding Sharpe Ratio](javascript:HMToggle('toggle','UnderstandingSharpeRatio','UnderstandingSharpeRatio_ICON'))

| Sharpe Ratio This statistic returns a ratio that measures the risk premium per unit of risk of your strategy. It can help you make decisions based on the excess risk of your strategies. You may have a high-return strategy, but the high returns may come at a cost of excess risk. The Sharpe ratio will help you determine if it is an appropriate increase in risk for the higher return or not. Generally, a ratio of 1 or greater is good, 2 or greater is very good, and 3 and up is great.   (Profit per Month – risk free Rate of Return) / standard deviation of monthly profits       | Notes:  - See also Understanding Profit Per Month on this page- NinjaTrader hard sets "risk-free Rate of Return" to a value of zero- The Sharpe Ratio is set to a value of "1" if there is insufficient data to calculate the monthly standard deviation of profits (i.e., there is only 1 month of trade history or less)- A month is defined as 30.5 days which is the (number of days) / (number of months in a year considering leap year) | | --- | |
| --- | --- |
![tog_minus](tog_minus.gif)        [Understanding Sortino Ratio](javascript:HMToggle('toggle','UnderstandingSortinoRatio','UnderstandingSortinoRatio_ICON'))

| Sortino Ratio This statistic is used the same as Sharpe Ratio, the only difference being that Sortino only takes into account the downside deviation. You would want to use this statistic if you wanted to differentiate between harmful volatility from volatility in general (Sharpe Ratio).   (Profit per Month – risk free Rate of Return) / standard deviation of monthly drawdown   See also Understanding Profit Per Month on this page.     | Notes:  - NinjaTrader hard sets "risk-free Rate of Return" to a value of zero- The Sortino Ratio is set to a value of "1" if there is insufficient data to calculate the monthly standard deviation of profits (i.e., there is only 1 month of trade history or less)- A month is defined as 30.5 days which is the (number of days) / (number of months in a year considering leap year) | | --- | |
| --- | --- |
![tog_minus](tog_minus.gif)        [Understanding Ulcer Index](javascript:HMToggle('toggle','UnderstandingUlcerIndex','UnderstandingUlcerIndex_ICON'))

| Ulcer Index This statistic measures downside risk, the Ulcer Index becomes higher as profit declines from the max realized profit achieved and lower as profit rises. The lower the value the better as this indicates there is overall less downside risk.      | Currency | SQRT(Summation((cumulative currency profit - maximum realized currency profit) ^2 ) / Total # of trades) | | --- | --- | | Percent | SQRT(Summation((1 + cumulative percent profit / (1 + maximum realized percent profit) - 1) ^2 ) / Total # of trades) | | Points | SQRT(Summation((cumulative point profit - maximum realized point profit) ^2 ) / Total # of trades) | | Pips | SQRT((Summation((cumulative point profit - maximum realized point profit) ^2) / PipSize ) / Total # of trades) | | Ticks | SQRT((Summation((cumulative point profit - maximum realized point profit) ^2) / TickSize ) / Total # of trades) | |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
![tog_minus](tog_minus.gif)        [Understanding Probability](javascript:HMToggle('toggle','UnderstandingProbability','UnderstandingProbability_ICON'))

| Probability This statistic determines how likely a trade is to occur that would return the same PnL as your Avg. trade. This is based on how many trade's PnL fall within a standard deviation of the Avg. trade. Student's t-distribution is used to find probability. |
| --- |
![tog_minus](tog_minus.gif)        [Understanding Winning, Losing, Even, and Total Number of Trades](javascript:HMToggle('toggle','Understandingtradetotals','Understandingtradetotals_ICON'))

| Trade totals These are a simple statistics used to gauge the overall performance of the performance report.      | Total # of trades | The total number of trades taken between the start and end date in the collection | | --- | --- | | # of winning trades | The total number of trades which profit in point is greater than 0 | | # of losing trades | The total number of trades which is less than 0 | | # of even trades | The total number of trades which profit in point is equal to 0 | | Percent profitable | The total number of profitable trades divided by the total number of trades |          | Note:  The winning and losing trades are factored by their [calculated profits](profit_and_loss_calculation_modes.md) solely in points.  It is possible to have trades which are technically profitable in percent, but are not profitable based on their point value (or vice versa) | | --- | |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
![tog_minus](tog_minus.gif)        [Understanding Average Trade](javascript:HMToggle('toggle','UnderstandingAverageTrade','UnderstandingAverageTrade_ICON'))

| Average Trade This statistic returns a value representing the average profit you experience from all of your trades. It is useful for getting an idea of how much you could expect to earn on future trades.     | Currency | SUM(profit * quantity * point value) of all trades / # of trades | | --- | --- | | Percent | SUM(profit * quantity / entry price) of all trades / # of traded lots | | Points | SUM(profit * quantity) of all trades / # of trades | | Pips | SUM(profit * quantity / FX lot size) of all trades / # of trades | | Ticks | SUM(profit * quantity / tick size) of all trades / # of trades | |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
![tog_minus](tog_minus.gif)        [Understanding Average Winning Trade](javascript:HMToggle('toggle','UnderstandingAverageWinningTrade','UnderstandingAverageWinningTrade_ICON'))

| Average Winning Trade This statistic returns a value representing the average profit you experience from all of your winning trades. It is useful for getting an idea of how much you could expect to earn on winning trades.     | Currency | SUM(profit * quantity * point value) of all winning trades / # of winning trades | | --- | --- | | Percent | SUM(profit * quantity / entry price) of all winning trades / # of winning traded lots | | Points | SUM(profit * quantity) of all winning trades / # of winning trades | | Pips | SUM(profit * quantity / FX lot size) of all winning trades / # of winning trades | | Ticks | SUM(profit * quantity / tick size) of all winning trades / # of winning trades | |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
![tog_minus](tog_minus.gif)        [Understanding Average Losing Trade](javascript:HMToggle('toggle','UnderstandingAverageLosingTrade','UnderstandingAverageLosingTrade_ICON'))

| Average Losing Trade This statistic returns a value representing the average loss you experience from all of your losing trades. It is useful for getting an idea of how much you could expect to lose on losing trades.     | Currency | SUM(loss * quantity * point value) of all losing trades / # of losing trades | | --- | --- | | Percent | SUM(profit * quantity / entry price) of all losing trades / # of losing traded lots | | Points | SUM(profit * quantity) of all losing trades / # of losing trades | | Pips | SUM(profit * quantity / FX lot size) of all losing trades / # of losing trades | | Ticks | SUM(profit * quantity / tick size) of all losing trades / # of losing trades | |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
![tog_minus](tog_minus.gif)        [Understanding Ratio Avg Win / Avg Loss](javascript:HMToggle('toggle','UnderstandingRatioAvgWinAvgLoss','UnderstandingRatioAvgWinAvgLoss_ICON'))

| Ratio Avg Win / Avg Loss This statistic returns a ratio that can be used as a performance measure for your strategy. A value greater than 1 signifies you win more than you lose. A value less than 1 signifies you lose more than you win.   Average Winning Trade / Average Losing Trade |
| --- |
![tog_minus](tog_minus.gif)        [Understanding Maximum Consecutive Winners](javascript:HMToggle('toggle','UnderstandingMaximumConsecutiveWinners','UnderstandingMaximumConsecutiveWinners_ICON'))

| Max. consec. winners This statistic returns the largest number of winning trades which followed a previous winning trade.  Once a losing trade is detected, the consecutive winner count is reset until another winning trade is found |
| --- |
![tog_minus](tog_minus.gif)        [Understanding Maximum Consecutive Losers](javascript:HMToggle('toggle','UnderstandingMaximumConsecutiveLosers','UnderstandingMaximumConsecutiveLosers_ICON'))

| Max. consec. losers This statistic returns the largest number of losing trades which followed a previous losing trade.  Once a winning trade is detected, the consecutive loser count is reset until another losing trade is found |
| --- |
![tog_minus](tog_minus.gif)        [Understanding Largest Winning Trade](javascript:HMToggle('toggle','UnderstandingLargestWinningTrade','UnderstandingLargestWinningTrade_ICON'))

| Largest winning trade This statistic returns the the most profitable trade value from the collection of trades     | Note:  This statistic may also display in selected Display Units (percent, points, pips or ticks).  To see the base calculation behind each execution, view the [Profit and Loss Calculation Modes](profit_and_loss_calculation_modes.md) page. | | --- | |
| --- | --- |
![tog_minus](tog_minus.gif)        [Understanding Largest Losing Trade](javascript:HMToggle('toggle','UnderstandingLargestLosingTrade','UnderstandingLargestLosingTrade_ICON'))

| Largest losing trade This statistic returns the the least profitable trade value from the collection of trades     | Note:  This statistic may also display in selected Display Units (percent, points, pips or ticks).  To see the base calculation behind each execution, view the [Profit and Loss Calculation Modes](profit_and_loss_calculation_modes.md) page. | | --- | |
| --- | --- |
![tog_minus](tog_minus.gif)        [Understanding Average # of trades per day](javascript:HMToggle('toggle','UnderstandingAverageOfTradesPerDay','UnderstandingAverageOfTradesPerDay_ICON'))

| Average # of Trades per Day This statistic returns a value that represents the average # of trades you take per day. This is useful so you can determine if you are overtrading. This statistic excludes weekends and holidays by using a 252 trading days in a year constant.    SUM(of all trades) / (# of days between the date of the first trade and the date of the last trade) * 252 / 365 |
| --- |
![tog_minus](tog_minus.gif)        [Understanding Average Time in Market](javascript:HMToggle('toggle','UnderstandingAverageTimeInMarket','UnderstandingAverageTimeInMarket_ICON'))

| Average Time in Market This statistic returns a value that gives you an idea of how long you can expect your positions to be open. You can use this by manually closing out a position if you feel it has been in the market for too long.   SUM(exit date/time – entry date/time) of all trades / # of trades |
| --- |
![tog_minus](tog_minus.gif)        [Understanding Profit Per Month](javascript:HMToggle('toggle','UnderstandingProfitPerMonth','UnderstandingProfitPerMonth_ICON'))

| Profit Per Month This statistic returns a value that can be used as a performance measure for your strategy. It gives you an idea of how much profit you can expect to make per month. A month is defined as 30.5 days which found by the following: (number of days) / (number of months in a year considering leap year)     | Currency | cumulative profit * (30.5 / # days) | | --- | --- | | Percent | (1 + cumulative profit)(1 * (30.5 / # days)) - 1 | | Points | cumulative profit * (30.5 / # days) | | Pips | cumulative profit * (30.5 / # days) | | Ticks | cumulative profit * (30.5 / # days) |        | Note: See the cumulative profit statistic below for its definition | | --- | |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
![tog_minus](tog_minus.gif)        [Understanding Max. Time to Recover](javascript:HMToggle('toggle','UnderstandingMaxTimeToRecover','UnderstandingMaxTimeToRecover_ICON'))

| Max. Time to Recover The maximum time to recover statistic returns the largest time it took to recover back to the highest profit experienced. This indicates how long you waited before becoming profitable again. |
| --- |
![tog_minus](tog_minus.gif)        [Understanding Longest Flat Period](javascript:HMToggle('toggle','UnderstandingLongestFlatPeriod','UnderstandingLongestFlatPeriod_ICON'))

| Longest Flat Period This statistic returns the longest time duration that occurred between trades.  This may be reflected in total minutes, or total days.   current trade entry time - last trade exit time |
| --- |
![tog_minus](tog_minus.gif)        [Understanding Average MAE](javascript:HMToggle('toggle','UnderstandingAverageMae','UnderstandingAverageMae_ICON'))

| Average MAE  (Maximum Adverse Excursion) This statistic returns a value representing the average maximum run-down your trades experience. This information helps you gauge how poorly your entry conditions predict upcoming price movement directions. A low percentage here is desirable since it would imply that the price movement after you enter a position follows the direction of your intended trade.     | Currency | SUM(MAE * quantity * point value) of all trades / # of trades | | --- | --- | | Percent | SUM(MAE * quantity / entry price) of all trades / # of traded lots | | Points | SUM(MAE * quantity) of all trades / # of trades | | Pips | SUM(MAE * quantity / FX lot size) of all trades / # of trades | | Ticks | SUM(MAE * quantity / tick size) of all trades / # of trades |        | Note:  - MAE (max. adverse excursion) is defined as worst price trade reached – entry price- For real-time trades, the maximum and minimum price seen is recorded live during the duration of the trade and stored per entry/exit execution.  This value includes bid/ask prices which may not be reflected on the chart.  If there are time periods where you are not receiving real-time price updates, those prices within that period cannot be used.  - When backtesting, the high and low of the bar series is used- This currently is not supported with the NinjaTrader server side Trade Performance results | | --- | |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
![tog_minus](tog_minus.gif)        [Understanding Average MFE](javascript:HMToggle('toggle','UnderstandingAverageMfe','UnderstandingAverageMfe_ICON'))

| Average MFE  (Maximum Favorable Excursion) This statistic returns a value representing the average maximum run-up your strategy experiences. This information helps you gauge how well your strategy’s entry conditions predict upcoming price movements. A high percentage here is desirable since it would imply high profitability opportunities.     | Currency | SUM(MFE * quantity * point value) of all trades / # of trades | | --- | --- | | Percent | SUM(MFE * quantity / entry price) of all trades / # of traded lots | | Points | SUM(MFE * quantity) of all trades / # of trades | | Pips | SUM(MFE * quantity / FX lot size) of all trades / # of trades | | Ticks | SUM(MFE * quantity / tick size) of all torades / # of trades |        | Note:  - MFE (max. favorable excursion) is defined as (best price trade reached – entry price) - For real-time trades, the maximum and minimum price seen is recorded live during the duration of the trade and stored per entry/exit execution.  This value includes bid/ask prices which may not be reflected on the chart.  If there are time periods where you are not receiving real-time price updates, those prices within that period cannot be used.  - When backtesting, the high and low of the bar series is used- This currently is not supported with the NinjaTrader server side Trade Performance results | | --- | |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
![tog_minus](tog_minus.gif)        [Understanding Average ETD](javascript:HMToggle('toggle','UnderstandingAverageEtd','UnderstandingAverageEtd_ICON'))

| Average ETD  (End Trade Drawdown) This statistic returns a value that is useful in giving you a measure of how effective your exit conditions capture the price movements after your strategy enters a position. It shows you how much you give back from the best price reached before you exit the trade. A small number here is generally desirable since it would imply highly optimized exit conditions that capture most of the price movement you were after.    Average MFE – Average Trade |
| --- |
![tog_minus](tog_minus.gif)        [Understanding Cumulative Profit](javascript:HMToggle('toggle','UnderstandingCumulativeProfit','UnderstandingCumulativeProfit_ICON'))

| Cumulative profit This statistic returns a value representing a summation of all the profit earned by all your trades. It can be interpreted as a performance measure.      | Currency | SUM(Profit in Currency) of all trades | | --- | --- | | Percent | SUM((1 + Current Profit in Percent) * (1 + Profit in Percent) - 1) for all trades | | Points | SUM(Profit in Points) of all trades | | Pips | SUM(Profit in Points / Pip Size) for all trades | | Ticks | SUM(Profit in Points / Pip Size) for all trades |        | Tip: Cumulative profit in % mode will reinvest your profits - as an example let's say you take 3 trades on a starting value of 10K - on these trades you made $500, $1000, and $750. The starting percentages for these trades are 5%, 10%, and 7.5%, respectively. On Trade 1, we made 5% of $10k, which is $500. Rolling that into Trade 2, we made 7.5 % of ($10k + $500), or $1050. Rolling that into trade 3, we made 7.5% of ($10k + $500 + $1050) or $866.25 . This means that after the 3rd trade, we made an extra $866.25 by cumulating profits. This means our cumulative net profit will show ($500 + $1000 + $750 + $866.25) / $10k or 31% of our investment, and not ($500 + $1000 + $750) / $10k = 22.5% of our investment. | | --- |        | Note:  To see the base calculation behind each calculation mode, view the [Profit and Loss Calculation Modes](profit_and_loss_calculation_modes.md) page. | | --- | |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
![tog_minus](tog_minus.gif)        [Understanding Entry, Exit, and Total Efficiency](javascript:HMToggle('toggle','UnderstandingEntryExitAndTotalEfficiency','UnderstandingEntryExitAndTotalEfficiency_ICON'))

| Following are the formulas for the calculation of the entry, exit, and total efficiency.   Assume the following: - Enter long at price of 100 - Market moves down to a price of 90 - Market moves up to a price of 130 - Exit at a price of 110   Entry Efficiency is Calculated as:   (maximum price seen - entry price) / (maximum price seen - minimum price seen) = (130 - 100) / (130 - 90) = 75% = The entry took 75% of the trade range   Exit Efficiency is Calculated as:   (exit price - minimum price seen) / (maximum price seen - minimum price seen) = (110 - 90) / (130 - 90) = 50% = The exit took 50% of the available trade range   Total Efficiency is Calculated as:   (exit price - entry price) / (maximum price seen - minimum price seen) = (110 - 100) / (130 - 90) = 25% = The trade represented only 25% of the trade range     | Note:  - The formulas are reversed for short - The blue line on any efficiency graph represents the average - For real-time trades, the maximum and minimum price seen is recorded live during the duration of the trade and stored per entry/exit execution.  This value includes bid/ask prices which may NOT be reflected on the chart.  If there are time periods where you are receiving real-time price updates, those prices within that period are not used.- When backtesting, the high and low of the bar series is used- These statistics may also display in selected Display Units (percent, points, pips or ticks).  To see the base calculation behind each execution, view the [Profit and Loss Calculation Modes](profit_and_loss_calculation_modes.md) page | | --- | |
| --- | --- |

