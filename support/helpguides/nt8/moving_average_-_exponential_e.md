
NinjaScript \> Language Reference \> Common \> System Indicator Methods \> Moving Average \- Exponential (EMA)

Moving Average \- Exponential (EMA)

| \<\< [Click to Display Table of Contents](moving_average_-_exponential_e.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [System Indicator Methods](indicators.md) \> Moving Average \- Exponential (EMA) | [Previous page](moving_average_-_double_expone.md) [Return to chapter overview](indicators.md) [Next page](moving_average_-_hull_hma.md) |
| --- | --- |
## Description
The exponential moving average is but one type of a moving average. In a simple moving average, all price data has an equal weight in the computation of the average with the oldest value removed as each new value is added. In the exponential moving average equation the most recent market action is assigned greater importance as the average is calculated. The oldest pricing data in the exponential moving average is however never removed.

## Syntax
EMA(int period)  

EMA(ISeries\<double\> input, int period)
 
Returns default value  

EMA(int period)\[int barsAgo]  

EMA(ISeries\<double\> input, int period)\[int barsAgo]

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
| // Prints the current value of a 20 period EMA using default price type double value \= EMA(20)\[0]; Print("The current EMA value is " \+ value.ToString());   // Prints the current value of a 20 period EMA using high price type double value \= EMA(High, 20)\[0]; Print("The current EMA value is " \+ value.ToString()); |

## Source Code
You can view this indicator method source code by selecting the menu New \> NinjaScript Editor \> Indicators within the NinjaTrader Control Center window.
