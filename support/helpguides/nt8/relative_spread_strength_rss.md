
NinjaScript \> Language Reference \> Common \> System Indicator Methods \> Relative Spread Strength (RSS)

Relative Spread Strength (RSS)

| \<\< [Click to Display Table of Contents](relative_spread_strength_rss.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [System Indicator Methods](indicators.md) \> Relative Spread Strength (RSS) | [Previous page](regression_channel.md) [Return to chapter overview](indicators.md) [Next page](relative_strength_index_rsi.md) |
| --- | --- |
## Description
Developed by Ian Copsey, Relative Spread Strength is a variation to the [Relative Strength Index](relative_strength_index_rsi.md). 

## Syntax
RSS(int eMA1, int eMA2, int length)
RSS(ISeries\<double\> input, int eMA1, int eMA2, int length)
 
Returns default value
RSS(int eMA1, int eMA2, int length)\[int barsAgo]
RSS(ISeries\<double\> input, int eMA1, int eMA2, int length)\[int barsAgo]

## Return Value
double; Accessing this method via an index value \[int barsAgo] returns the indicator value of the referenced bar.

## Parameters

| eMA1 | First EMA's period |
| --- | --- |
| eMA2 | Second EMA's period |
| input | Indicator source data ([?](valid_input_data_for_indicator.md)) |
| length | Number of bars used in the calculation |
 
## 
## Examples

| ns |
| --- |
| // Prints the current value of the RSS using default price type double value \= RSS(10, 40, 5)\[0]; Print("The current RSS value is " \+ value.ToString());   // Prints the current value of the RSS using high price type double value \= RSS(High, 10, 40, 5)\[0]; Print("The current RSS value is " \+ value.ToString()); |

## Source Code
You can view this indicator method source code by selecting the menu New \> NinjaScript Editor \> Indicators within the NinjaTrader Control Center window.
