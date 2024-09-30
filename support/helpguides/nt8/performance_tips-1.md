
Operations > Market Analyzer > Performance Tips

Performance Tips

| << [Click to Display Table of Contents](performance_tips.md) >> **Navigation:**     [Operations](operations-1.md) > [Market Analyzer](market_analyzer-1.md) > Performance Tips | [Previous page](working_with_templates-1.md) [Return to chapter overview](market_analyzer-1.md) [Next page](reloading_indicators__columns-1.md) |
| --- | --- |
The following performance tips are specific to the Market Analyzer window.
 
## Number of Instruments and Columns.
- The Market Analyzer has no limit to the number of instruments that can be added. It is important to monitor computer resources to understand your PC's limit.

- The Market Analyzer has no limit to the number of columns, specifically indicator columns, that can be added. Depending on the indicator and "Time Frame" property described below, it may take a few seconds to calculate the indicator. This time is multiplied by the number of instruments in the Market Analyzer which can result in a few minutes of loading time. Decrease the number of instruments or indicator columns to lessen this loading time. 

 
## Indicator Columns
- The Time Frame ("Bars to load", "Days back", "Custom range") property determines the minimum number of bars required to properly initialize each indicator column. The higher the number, the longer it will take to load data and the more memory (RAM) NinjaTrader will use to hold the data in memory.

- Each indicator has a Maximum bars look back parameter in the Columns window that determines how many historical indicator values are stored for access. It is set to TwoHundredFiftySix by default for optimal performance. Setting this to Infinite will take longer to calculate and NinjaTrader will use more memory (RAM) to hold the extra values in memory.

 
## Indicator Calculate on Bar Close Parameter
- All indicators added to the Market Analyzer have the parameter "Calculate" set to "On bar close" as default which only calculates the indicator value on the bar close to help with PC performance.  This parameter can optionally be set to "On price change" which will only calculate when there has been a change in price, or "On each tick" which allows for a tick-by-tick calculation (which will use more CPU resources).  

 
## Dynamic Ranking and Sorting Frequency
- Depending on the number of Instruments you have added to your Market Analyzer display, using a low "[Auto Sort seconds](market_analyzer_properties-1.md)" value can cause your CPU to spike as the auto sort feature continues to re-evaluate the ranking of the column you are sorting.  For example, using a value of 1 second on 100 instruments could potentially overwork your CPU.  Setting this to a higher value, such as every 10-30 seconds, will reduce the CPU workload, and still maintain dynamic sorting at a customizable interval.  You should monitor your CPU workload to find the number of seconds that work for your system.
