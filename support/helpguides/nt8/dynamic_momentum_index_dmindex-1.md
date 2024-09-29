


NinjaScript \> Language Reference \> Common \> System Indicator Methods \> Dynamic Momentum Index (DMIndex)






















Dynamic Momentum Index (DMIndex)







| \<\< [Click to Display Table of Contents](dynamic_momentum_index_dmindex.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [System Indicator Methods](indicators-1.md) \> Dynamic Momentum Index (DMIndex) | [Previous page](double_stochastics-1.md) [Return to chapter overview](indicators-1.md) [Next page](ease_of_movement-1.md) |
| --- | --- |











## Description


An indicator used in technical analysis that determines overbought and oversold conditions of a particular asset. This indicator is very similar to the relative strength index (RSI). The main difference between the two is that the RSI uses a fixed number of time periods (usually 14\), while the dynamic momentum index uses different time periods as volatility changes.


 


... Courtesy of [Investopedia](http://www.investopedia.com/terms/d/dynamicmomentumindex.asp)


 


 


## Syntax


DMIndex(int smooth)  

DMIndex(ISeries\<double\> input, int smooth)


 


Returns default value  

DMIndex(int period)\[int barsAgo]  

DMIndex(ISeries\<double\> input, int smooth)\[int barsAgo]


 


 


## Return Value


double; Accessing this method via an index value \[int barsAgo] returns the indicator value of the referenced bar.


 


 


## Parameters




| input | Indicator source data ([?](valid_input_data_for_indicator-1.md)) |
| --- | --- |
| smooth | The number of bars to include in the calculation |



 


## 


## Example




| ns |
| --- |
| // Prints the current value of DMIndex using default price type double value \= DMIndex(3)\[0]; Print("The current DMIndex value is " \+ value.ToString()); |



 


 


## Source Code


You can view this indicator method source code by selecting the menu New \> NinjaScript Editor \> Indicators within the NinjaTrader Control Center window.








