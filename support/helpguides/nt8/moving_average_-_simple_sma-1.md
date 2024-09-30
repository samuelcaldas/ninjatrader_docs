
NinjaScript \> Language Reference \> Common \> System Indicator Methods \> Moving Average \- Simple (SMA)

Moving Average \- Simple (SMA)

| \<\< [Click to Display Table of Contents](moving_average_-_simple_sma.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [System Indicator Methods](indicators-1.md) \> Moving Average \- Simple (SMA) | [Previous page](moving_average_-_mesa_adaptive-1.md) [Return to chapter overview](indicators-1.md) [Next page](moving_average_-_t3_t3-1.md) |
| --- | --- |
## Description
The Simple Moving Average is calculated by summing the closing prices of the security for a period of time and then dividing this total by the number of time periods. Sometimes called an arithmetic moving average, the SMA is basically the average stock price over time.

## Syntax
SMA(int period)  

SMA(ISeries\<double\> input, int period)
 
Returns default value  

SMA(int period)\[int barsAgo]  

SMA(ISeries\<double\> input, int period)\[int barsAgo]

## Return Value
double; Accessing this method via an index value \[int barsAgo] returns the indicator value of the referenced bar.

## Parameters

| input | Indicator source data ([?](valid_input_data_for_indicator-1.md)) |
| --- | --- |
| period | Number of bars used in the calculation |

## Examples

| ns |
| --- |
| // Prints the current value of a 20 period SMA using default price type double value \= SMA(20)\[0]; Print("The current SMA value is " \+ value.ToString());   // Prints the current value of a 20 period SMA using high price type double value \= SMA(High, 20)\[0]; Print("The current SMA value is " \+ value.ToString()); |

## Source Code
You can view this indicator method source code by selecting the menu New \> NinjaScript Editor \> Indicators within the NinjaTrader Control Center window.
