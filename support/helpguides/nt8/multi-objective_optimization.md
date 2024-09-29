


Operations \> Strategy Analyzer \> Multi\-Objective Optimization






















Multi\-Objective Optimization







| \<\< [Click to Display Table of Contents](multi-objective_optimization.md) \>\> **Navigation:**     [Operations](operations.md) \> [Strategy Analyzer](strategy_analyzer.md) \> Multi\-Objective Optimization | [Previous page](walk_forward_optimize_a_strate.md) [Return to chapter overview](strategy_analyzer.md) [Next page](ai-generate.md) |
| --- | --- |




[Show/Hide Hidden Text](javascript:HMToggleExpandAll(!HMAnyToggleOpen()) "Click to open/close expanding sections")









Multi\-Objective optimization takes standard optimization a step further by allowing you to choose multiple objectives to test for. When results are returned instead of a singlular list of best results ranked from best to least best instead you will be presented a graph. With multiple objective there is no single best result, instead its up to the trader to choose what is the best tradeoff between two objectives. To run a Multi\-objective optimization you will need:


 


•Access to [historical data](data_by_provider.md)

•Custom NinjaScript \*[strategy](strategy.md) 

•A thorough understanding of the Strategy Analyzer's backtesting and optimization capabilities

 




| Tip:  There are several pre\-defined sample strategies that are installed with NinjaTrader that you can explore. |
| --- |



 




| playVideo |
| --- |
|  |



 




| Note: The [IncludeTradeHistoryInBacktest](includetradehistoryinbacktest.md) property is set to false by default when a strategy is applied in the Strategy Analyzer for optimization. This provides for leaner memory usage, but at the expense of not being able to access Trade objects for historical trades. Thus, fields such as [SystemPerformance.AllTrades.Count](alltrades.md) that rely on references to Trade objects will not have any such references to work with. If you would like to save these objects for reference in your code, you can set IncludeTradeHistoryInBacktest to true in the Configure state. For more information, see the [Working with Historical Trade Data](strategyanalyzer_properties_2.md) page. |
| --- |



![tog_minus](tog_minus.gif)




| Start a Multi\-Objective Optimization To run a Multi\-Objective Optimization select the Backtest type of "Multi\-Objective Optimization" in the settings panel of the Strategy Analyzer.    StrategyAnalyzer_Optimization_MOORun     | Note: When making the selection additional parameters to configure your optimization will be made visible. | | --- |      Setting the Test Range You can set the test range of strategy parameters to be tested by left clicking on the triangle to expand the strategies sub parameters.     | Note: If you don't see the triangle make sure that the Backtest type is set to "Multi\-Objective Optimization". | | --- |      StrategyAnalyzer_Optimization_Paramters   Min.  \- The starting value you want to test  Max.  \- The last value to test  Increment \- The increment value (step value) used to increment the starting value by for each subsequent optimization pass   In the image above, the input "Fast" has a starting (initial) value of 10 and an ending value of 30 with an increment of 1\. This means that the first value tested will be 10, then 11, then 12 all the way through 30\. The input "Slow" has a starting value of 6, ending value of 16 with an increment of 1\. Based on these settings, a total of 200 (20 unique values for "Fast" multiplied by 10 unique values for "Slow") backtest iterations will be processed in order to find the optimal combination of input values based on the best optimization fitness. |
| --- | --- | --- |



![tog_minus](tog_minus.gif)        [Understanding Multi\-Objective  properties](javascript:HMToggle('toggle','UnderstandingMulti-Objectiveproperties','UnderstandingMulti-Objectiveproperties_ICON'))




| Setting Multiple Optimization Fitness  Apart from the "Optimize on" property described below, the properties are identical to the ones found in the Optimization properties window. Please see the "Understanding optimization properties" section of the [Optimize a Strategy](optimize_a_strategy.md) page of the Help Guide for more information.   Multi\-Objective Optimization is based on the best optimization fitness you select. If you set the property "Optimize on" to "Max. net profit", "Max profit factor", and "Min. draw down" the optimizer will seek the optimal input values based on those three optimization fitness objectives.  There are over 10 different optimization criterion you can select and can be customized via NinjaScript.   StrategyAnalyzer_Optimization_MultiObjectiveProperties     | Optimize on... | Sets the optimization fitness to base the optimization results on, left clicking on the field will open the "Edit Optimization Fitness" window where you can enable what optimization fitnesses you want to be tested and to be available for multi\-objective analysis. | | --- | --- |        | Note: For running Multi\-Objective Optimizations the Default optimizer will be used. | | --- |      StrategyAnalyzer_Optimization_OptimizationFitnessDialog |
| --- | --- | --- | --- |



![tog_minus](tog_minus.gif)        [Understanding Multi\-Objective results](javascript:HMToggle('toggle','UnderstandingMultiobjectiveResults','UnderstandingMultiobjectiveResults_ICON'))




| Understanding Multi\-Objective Results Multi\-objective results are displayed on a graph instead of a grid. The reason we use a graph is with a multi\-objective problem there is no one best solution and instead you must compare individual tradeoff between two often competing objectives. Please see the image below to the left with some sample data, each optimization has been performed and the results of each test plotted on the graph. We can narrow down our solution further by only showing results that have the best tradeoff between both objectives  known as a Pareto optimal result. In the graph to the right the line drawn connects the 5 single results that are Pareto optimal forming the Paretor frontier. Any result that falls behind the Pareto frontier is discarded leaving us with 5 best tradeoff solutions between the two objectives.  pareto_frontier_graph Using the Multi\-Objective Graph There are two combo box selections to choose the optimization fitness will be graphed. You will be able to choose any optimization fitness that you have enabled in the optimize on field in the optimization strategies. See the multi\-objective optimization properties section above for more information.   StrategyAnalyzer_Optimization_Multi-Objective   Left clicking on one of the dots will select that optimization run and NinjaTrader will run a backtest with these strategy parameters to retrieve the detailed trade data for further analysis. |
| --- |










