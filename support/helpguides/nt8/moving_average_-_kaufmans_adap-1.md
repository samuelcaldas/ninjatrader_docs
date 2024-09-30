
NinjaScript > Language Reference > Common > System Indicator Methods > Moving Average - Kaufman's Adaptive (KAMA)

Moving Average - Kaufman's Adaptive (KAMA)

| << [Click to Display Table of Contents](moving_average_-_kaufmans_adap.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [System Indicator Methods](indicators-1.md) > Moving Average - Kaufman's Adaptive (KAMA) | [Previous page](moving_average_-_hull_hma-1.md) [Return to chapter overview](indicators-1.md) [Next page](moving_average_-_mesa_adaptive-1.md) |
| --- | --- |
## Description
Developed by Perry Kaufman, this indicator is an EMA using an Efficiency Ratio to modify the smoothing constant, which ranges from a minimum of Fast Length to a maximum of Slow Length. 

## Syntax
KAMA(int fast, int period, int slow)  

KAMA(ISeries<double> input, int fast, int period, int slow)
 
Returns default value  

KAMA(int fast, int period, int slow)[int barsAgo]  

KAMA(ISeries<double> input, int fast, int period, int slow)[int barsAgo]

## Return Value
double; Accessing this method via an index value [int barsAgo] returns the indicator value of the referenced bar.

## Parameters

| fast | Fast length |
| --- | --- |
| input | Indicator source data ([?](valid_input_data_for_indicator-1.md)) |
| period | Number of bars used in the calculation |
| slow | Slow length |
 
## 
## Examples

| ns |
| --- |
| // Prints the current value of a 20 period KAMA using default price type double value = KAMA(2, 20, 30)[0]; Print("The current KAMA value is " + value.ToString());   // Prints the current value of a 20 period KAMA using high price type double value = KAMA(High, 2, 20, 30)[0]; Print("The current KAMA value is " + value.ToString()); |

## Source Code
You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.
