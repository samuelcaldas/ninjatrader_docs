


NinjaScript \> Language Reference \> Common \> System Indicator Methods \> Rate of Change (ROC)






















Rate of Change (ROC)







| \<\< [Click to Display Table of Contents](rate_of_change_roc.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [System Indicator Methods](indicators-1.md) \> Rate of Change (ROC) | [Previous page](range_indicator_rind-1.md) [Return to chapter overview](indicators-1.md) [Next page](regression_channel-1.md) |
| --- | --- |











## Description


The Rate of Change (ROC) indicator is a very simple yet effective momentum oscillator that measures the percent change in price from one period to the next. The ROC calculation compares the current price with the price n periods ago.


 


... Courtesy of [StockCharts](http://stockcharts.com/education/IndicatorAnalysis/indic_ROC.md)


 


 


## Syntax


ROC(int period)  

ROC(ISeries\<double\> input, int period)


 


Returns default value  

ROC(int period)\[int barsAgo]  

ROC(ISeries\<double\> input, int period)\[int barsAgo]


 


 


## Return Value


double; Accessing this method via an index value \[int barsAgo] returns the indicator value of the referenced bar.


 


 


## Parameters




| input | Indicator source data ([?](valid_input_data_for_indicator-1.md)) |
| --- | --- |
| period | Number of bars used in the calculation |



 


## 


## Examples




| ns |
| --- |
| // Prints the current value of a 20 period ROC using default price type double value \= ROC(20)\[0]; Print("The current ROC value is " \+ value.ToString());   // Prints the current value of a 20 period ROC using high price type double value \= ROC(High, 20)\[0]; Print("The current ROC value is " \+ value.ToString()); |



 


 


## Source Code


You can view this indicator method source code by selecting the menu New \> NinjaScript Editor \> Indicators within the NinjaTrader Control Center window.








