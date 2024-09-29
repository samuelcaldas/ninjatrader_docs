


NinjaScript \> Language Reference \> Common \> System Indicator Methods \> Standard Error (StdError)






















Standard Error (StdError)







| \<\< [Click to Display Table of Contents](standard_error_stderror.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [System Indicator Methods](indicators.md) \> Standard Error (StdError) | [Previous page](standard_deviation_stddev.md) [Return to chapter overview](indicators.md) [Next page](stochastics.md) |
| --- | --- |











## Description


The standard error of a method of measurement or estimation is the standard deviation of the sampling distribution associated with the estimation method. The term may also be used to refer to an estimate of that standard deviation, derived from a particular sample used to compute the estimate.


 


... Courtesy of [Wikipedia](http://en.wikipedia.org/wiki/Standard_error_(statistics))


 


 


## Syntax


StdError(int period)  

StdError(ISeries\<double\> input, int period)


 


Returns default value which is the mid line (also known as linear regression)  

StdError(int period)\[int barsAgo]  

StdError(ISeries\<double\> input, int period)\[int barsAgo]


 


Returns upper value  

StdError(int period).Upper\[int barsAgo]  

StdError(ISeries\<double\> input, int period).Upper\[int barsAgo]


 


Returns lower value  

StdError(int period).Lower\[int barsAgo]  

StdError(ISeries\<double\> input, int period).Lower\[int barsAgo]


 


 


## Return Value


double; Accessing this method via an index value \[int barsAgo] returns the indicator value of the referenced bar.


 


 


## Parameters




| input | Indicator source data ([?](valid_input_data_for_indicator.md)) |
| --- | --- |
| period | Number of bars used in the calculation |



 


## 


## Examples




| ns |
| --- |
| // Prints the current upper value of a 20 period StdError using default price type double value \= StdError(20).Upper\[0]; Print("The current upper Standard Error value is " \+ value.ToString()); |



 


 


## Source Code


You can view this indicator method source code by selecting the menu New \> NinjaScript Editor \> Indicators within the NinjaTrader Control Center window.








