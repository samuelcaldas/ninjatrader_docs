
NinjaScript \> Language Reference \> Common \> System Indicator Methods \> Minimum (MIN)

Minimum (MIN)

| \<\< [Click to Display Table of Contents](minimum_min.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [System Indicator Methods](indicators.md) \> Minimum (MIN) | [Previous page](mcclellan_oscillator.md) [Return to chapter overview](indicators.md) [Next page](momentum.md) |
| --- | --- |
## Description
Returns the lowest value over the specified period.

## Syntax
MIN(int period)  

MIN(ISeries\<double\> input, int period)
 
Returns default value  

MIN(int period)\[int barsAgo]  

MIN(ISeries\<double\> input, int period)\[int barsAgo]

## Return Value
double; Accessing this method via an index value \[int barsAgo] returns the indicator value of the referenced bar.

## Parameters

| input | Indicator source data ([?](valid_input_data_for_indicator.md)) |
| --- | --- |
| period | Number of bars used in the calculation |
 
## 
## Example

| ns |
| --- |
| // Prints the lowest low value over the last 20 periods double value \= MIN(Low, 20)\[0]; Print("The current MIN value is " \+ value.ToString());   // Note the above call with a barsAgo of 0 includes the current MIN of the input low series in the value. If we want to check for example for a break of this value, storing the last bar's MIN would be needed. double value \= MIN(Low, 20)\[1];           if (Low\[0] \< value)    Draw.ArrowDown(this, CurrentBar.ToString(), true, 0, High\[0] \+ TickSize, Brushes.Red); |

## Source Code
You can view this indicator method source code by selecting the menu New \> NinjaScript Editor \> Indicators within the NinjaTrader Control Center window.
