
NinjaScript > Language Reference > Common > System Indicator Methods > Ultimate Oscillator
Ultimate Oscillator
| << [Click to Display Table of Contents](ultimate_oscillator.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > [System Indicator Methods](indicators.md) > Ultimate Oscillator | [Previous page](true_strength_index_tsi.md) [Return to chapter overview](indicators.md) [Next page](volume.md) |
| --- | --- |
## Description
Developed by Larry Williams and introduced in his article in the April, 1985 issue of Technical Analysis of Stocks and Commodities magazine, this indicator is the weighted sum of three oscillators of different time periods. The there time periods represent short, intermediate and long term market cycles. Typical periods are 7, 14 and 28. The values of the Ultimate Oscillator range from zero to 100. Values over 70 indicate overbought conditions, and values under 30 indicate oversold conditions. 

## Syntax
UltimateOscillator(int fast, int intermediate, int slow)  

UltimateOscillator(ISeries<double> input, int fast, int intermediate, int slow)
 
Returns default value  

UltimateOscillator(int fast, int intermediate, int slow)[int barsAgo]  

UltimateOscillator(ISeries<double> input, int fast, int intermediate, int slow)[int barsAgo]

## Return Value
double; Accessing this method via an index value [int barsAgo] returns the indicator value of the referenced bar.

## Parameters
| fast | The number of bars to include in the short term period |
| --- | --- |
| input | Indicator source data ([?](valid_input_data_for_indicator.md)) |
| intermediate | The number of bars to include in the intermediate term period |
| slow | The number of bars to include in the long term period |

## Example
| ns |
| --- |
| // Prints the current value of a typical Ultimate Oscillator using default price type double value = UltimateOscillator(7, 14, 28)[0]; Print("The current Ultimate Oscillator value is " + value.ToString()); |

## Source Code
You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.
