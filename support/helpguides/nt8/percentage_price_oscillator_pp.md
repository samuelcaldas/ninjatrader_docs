


NinjaScript \> Language Reference \> Common \> System Indicator Methods \> Percentage Price Oscillator (PPO)






















Percentage Price Oscillator (PPO)







| \<\< [Click to Display Table of Contents](percentage_price_oscillator_pp.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [System Indicator Methods](indicators.md) \> Percentage Price Oscillator (PPO) | [Previous page](parabolic_sar.md) [Return to chapter overview](indicators.md) [Next page](pivots.md) |
| --- | --- |











## Description


The Percentage Price Oscillator shows the percentage difference between two [exponential moving averages](moving_average_-_exponential_e.md). 


 


 


## Syntax


PPO(int fast, int slow, int smooth)  

PPO(ISeries\<double\> input, int fast, int slow, int smooth)


 


Returns default value  

PPO(int fast, int slow, int smooth)\[int barsAgo]  

PPO(ISeries\<double\> input, int fast, int slow, int smooth)\[int barsAgo]


 


Returns smoothed value  

PPO(int fast, int slow, int smooth).Smoothed\[int barsAgo]  

PPO(ISeries\<double\> input, int fast, int slow, int smooth).Smoothed\[int barsAgo]


 


 


## Return Value


double; Accessing this method via an index value \[int barsAgo] returns the indicator value of the referenced bar.


 


 


## Parameters




| fast | The number of bars to calculate the fast EMA |
| --- | --- |
| input | Indicator source data ([?](valid_input_data_for_indicator.md)) |
| slow | The number of bars to calculate the slow EMA |
| smooth | The number of bars to calculate the EMA signal line |



 


## 


## Example




| ns |
| --- |
| // Prints the current value of a 20 period Percentage Price Oscillator double value \= PPO(12, 26, 9)\[0]; Print("The current Percentage Price Oscillator value is " \+ value.ToString()); |



 


 


## Source Code


You can view this indicator method source code by selecting the menu New \> NinjaScript Editor \> Indicators within the NinjaTrader Control Center window.








