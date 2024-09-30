
NinjaScript \> Language Reference \> Common \> System Indicator Methods \> Moving Average \- Hull (HMA)

Moving Average \- Hull (HMA)

| \<\< [Click to Display Table of Contents](moving_average_-_hull_hma.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [System Indicator Methods](indicators.md) \> Moving Average \- Hull (HMA) | [Previous page](moving_average_-_exponential_e.md) [Return to chapter overview](indicators.md) [Next page](moving_average_-_kaufmans_adap.md) |
| --- | --- |
## Description
The HMA manages to keep up with rapid changes in price activity whilst having superior smoothing over an SMA of the same period. The HMA employs weighted moving averages and dampens the smoothing effect (and resulting lag) by using the square root of the period instead of the actual period itself. Developed by Alan Hull. 

## Syntax
HMA(int period)  

HMA(ISeries\<double\> input, int period)
 
Returns default value  

HMA(int period)\[int barsAgo]  

HMA(ISeries\<double\> input, int period)\[int barsAgo]

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
| // Prints the current value of a 20 period HMA using default price type double value \= HMA(20)\[0]; Print("The current HMA value is " \+ value.ToString());   // Prints the current value of a 20 period HMA using high price type double value \= HMA(High, 20)\[0]; Print("The current HMA value is " \+ value.ToString()); |

## Source Code
You can view this indicator method source code by selecting the menu New \> NinjaScript Editor \> Indicators within the NinjaTrader Control Center window.
