


NinjaScript \> Language Reference \> Common \> System Indicator Methods \> Psychological Line






















Psychological Line







| \<\< [Click to Display Table of Contents](psychological_line.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [System Indicator Methods](indicators.md) \> Psychological Line | [Previous page](prior_day_ohlc.md) [Return to chapter overview](indicators.md) [Next page](range.md) |
| --- | --- |











## Description


The Psychological Line is the ratio of the number of rising bars over the specified number of bars.


 


## Syntax


PsychologicalLine(int period)


PsychologicalLine(ISeries\<double\> input, int period)


 


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
| // Prints the current value of a 10 period Psychological Line double value \= PsychologicalLine(10)\[0]; Print("The current Psychological Line value is " \+ value.ToString()); |









