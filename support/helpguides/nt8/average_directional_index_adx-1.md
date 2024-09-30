
NinjaScript > Language Reference > Common > System Indicator Methods > Average Directional Index (ADX)

Average Directional Index (ADX)

| << [Click to Display Table of Contents](average_directional_index_adx.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [System Indicator Methods](indicators-1.md) > Average Directional Index (ADX) | [Previous page](aroon_oscillator-1.md) [Return to chapter overview](indicators-1.md) [Next page](average_directional_movement_r-1.md) |
| --- | --- |
## Description
An indicator used in technical analysis as an objective value for the strength of trend. ADX is non-directional so it will quantify a trend's strength regardless of whether it is up or down. ADX is usually plotted in a chart window along with two lines known as the DMI (Directional Movement Indicators). ADX is derived from the relationship of the DMI lines.
 
... Courtesy of [Investopedia](http://investopedia.com/terms/a/adx.asp)

## Syntax
ADX(int period)  

ADX(ISeries<double> input, int period)
 
Returns default value  

ADX(int period)[int barsAgo]  

ADX(ISeries<double> input, int period)[int barsAgo]

## Return Value
double; Accessing this method via an index value [int barsAgo] returns the indicator value of the referenced bar.

## Parameters

| input | Indicator source data ([?](valid_input_data_for_indicator-1.md)) |
| --- | --- |
| period | Number of bars used in the calculation |
 
## 
## Examples

| ns |
| --- |
| // Prints the current value of a 20 period ADX double value = ADX(20)[0]; Print("The current ADX value is " + value.ToString()); |

## Source Code
You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.
