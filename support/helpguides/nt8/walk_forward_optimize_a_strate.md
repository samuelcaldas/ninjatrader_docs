
Operations > Strategy Analyzer > Walk Forward Optimization
Walk Forward Optimization

| << [Click to Display Table of Contents](walk_forward_optimize_a_strate.md) >> **Navigation:**     [Operations](operations.md) > [Strategy Analyzer](strategy_analyzer.md) > Walk Forward Optimization | [Previous page](optimization_fitness_metrics.md) [Return to chapter overview](strategy_analyzer.md) [Next page](anchored-walk-forward-optimiza.md) |
| --- | --- |
Walk Forward optimization is the process by which you optimize strategy input parameters on a historical segment of market data, then test the strategy forward in time on data following the optimization segment using the optimized input values. The central idea is that you evaluate strategy performance data on the test data, not the data used in the optimization. This process is then repeated by moving the optimization and test segments forward in time. To run a walk forward optimization you will need:
 
- Access to [historical data](data_by_provider.md)

- Custom NinjaScript *[strategy](strategy.md) 

- A thorough understanding of the Strategy Analyzer's backtesting and optimization capabilities

 
| Tip:  There are several pre-defined sample strategies that are installed with NinjaTrader that you can explore. |
| --- |

 
| playVideo |
| --- |
|  |

 
| Note: The [IncludeTradeHistoryInBacktest](includetradehistoryinbacktest.md) property is set to false by default when a strategy is applied in the Strategy Analyzer for optimization. This provides for leaner memory usage, but at the expense of not being able to access Trade objects for historical trades. Thus, fields such as [SystemPerformance.AllTrades.Count](alltrades.md) that rely on references to Trade objects will not have any such references to work with. If you would like to save these objects for reference in your code, you can set IncludeTradeHistoryInBacktest to true in the Configure state. For more information, see the [Working with Historical Trade Data](strategyanalyzer_properties_2.md) page. |
| --- |

![tog_minus](tog_minus.gif)
| Start a Walk Forward Optimization To run a Walk Forward Optimization select the Backtest type of "Walk Forward Optimization" in the settings panel of the Strategy Analyzer.    StrategyAnalyzer_Optimization_WFORuni     | Note: When making the selection additional parameters to configure your optimization will be made visible. | | --- |      Setting the Test Range You can the test range of strategy parameters to be tested by left clicking on the triangle to expand the strategies sub parameters.   Note: If you don't see the triangle make sure that the Backtest type is set to "Walk Forward Optimization".   StrategyAnalyzer_Optimization_Paramters   Min.  - The starting value you want to test  Max.  - The last value to test  Increment - The increment value (step value) used to increment the starting value by for each subsequent optimization pass   In the image above, the input "Fast" has a starting (initial) value of 10 and an ending value of 30 with an increment of 1. This means that the first value tested will be 10, then 11, then 12 all the way through 30. The input "Slow" has a starting value of 6, ending value of 16 with an increment of 1. Based on these settings, a total of 200 (20 unique values for "Fast" multiplied by 10 unique values for "Slow") backtest iterations will be processed in order to find the optimal combination of input values based on the best optimization fitness.   Setting the Optimization Fitness  Optimization is based on the best optimization fitness you select. If you set the property "Optimize on..." to "Max. net profit", the optimizer will seek the optimal input values that return the maximum profit possible. There are over 10 different optimization criterion you can select and can be customized via NinjaScript. Please see the "Understanding Walk Forward properties" section below for more information. |
| --- | --- |

![tog_minus](tog_minus.gif)        [Understanding Walk Forward properties](javascript:HMToggle('toggle','UnderstandingWalkForwardProperties','UnderstandingWalkForwardProperties_ICON'))
| Walk Forward Properties Apart from the walk forward optimization specific properties described below, the properties are identical to the ones found in the Optimization properties window. Please see the "Understanding optimization properties" section of the [Optimize a Strategy](optimize_a_strategy.md) page of the Help Guide for more information.   StrategyAnalyzer_Optimization_WFOParameters     | Tip:  You can optionally "Optimize on" multiple objectives by using a [Multi-Objective optimization](multi-objective_optimization.md) | | --- |        | Keep best # results | Sets the number of best results to display | | --- | --- | | Optimize data series | If set to true, the Data Series Value property will be available for optimization (Not supported for Kagi, PointAndFigure, and Line Break period Types) | | Optimize on... | Sets the optimization fitness to base the optimization results on | | Optimizer | Sets the optimization algorithm that is used. NinjaTrader comes with "Default" and "[Genetic](genetic_algorithm.md)" optimizer algorithms. When the "Genetic" option is selected, the genetic algorithm's optimization properties fields will appear below the Optimizer selection  You can program your own [optimization algorithm](optimizer.md) using NinjaScript. | | Optimization period (days) | Sets the number of days used for the "in sample" optimization data set | | Test period (days) | Sets the number of days used for the "out of sample" real backtest using the optimized input values generated from the "in sample" period | |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |

![tog_minus](tog_minus.gif)        [Understanding Walk Forward results](javascript:HMToggle('toggle','UnderstandingWalkForwardResults','UnderstandingWalkForwardResults_ICON'))
| Understanding Walk Forward Test Results From the Start date to the End date the walk forward optimization will do a standard optimization on the number of days set for parameter "Optimization period (days)". This is known as the "In Sample" test period. After the optimization period NinjaTrader will use the best parameter combination found and test that forward on non-optimized data that has not been seen yet for the number of days set for parameter "Test period (days)". This is known as the "Out of sample" test period. Please see the graph below for a better understanding of how the walk forward results are found. walkforward_graph   The results for each "Test period" are returned and shown in the Optimization Results Grid along with the Start date, End date, and the best combination found by the optimization period.   StrategyAnalyzer_Optimization_BestResults1       | Note: NinjaTrader does save the "Keep best # results" for each Optimization period, if you want to see each individual optimization results you can right click on the walk forward result and select "View Optimization Results". | | --- | |
| --- | --- |
