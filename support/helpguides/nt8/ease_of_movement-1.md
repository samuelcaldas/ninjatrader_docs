
NinjaScript > Language Reference > Common > System Indicator Methods > Ease of Movement
Ease of Movement
| << [Click to Display Table of Contents](ease_of_movement.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [System Indicator Methods](indicators-1.md) > Ease of Movement | [Previous page](dynamic_momentum_index_dmindex-1.md) [Return to chapter overview](indicators-1.md) [Next page](fibonacci_pivots-1.md) |
| --- | --- |
## Description
The Ease of Movement indicator was designed to illustrate the relationship between volume and price change. It shows how much volume is required to move prices.
 
High Ease of Movement values occur when prices are moving upward with light volume. Low values occur when prices are moving downward on light volume. If prices are not moving or if heavy volume is required to move prices then the indicator will read near zero. A buy signal is produced when it crosses above zero. A sell signal is produced when the indicator crosses below zero (prices are moving downward more easily).

## Syntax
EaseOfMovement(int smoothing, int volumeDivisor)  

EaseOfMovement(ISeries<double> input, int smoothing, int volumeDivisor)
 
Returns default value  

EaseOfMovement(int smoothing, int volumeDivisor)[int barsAgo]  

EaseOfMovement(ISeries<double> input, int smoothing, int volumeDivisor)[int barsAgo]

## Return Value
double; Accessing this method via an index value [int barsAgo] returns the indicator value of the referenced bar.

## Parameters
| input | Indicator source data ([?](valid_input_data_for_indicator-1.md)) |
| --- | --- |
| smoothing | The number of bars used to smooth the signal |
| volumeDivisor | The value used to calculate the box ratio |
 
## 
## Example
| ns |
| --- |
| // Prints the current value of Ease of Movement using default price type double value = EaseOfMovement(14, 10000)[0]; Print("The current Ease of Movement value is " + value.ToString()); |

## Source Code
You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

