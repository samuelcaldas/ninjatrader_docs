
NinjaScript \> Language Reference \> Common \> System Indicator Methods \> Moving Average \- Triple Exponential (TEMA)

Moving Average \- Triple Exponential (TEMA)

| \<\< [Click to Display Table of Contents](moving_average_-_triple_expone.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [System Indicator Methods](indicators.md) \> Moving Average \- Triple Exponential (TEMA) | [Previous page](moving_average_-_triangular_tm.md) [Return to chapter overview](indicators.md) [Next page](moving_average_-_triple_expon2.md) |
| --- | --- |
## Description
The TEMA is a smoothing indicator. It was developed by Patrick Mulloy and is described in his article in the January, 1994 issue of Technical Analysis of Stocks and Commodities magazine. 

## Syntax
TEMA(int period)  

TEMA(ISeries\<double\> input, int period)
 
Returns default value  

TEMA(int period)\[int barsAgo]  

TEMA(ISeries\<double\> input, int period)\[int barsAgo]

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
| // Prints the current value of a 20 period TEMA using default price type double value \= TEMA(20)\[0]; Print("The current TEMA value is " \+ value.ToString());   // Prints the current value of a 20 period TEMA using high price type double value \= TEMA(High, 20)\[0]; Print("The current TEMA value is " \+ value.ToString()); |
 
## 
## Source Code
You can view this indicator method source code by selecting the menu New \> NinjaScript Editor \> Indicators within the NinjaTrader Control Center window.
