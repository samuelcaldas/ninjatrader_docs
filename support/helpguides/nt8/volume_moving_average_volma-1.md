


NinjaScript \> Language Reference \> Common \> System Indicator Methods \> Volume Moving Average (VOLMA)






















Volume Moving Average (VOLMA)







| \<\< [Click to Display Table of Contents](volume_moving_average_volma.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [System Indicator Methods](indicators-1.md) \> Volume Moving Average (VOLMA) | [Previous page](volume-1.md) [Return to chapter overview](indicators-1.md) [Next page](volume_oscillator-1.md) |
| --- | --- |











## Description


The Volume Moving Average indicator is an indicator on indicator implementation. It calculates and returns the value of an [exponential moving average](moving_average_-_exponential_e-1.md) of [volume](volume-1.md).


 


 


## Syntax


VOLMA(int period)  

VOLMA(ISeries\<double\> input, int period)


 


Returns default value  

VOLMA(int period)\[int barsAgo]  

VOLMA(ISeries\<double\> input, int period)\[int barsAgo]


 


 


## Return Value


double; Accessing this method via an index value \[int barsAgo] returns the indicator value of the referenced bar.


 


 


## Parameters




| input | Indicator source data ([?](valid_input_data_for_indicator-1.md)) |
| --- | --- |
| period | Number of bars used in the calculation |



 


## 


## Example




| ns |
| --- |
| // Evaluates if the current volume is greater than the 20 period EMA of volume if (Volume\[0] \> VOLMA(20)\[0])    Print("Volume has risen above its 20 period average"); |



 


 


## Source Code


You can view this indicator method source code by selecting the menu New \> NinjaScript Editor \> Indicators within the NinjaTrader Control Center window.








