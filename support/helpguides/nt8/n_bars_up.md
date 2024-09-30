
NinjaScript \> Language Reference \> Common \> System Indicator Methods \> n Bars Up
n Bars Up
| \<\< [Click to Display Table of Contents](n_bars_up.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [System Indicator Methods](indicators.md) \> n Bars Up | [Previous page](n_bars_down.md) [Return to chapter overview](indicators.md) [Next page](on_balance_volume_obv.md) |
| --- | --- |
## Description
Evaluates for n number of consecutive higher closes. Returns a value of 1 when the condition is true or 0 when false. 

## Syntax
NBarsUp(int barCount, bool barUp, bool higherHigh, bool higherLow)  

NBarsUp(ISeries\<double\> input, int barCount, bool barUp, bool higherHigh, bool higherLow)
 
Returns default value  

NBarsUp(int barCount, bool barUp, bool higherHigh, bool higherLow)\[int barsAgo]  

NBarsUp(ISeries\<double\> input, int barCount, bool barUp, bool higherHigh, bool higherLow)\[int barsAgo]

## Return Value
double; Accessing this method via an index value \[int barsAgo] returns the indicator value of the referenced bar.

## Parameters
| input | Indicator source data ([?](valid_input_data_for_indicator.md)) |
| --- | --- |
| barCount | The number of required consecutive higher closes |
| barUp | Each bar's close must be higher than the open; true or false |
| higherHigh | Consecutive higher highs required; true or false |
| higherLow | Consecutive higher lows required; true or false |

## Example
| ns |
| --- |
| // OnBarUpdate method protected override void OnBarUpdate() {    // Evaluates if we have 3 consecutive higher closes    double value \= NBarsUp(3, true, true, true)\[0];      if (value \=\= 1)        Print("We have three consecutive higher closes"); } |

## Source Code
You can view this indicator method source code by selecting the menu New \> NinjaScript Editor \> Indicators within the NinjaTrader Control Center window.
