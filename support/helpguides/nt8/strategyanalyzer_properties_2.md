


Operations \> Strategy Analyzer \> Working with Historical Trade Data






















Working with Historical Trade Data







| \<\< [Click to Display Table of Contents](strategyanalyzer_properties_2.md) \>\> **Navigation:**     [Operations](operations.md) \> [Strategy Analyzer](strategy_analyzer.md) \> Working with Historical Trade Data | [Previous page](strategyanalyzer_properties.md) [Return to chapter overview](strategy_analyzer.md) [Next page](strategy_builder.md) |
| --- | --- |











The [Trade](trade.md) class allows you to directly access information about historical trades. However, Trade objects are not always accessible from a NinjaScript strategy by default. The [IncludeTradeHistoryInBacktest](includetradehistoryinbacktest.md) property determines whether references are made in memory to Trade objects, allowing you access them programmatically after a trade has completed, or whether no references are made, freeing up memory for other uses.


 


## IncludeTradeHistoryInBacktest \= True


When the IncludeTradeHistoryInBacktest property is set to true, Trade objects will be saved for later reference. This provides a reference to the object in memory, allowing you to access them in your script. For example, this setting would allow you to evaluate the Max Adverse Excursion statistic of an individual trade placed by the strategy in the past. While this can be convenient to address specific needs, it uses more memory than the alternative option. To maximize performance in cases in which you know you will not need to access historical Trade objects, it is recommended to set IncludeTradeHistoryInBacktest to false in the Configure state in your script (or in SetDefaults state when adding the strategy from the strategy tab).


 


## IncludeTradeHistoryInBacktest \= False


When the IncludeTradeHistoryInBacktest property is set to false, Trade objects will not include a reference in memory. Once a trade is completed, no Trade object will be accessible to the script. This setting allows for leaner memory management by avoiding the storage of a potentially large number of objects that may never be used. That being said, if you know that you will need to access these objects after trades have completed, you can set IncludeTradeHistoryInBacktest to true in the Configure state in your script (or in SetDefaults state when adding the strategy from the strategy tab).


 




| Notes:   •Since trade information is not stored you will only see entry/exit executions plotted on the chart with no connecting PnL trade lines.•IncludeTradeHistoryInBacktest is always defaulted to true, except when the strategy is running on the strategy tab. |
| --- |



 








