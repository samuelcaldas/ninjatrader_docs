
NinjaScript \> Language Reference \> Common \> System Indicator Methods \> Disparity Index
Disparity Index
| \<\< [Click to Display Table of Contents](disparity_index.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [System Indicator Methods](indicators-1.md) \> Disparity Index | [Previous page](directional_movement_index_dmi-1.md) [Return to chapter overview](indicators-1.md) [Next page](donchian_channel-1.md) |
| --- | --- |
## Description
The Disparity Index that measures the difference between the price and an exponential moving average. A value greater could suggest bullish momentum, while a value less than zero could suggest bearish momentum.
 
## Syntax
DisparityIndex(int period)
DisparityIndex(ISeries\<double\> input, int period)
 
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
| // Prints the current value of a 15 period Disparity Index double value \= DisparityIndex(15)\[0]; Print("The current Disparity Index value is " \+ value.ToString()); |

