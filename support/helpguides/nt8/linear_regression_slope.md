


NinjaScript \> Language Reference \> Common \> System Indicator Methods \> Linear Regression Slope






















Linear Regression Slope







| \<\< [Click to Display Table of Contents](linear_regression_slope.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [System Indicator Methods](indicators.md) \> Linear Regression Slope | [Previous page](linear_regression_intercept.md) [Return to chapter overview](indicators.md) [Next page](maenvelopes.md) |
| --- | --- |











## Description


The Linear Regression Slope provides the slope value of the [Linear Regression](linear_regression.md) trendline.


 


 


## Syntax


LinRegSlope(int period)  

LinRegSlope(ISeries\<double\> input, int period)


 


Returns default value  

LinRegSlope(int period)\[int barsAgo]  

LinRegSlope(ISeries\<double\> input, int period)\[int barsAgo]


 


 


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
| // Prints the current slope value of a 20 period LinReg using default price type double value \= LinRegSlope(20)\[0]; Print("The current slope value is " \+ value.ToString());   // Prints the current slope value of a 20 period LinReg using high price type double value \= LinRegSlope(High, 20)\[0]; Print("The current slope value is " \+ value.ToString()); |



 


 


## Source Code


You can view this indicator method source code by selecting the menu New \> NinjaScript Editor \> Indicators within the NinjaTrader Control Center window.








