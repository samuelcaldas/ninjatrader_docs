
NinjaScript > Language Reference > Common > System Indicator Methods > Disparity Index
Disparity Index
| << [Click to Display Table of Contents](disparity_index.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > [System Indicator Methods](indicators.md) > Disparity Index | [Previous page](directional_movement_index_dmi.md) [Return to chapter overview](indicators.md) [Next page](donchian_channel.md) |
| --- | --- |
## Description
The Disparity Index that measures the difference between the price and an exponential moving average. A value greater could suggest bullish momentum, while a value less than zero could suggest bearish momentum.
 
## Syntax
DisparityIndex(int period)
DisparityIndex(ISeries<double> input, int period)
 
## Return Value
double; Accessing this method via an index value [int barsAgo] returns the indicator value of the referenced bar.
 
## Parameters
| input | Indicator source data ([?](valid_input_data_for_indicator.md)) |
| --- | --- |
| period | Number of bars used in the calculation |
 
## 
## Examples
| ns |
| --- |
| // Prints the current value of a 15 period Disparity Index double value = DisparityIndex(15)[0]; Print("The current Disparity Index value is " + value.ToString()); |

