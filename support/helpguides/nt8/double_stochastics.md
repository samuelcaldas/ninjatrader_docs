
NinjaScript \> Language Reference \> Common \> System Indicator Methods \> Double Stochastics

Double Stochastics
| \<\< [Click to Display Table of Contents](double_stochastics.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [System Indicator Methods](indicators.md) \> Double Stochastics | [Previous page](donchian_channel.md) [Return to chapter overview](indicators.md) [Next page](dynamic_momentum_index_dmindex.md) |
| --- | --- |
## Description
Double Stochastics is a variation of the [Stochastics](stochastics.md) indicator developed by William Blau.

## Syntax
DoubleStochastics(int period)  

DoubleStochastics(ISeries\<double\> input, int period)
 
Returns default value  

DoubleStochastics(int period)\[int barsAgo]  

DoubleStochastics(ISeries\<double\> input, int period)\[int barsAgo]
 
Returns %K value  

DoubleStochastics(int period).K\[int barsAgo]  

DoubleStochastics(ISeries\<double\> input, int period).K\[int barsAgo]

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
| // Prints the current value double value \= DoubleStochastics(10)\[0]; Print("The current Double Stochastics value is " \+ value.ToString());   // Prints the current %K value double value \= DoubleStochastics(10).K\[0]; Print("The current Double Stochastics %K value is " \+ value.ToString()); |

 
## Source Code
You can view this indicator method source code by selecting the menu New \> NinjaScript Editor \> Indicators within the NinjaTrader Control Center window.
