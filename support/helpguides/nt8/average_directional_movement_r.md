
NinjaScript > Language Reference > Common > System Indicator Methods > Average Directional Movement Rating (ADXR)

Average Directional Movement Rating (ADXR)

| << [Click to Display Table of Contents](average_directional_movement_r.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > [System Indicator Methods](indicators.md) > Average Directional Movement Rating (ADXR) | [Previous page](average_directional_index_adx.md) [Return to chapter overview](indicators.md) [Next page](average_true_range_atr.md) |
| --- | --- |
## Description
The ADXR is equal to the current [ADX](average_directional_index_adx.md) plus the ADX from n bars ago divided by two. 

## Syntax
ADXR(int interval, int period)  

ADXR(ISeries<double> input, int interval, int period)
 
Returns default value  

ADXR(int interval, int period)[int barsAgo]  

ADXR(ISeries<double> input, int interval, int period)[int barsAgo]

## Return Value
double; Accessing this method via an index value [int barsAgo] returns the indicator value of the referenced bar.

## Parameters

| input | Indicator source data ([?](valid_input_data_for_indicator.md)) |
| --- | --- |
| interval | The interval between the first ADX value and the current ADX value |
| period | Number of bars used in the calculation |
 
## 
## Example

| ns |
| --- |
| // Prints the current value of a 20 period ADXR using default price type double value = ADXR(10, 20)[0]; Print("The current ADXR value is " + value.ToString()); |

## Source Code
You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.
