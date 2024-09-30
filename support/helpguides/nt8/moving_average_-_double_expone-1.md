
NinjaScript \> Language Reference \> Common \> System Indicator Methods \> Moving Average \- Double Exponential (DEMA)

Moving Average \- Double Exponential (DEMA)

| \<\< [Click to Display Table of Contents](moving_average_-_double_expone.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [System Indicator Methods](indicators-1.md) \> Moving Average \- Double Exponential (DEMA) | [Previous page](money_flow_oscillator-1.md) [Return to chapter overview](indicators-1.md) [Next page](moving_average_-_exponential_e-1.md) |
| --- | --- |
## Description
The Double Exponential Moving Average (DEMA) is a combination of a single exponential moving average and a double exponential moving average. The advantage is that gives a reduced amount of lag time than either of the two separate moving averages alone.

## Syntax
DEMA(int period)  

DEMA(ISeries\<double\> input, int period)
 
Returns default value  

DEMA(int period)\[int barsAgo]  

DEMA(ISeries\<double\> input, int period)\[int barsAgo]

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
| // Prints the current value of a 20 period DEMA using default price type double value \= DEMA(20)\[0]; Print("The current DEMA value is " \+ value.ToString());   // Prints the current value of a 20 period DEMA using high price type double value \= DEMA(High, 20)\[0]; Print("The current DEMA value is " \+ value.ToString()); |

## Source Code
You can view this indicator method source code by selecting the menu New \> NinjaScript Editor \> Indicators within the NinjaTrader Control Center window.
