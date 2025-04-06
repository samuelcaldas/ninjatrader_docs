



Optimization Fitness Metrics

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\optimization_fitness_metrics.htm) >>  **Navigation:**  [Operations](operations-1.htm) > [Strategy Analyzer](strategy_analyzer-1.htm) > [Optimization](optimize_a_strategy-1.htm) >  Optimization Fitness Metrics | [Previous page](genetic_algorithm-1.htm) [Return to chapter overview](optimize_a_strategy-1.htm) [Next page](walk_forward_optimize_a_strate-1.htm) |

Optimization fitness metrics are used as the targets of optimization tests to determine the optimal mix of strategy parameter values. Below is a list of all pre-loaded optimization fitness metrics and their definitions. Custom optimization fitness metrics can be developed via NinjaScript, as well.

![tog_minus](tog_minus-1.gif)        Understanding Max % Profitable

|  |
| --- |
| Max % Profitable This metric represents the percentage of profitable trades compared to the total number of trades placed in an iteration.    Number of winning trades / Total number of trades |

![tog_minus](tog_minus-1.gif)        Understanding Max Avg. Favorable Excursion

|  |
| --- |
| Max Average Favorable Excursion This metric represents the average maximum run-up in profit during an iteration.    See the "Percent" formula for [Average MFE](statistics_definitions-1.htm) on the Performance Statistics page. |

![tog_minus](tog_minus-1.gif)        Understanding Max Avg. Profit

|  |
| --- |
| Max Avg. Profit This metric represents the average profit of all trades in an iteration.    See the "Percent" formula for [Average Trade](statistics_definitions-1.htm) on the Performance Statistics page. |

![tog_minus](tog_minus-1.gif)        Understanding Max Net Profit

|  |
| --- |
| Max Net Profit This metric represents the net profit achieved for all trades of an iteration.   Total gross profit / Total gross loss |

![tog_minus](tog_minus-1.gif)        Understanding Max Profit Factor

|  |
| --- |
| Max Profit Factor This metric provides a ratio of total earnings to total loss in an iteration.   See the [Profit Factor](statistics_definitions-1.htm) formula on the Statistics Definitions page. |

![tog_minus](tog_minus-1.gif)        Understanding Max R Squared (R^2)

|  |
| --- |
| R Squared (R^2) Sometimes called the Coefficient of Determination, this metric measures how closely an iteration's results come to a fitted regression line.   ((Total Trades \* (Summation of Trades \* Summation of Profit)) - (Summation of Trades \* Summation of Profit) / SQRT((Total Trades \* Total Summation of Trades ^ 2 - Summation of Trades ^ 2) \* (Total Trades \* Total Summation of Profit ^ 2 - Total Profit ^ 2))) ^ 2 |

![tog_minus](tog_minus-1.gif)        Understanding Max Sharpe Ratio

|  |
| --- |
| Max Sharpe Ratio This metric calculates risk-adjusted return.   (% Profit per month - risk free return) / monthly std. deviation     \* if the monthly standard deviation is approximately 0, then set to 1 |

![tog_minus](tog_minus-1.gif)        Understanding Max Sortino Ratio

|  |
| --- |
| Max Sortino Ratio This metric modifies the Sharpe ratio by taking the standard deviation of negative returns into account to differentiate harmful volatility from general volatility.     (% Profit per month - risk free return) / monthly Ulcer Index     \* if the monthly Ulcer index is approximately 0, then set to 1 |

![tog_minus](tog_minus-1.gif)        Understanding Max Ulcer Ratio

|  |
| --- |
| Max Ulcer Ratio This metric measures downside risk, with values increasing as the market price moves farther from a recent high.   See the [Ulcer Index](statistics_definitions-1.htm) formula on the Statistics Definitions page. |

![tog_minus](tog_minus-1.gif)        Understanding Max Win/Loss Ratio

|  |
| --- |
| Max Win/Loss Ratio This metric presents a ratio of the profit of winning trades to the loss of losing trades.   % average profit of winning trades / absolute value of % percentage average loss |

![tog_minus](tog_minus-1.gif)        Understanding Minimum Avg. Adverse Excursion

|  |
| --- |
| Minimum Avg. Adverse Excursion This metric represents the average run-down of trades in an iteration.    See the "Percent" formula for [Maximum Adverse Excursion](statistics_definitions-1.htm) on the Statistics Definitions page  Min Avg. Adverse Excursion finds the lowest value from the Maximum Adverse Excursion statistic |

![tog_minus](tog_minus-1.gif)        Understanding Min Drawdown

|  |
| --- |
| Minimum Drawdown This fitness metric represents the smallest decrease (draw-down) in account size experienced from the highest high seen in each trade, and is used to find the iteration with the lowest draw-down.    See the [Maximum Drawdown](statistics_definitions-1.htm) formula on the Statistics Definitions page  Min Drawdown = the smallest single drawdown |

![tog_minus](tog_minus-1.gif)        Understanding Max Strength

|  |
| --- |
| Max Strength (Work in progress, implementation could possibly change in the future) This fitness metric finds the 'steadiest' strategy represented by the highest linear regression slope of the equity curve. It favors strategies with as many profitable trades as possible while keeping draw-downs as small as possible. |