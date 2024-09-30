
NinjaScript > Language Reference > Common > System Indicator Methods > True Strength Index (TSI)
True Strength Index (TSI)
| << [Click to Display Table of Contents](true_strength_index_tsi.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > [System Indicator Methods](indicators.md) > True Strength Index (TSI) | [Previous page](trend-lines.md) [Return to chapter overview](indicators.md) [Next page](ultimate_oscillator.md) |
| --- | --- |
## Description
The True Strength Index (TSI) is a momentum-based indicator, developed by William Blau. Designed to determine both trend and overbought/oversold conditions, the TSI is applicable to intraday time frames as well as long term trading.

## Syntax
TSI(int fast, int slow)  

TSI(ISeries<double> input, int fast, int slow)
 
Returns default value  

TSI(int fast, int slow)[int barsAgo]  

TSI(ISeries<double> input, int fast, int slow)[int barsAgo]

## Return Value
double; Accessing this method via an index value [int barsAgo] returns the indicator value of the referenced bar.

## Parameters
| fast | Period of the fast smoothing factor |
| --- | --- |
| input | Indicator source data ([?](valid_input_data_for_indicator.md)) |
| slow | Period of the slow smoothing factor |

 
## 
## Examples
| ns |
| --- |
| // Prints the current value of a 20 period TSI using default price type double value = TSI(20, 10)[0]; Print("The current TSI value is " + value.ToString());   // Prints the current value of a 20 period TSI using high price type double value = TSI(High, 20, 10)[0]; Print("The current TSI value is " + value.ToString()); |

## Source Code
You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.
