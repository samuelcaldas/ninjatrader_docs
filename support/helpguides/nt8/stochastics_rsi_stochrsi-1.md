
NinjaScript \> Language Reference \> Common \> System Indicator Methods \> Stochastics RSI (StochRSI)

Stochastics RSI (StochRSI)

| \<\< [Click to Display Table of Contents](stochastics_rsi_stochrsi.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [System Indicator Methods](indicators-1.md) \> Stochastics RSI (StochRSI) | [Previous page](stochastics_fast-1.md) [Return to chapter overview](indicators-1.md) [Next page](summation_sum-1.md) |
| --- | --- |
## Description
This is an indicator on indicator implementation. It is simply a [Stochastics](stochastics-1.md) indicator applied on [RSI](relative_strength_index_rsi-1.md).

## Syntax
StochRSI(int period)  

StochRSI(ISeries\<double\> input, int period)
 
Returns default value  

StochRSI(int period)\[int barsAgo]  

StochRSI(ISeries\<double\> input, int period)\[int barsAgo]

## Return Value
double; Accessing this method via an index value \[int barsAgo] returns the indicator value of the referenced bar.

## Parameters

| input | Indicator source data ([?](valid_input_data_for_indicator-1.md)) |
| --- | --- |
| period | Number of bars used in the calculation |

## Example

| ns |
| --- |
| // Evaluates if the current bar StochRSI value is greater than the value one bar ago if (StochRSI(14)\[0] \> StochRSI(14)\[1])    Print("Stochastics RSI is rising"); |

## Source Code
You can view this indicator method source code by selecting the menu New \> NinjaScript Editor \> Indicators within the NinjaTrader Control Center window.
