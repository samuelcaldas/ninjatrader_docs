
NinjaScript \> Language Reference \> Common \> System Indicator Methods \> Relative Strength Index (RSI)

Relative Strength Index (RSI)

| \<\< [Click to Display Table of Contents](relative_strength_index_rsi.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [System Indicator Methods](indicators-1.md) \> Relative Strength Index (RSI) | [Previous page](relative_spread_strength_rss-1.md) [Return to chapter overview](indicators-1.md) [Next page](relative_vigor_index-1.md) |
| --- | --- |
## Description
Developed by J. Welles Wilder and introduced in his 1978 book, New Concepts in Technical Trading Systems, the Relative Strength Index (RSI) is an extremely useful and popular momentum oscillator. The RSI compares the magnitude of a stock's recent gains to the magnitude of its recent losses and turns that information into a number that ranges from 0 to 100\.  
 
... Courtesy of [StockCharts](http://stockcharts.com/education/IndicatorAnalysis/indic_RSI.md)
 
The original Wilder formula for an exponential moving average with a smoothing constant (k \= 1/ Period) is used to calculate the RSI.
 
## Syntax
RSI(int period, int smooth)  

RSI(ISeries\<double\> input, int period, int smooth)
 
Returns default value  

RSI(int period, int smooth)\[int barsAgo]  

RSI(ISeries\<double\> input, int period, int smooth)\[int barsAgo]
 
Returns avg value  

RSI(int period, int smooth).Avg\[int barsAgo]  

RSI(ISeries\<double\> input, int period, int smooth).Avg\[int barsAgo]

## Return Value
double; Accessing this method via an index value \[int barsAgo] returns the indicator value of the referenced bar.

## Parameters

| input | Indicator source data ([?](valid_input_data_for_indicator-1.md)) |
| --- | --- |
| period | Number of bars used in the calculation |
| smooth | Smoothing period |
 
## 
## Examples

| ns |
| --- |
| // Prints the current value of a 20 period RSI using default price type double value \= RSI(20, 3)\[0]; Print("The current RSI value is " \+ value.ToString());   // Prints the current value of a 20 period RSI using high price type double value \= RSI(High, 20, 3)\[0]; Print("The current RSI value is " \+ value.ToString()); |

## Source Code
You can view this indicator method source code by selecting the menu New \> NinjaScript Editor \> Indicators within the NinjaTrader Control Center window.
