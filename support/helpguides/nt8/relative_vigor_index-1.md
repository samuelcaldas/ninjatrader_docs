


NinjaScript \> Language Reference \> Common \> System Indicator Methods \> Relative Vigor Index






















Relative Vigor Index







| \<\< [Click to Display Table of Contents](relative_vigor_index.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [System Indicator Methods](indicators-1.md) \> Relative Vigor Index | [Previous page](relative_strength_index_rsi-1.md) [Return to chapter overview](indicators-1.md) [Next page](relative_volatility_index_rvi-1.md) |
| --- | --- |











## Description


The Relative Vigor Index measures the strength of a trend by comparing an instruments closing price to its price range. It's based on the fact that prices tend to close higher than they open in up trends, and closer lower than they open in downtrends.


 


## Syntax


RelativeVigorIndex(int period)


RelativeVigorIndex(ISeries\<double\> input, int period)


 


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
| // Prints the current value of a 10 period Relative Vigor Index double value \= RelativeVigorIndex(10)\[0]; Print("The current Relative Vigor Index value is " \+ value.ToString()); |









