
NinjaScript > Language Reference > Common > System Indicator Methods > Balance of Power (BOP)
Balance of Power (BOP)
| << [Click to Display Table of Contents](balance_of_power_bop.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > [System Indicator Methods](indicators.md) > Balance of Power (BOP) | [Previous page](average_true_range_atr.md) [Return to chapter overview](indicators.md) [Next page](block_volume.md) |
| --- | --- |
## Description
The balance of power (BOP) indicator measures the strength of the bulls vs. bears by assessing the ability of each to push price to an extreme level. 

## Syntax
BOP(int smooth)  

BOP(ISeries<double> input, int smooth)
 
Returns default value  

BOP(int smooth)[int barsAgo]  

BOP(ISeries<double> input, int smooth)[int barsAgo]

## Return Value
double; Accessing this method via an index value [int barsAgo] returns the indicator value of the referenced bar.

## Parameters
| input | Indicator source data ([?](valid_input_data_for_indicator.md)) |
| --- | --- |
| smooth | The smoothing period |
## 
## 
## Example
| ns |
| --- |
| // Prints the current value of BOP using default price type and 3 period smoothing double value = BOP(3)[0]; Print("The current BOP value is " + value.ToString()); |

## Source Code
You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

