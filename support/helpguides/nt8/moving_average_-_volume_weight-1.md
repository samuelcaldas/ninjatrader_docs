
NinjaScript \> Language Reference \> Common \> System Indicator Methods \> Moving Average \- Volume Weighted (VWMA)

Moving Average \- Volume Weighted (VWMA)

| \<\< [Click to Display Table of Contents](moving_average_-_volume_weight.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [System Indicator Methods](indicators-1.md) \> Moving Average \- Volume Weighted (VWMA) | [Previous page](moving_average_-_variable_vma-1.md) [Return to chapter overview](indicators-1.md) [Next page](moving_average_-_weighted_wma-1.md) |
| --- | --- |
## Description
The Volume Weighted Moving Average is a weighted moving average that uses the volume as the weighting factor, so that higher volume days have more weight. It is a non\-cumulative moving average, in that only data within the time period is used in the calculation. 

## Syntax
VWMA(int period)  

VWMA(ISeries\<double\> input, int period)
 
Returns default value  

VWMA(int period)\[int barsAgo]  

VWMA(ISeries\<double\> input, int period)\[int barsAgo]

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
| // OnBarUpdate method protected override void OnBarUpdate() {    // Evaluates for a VWMA cross over to the long side    if (CrossAbove(VWMA(14), VWMA(40), 1))        Print("We have a moving average cross over long");      // Prints the current 14 period VWMA of high prices to the output window    double value \= VWMA(High, 14)\[0];    Print("The current VWMA value of high prices is " \+ value.ToString()); } |

## Source Code
You can view this indicator method source code by selecting the menu New \> NinjaScript Editor \> Indicators within the NinjaTrader Control Center window.
