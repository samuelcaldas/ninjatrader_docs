
NinjaScript \> Language Reference \> Common \> System Indicator Methods \> Directional Movement (DM)

Directional Movement (DM)
| \<\< [Click to Display Table of Contents](directional_movement_dm.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [System Indicator Methods](indicators-1.md) \> Directional Movement (DM) | [Previous page](darvas-1.md) [Return to chapter overview](indicators-1.md) [Next page](directional_movement_index_dmi-1.md) |
| --- | --- |
## Description
Same as the [ADX](average_directional_index_adx-1.md) indicator with the addition of the \+DI and \-DI values. 
 
... Courtesy of [Investopedia](http://www.investopedia.com/terms/d/dmi.asp)
 
## Syntax
DM(int period)  

DM(ISeries\<double\> input, int period)
 
Returns default ADX value  

DM(int period)\[int barsAgo]  

DM(ISeries\<double\> input, int period)\[int barsAgo]
 
Returns \+DI value  

DM(int period).DiPlus\[int barsAgo]  

DM(ISeries\<double\> input, int period).DiPlus\[int barsAgo]
 
Returns \-DI value  

DM(int period).DiMinus\[int barsAgo]  

DM(ISeries\<double\> input, int period).DiMinus\[int barsAgo]

## Return Value
double; Accessing this method via an index value \[int barsAgo] returns the indicator value of the referenced bar.

## Parameters
| input | Indicator source data ([?](valid_input_data_for_indicator-1.md)) |
| --- | --- |
| period | Number of bars used in the calculation |

## Example
| ns |
| --- |
| // Prints the current value of a 20 period \+DI using default price type double value \= DM(20).DiPlus\[0]; Print("The current \+DI value is " \+ value.ToString()); |

## Source Code
You can view this indicator method source code by selecting the menu New \> NinjaScript Editor \> Indicators within the NinjaTrader Control Center window.
