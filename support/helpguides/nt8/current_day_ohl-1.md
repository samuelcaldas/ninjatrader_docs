
NinjaScript \> Language Reference \> Common \> System Indicator Methods \> Current Day OHL
Current Day OHL
| \<\< [Click to Display Table of Contents](current_day_ohl.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [System Indicator Methods](indicators-1.md) \> Current Day OHL | [Previous page](correlation-1.md) [Return to chapter overview](indicators-1.md) [Next page](darvas-1.md) |
| --- | --- |
## Description
The current day (session) open, high and low values.
 
| Note: Only use this indicator on intraday series. |
| --- |
## 
## Syntax
CurrentDayOHL()  

CurrentDayOHL(ISeries\<double\> input)
 
Returns current session open value  

CurrentDayOHL().CurrentOpen\[int barsAgo]  

CurrentDayOHL(ISeries\<double\> input).CurrentOpen\[int barsAgo]
 
Returns current session high value  

CurrentDayOHL().CurrentHigh\[int barsAgo]  

CurrentDayOHL(ISeries\<double\> input).CurrentHigh\[int barsAgo]
 
Returns current session low value  

CurrentDayOHL().CurrentLow\[int barsAgo]  

CurrentDayOHL(ISeries\<double\> input).CurrentLow\[int barsAgo]

## Return Value
double; Accessing this method via an index value \[int barsAgo] returns the indicator value of the referenced bar.

## Parameters
| input | Indicator source data ([?](valid_input_data_for_indicator-1.md)) |
| --- | --- |
 
## 
## Example
| ns |
| --- |
| // Prints the current value of the session low double value \= CurrentDayOHL().CurrentLow\[0]; Print("The current session low value is " \+ value.ToString()); |

## Source Code
You can view this indicator method source code by selecting the menu New \> NinjaScript Editor \> Indicators within the NinjaTrader Control Center window.

