# Optimization Fitness Metrics

Optimization fitness metrics are used as the targets of optimization tests to determine the optimal mix of strategy parameter values. Below is a list of all pre-loaded optimization fitness metrics and their definitions. Custom optimization fitness metrics can be developed via NinjaScript, as well.

> Max % Profitable This metric represents the percentage of profitable trades compared to the total number of trades placed in an iteration.    Number of winning trades / Total number of trades

> Max Average Favorable Excursion This metric represents the average maximum run-up in profit during an iteration.    See the "Percent" formula for [Average MFE](../operations/statistics_definitions.md) on the Performance Statistics page.

> Max Avg. Profit This metric represents the average profit of all trades in an iteration.    See the "Percent" formula for [Average Trade](../operations/statistics_definitions.md) on the Performance Statistics page.

## Understanding Max Net Profit

> Max Net Profit This metric represents the net profit achieved for all trades of an iteration.   Total gross profit / Total gross loss

## Understanding Max Profit Factor

> Max Profit Factor This metric provides a ratio of total earnings to total loss in an iteration.   See the [Profit Factor](../operations/statistics_definitions.md) formula on the Statistics Definitions page.

## Understanding Max R Squared (R^2)

> R Squared (R^2) Sometimes called the Coefficient of Determination, this metric measures how closely an iteration's results come to a fitted regression line.   ((Total Trades \* (Summation of Trades \* Summation of Profit)) - (Summation of Trades \* Summation of Profit) / SQRT((Total Trades \* Total Summation of Trades ^ 2 - Summation of Trades ^ 2) \* (Total Trades \* Total Summation of Profit ^ 2 - Total Profit ^ 2))) ^ 2

## Understanding Max Sharpe Ratio

> Max Sharpe Ratio This metric calculates risk-adjusted return.   (% Profit per month - risk free return) / monthly std. deviation     \* if the monthly standard deviation is approximately 0, then set to 1

## Understanding Max Sortino Ratio

> Max Sortino Ratio This metric modifies the Sharpe ratio by taking the standard deviation of negative returns into account to differentiate harmful volatility from general volatility.     (% Profit per month - risk free return) / monthly Ulcer Index     \* if the monthly Ulcer index is approximately 0, then set to 1

## Understanding Max Ulcer Ratio

> Max Ulcer Ratio This metric measures downside risk, with values increasing as the market price moves farther from a recent high.   See the [Ulcer Index](../operations/statistics_definitions.md) formula on the Statistics Definitions page.

## Understanding Max Win/Loss Ratio

> Max Win/Loss Ratio This metric presents a ratio of the profit of winning trades to the loss of losing trades.   % average profit of winning trades / absolute value of % percentage average loss

## Understanding Minimum Avg. Adverse Excursion

> Minimum Avg. Adverse Excursion This metric represents the average run-down of trades in an iteration.    See the "Percent" formula for [Maximum Adverse Excursion](../operations/statistics_definitions.md) on the Statistics Definitions page  Min Avg. Adverse Excursion finds the lowest value from the Maximum Adverse Excursion statistic

## Understanding Min Drawdown

> Minimum Drawdown This fitness metric represents the smallest decrease (draw-down) in account size experienced from the highest high seen in each trade, and is used to find the iteration with the lowest draw-down.    See the [Maximum Drawdown](../operations/statistics_definitions.md) formula on the Statistics Definitions page  Min Drawdown = the smallest single drawdown

## Understanding Max Strength

> Max Strength (Work in progress, implementation could possibly change in the future) This fitness metric finds the 'steadiest' strategy represented by the highest linear regression slope of the equity curve. It favors strategies with as many profitable trades as possible while keeping draw-downs as small as possible.