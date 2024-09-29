


NinjaScript \> Language Reference \> Common \> System Indicator Methods \> n Bars Down






















n Bars Down







| \<\< [Click to Display Table of Contents](n_bars_down.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [System Indicator Methods](indicators-1.md) \> n Bars Down | [Previous page](net_change_display-1.md) [Return to chapter overview](indicators-1.md) [Next page](n_bars_up-1.md) |
| --- | --- |











## Description


Evaluates for n number of consecutive lower closes. Returns a value of 1 when the condition is true or 0 when false.


 


 


## Syntax


NBarsDown(int barCount, bool barDown, bool lowerHigh, bool lowerLow)  

NBarsDown(ISeries\<double\> input, int barCount, bool barDown, bool lowerHigh, bool lowerLow)


 


Returns default value  

NBarsDown(int barCount, bool barDown, bool lowerHigh, bool lowerLow)\[int barsAgo]  

NBarsDown(ISeries\<double\> input, bool barCount, int barDown, bool lowerHigh, bool lowerLow)\[int barsAgo]


 


 


## Return Value


double; Accessing this method via an index value \[int barsAgo] returns the indicator value of the referenced bar.


 


 


## Parameters




| input | Indicator source data ([?](valid_input_data_for_indicator-1.md)) |
| --- | --- |
| barCount | The number of required consecutive lower closes |
| barDown | Each bar's open must be less than the close; true or false |
| lowerHigh | Consecutive lower highs required; true or false |
| lowerLow | Consecutive lower lows required; true or false |



 


 


## Example




| ns |
| --- |
| // OnBarUpdate method protected override void OnBarUpdate() {    // Evaluates if we have 3 consecutive lower closes    double value \= NBarsDown(3, true, true, true)\[0];      if (value \=\= 1)        Print("We have three consecutive lower closes"); } |



 


 


## Source Code


You can view this indicator method source code by selecting the menu New \> NinjaScript Editor \> Indicators within the NinjaTrader Control Center window.








