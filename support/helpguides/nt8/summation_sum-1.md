
NinjaScript > Language Reference > Common > System Indicator Methods > Summation (SUM)
Summation (SUM)
| << [Click to Display Table of Contents](summation_sum.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [System Indicator Methods](indicators-1.md) > Summation (SUM) | [Previous page](stochastics_rsi_stochrsi-1.md) [Return to chapter overview](indicators-1.md) [Next page](swing-1.md) |
| --- | --- |
## Description
Returns the sum of the values taken over a specified period.

## Syntax
SUM(int period)  

SUM(ISeries<double> input, int period)
 
Returns default value  

SUM(int period)[int barsAgo]  

SUM(ISeries<double> input, int period)[int barsAgo]

## Return Value
double; Accessing this method via an index value [int barsAgo] returns the indicator value of the referenced bar.

## Parameters
| input | Indicator source data ([?](valid_input_data_for_indicator-1.md)) |
| --- | --- |
| period | Number of bars used in the calculation |

## Examples
| ns |
| --- |
| // Prints the current value of a 20 period SUM using default price type double value = SUM(20)[0]; Print("The current SUM value is " + value.ToString());   // Prints the current value of a 20 period SUM using high price type double value = SUM(High, 20)[0]; Print("The current SUM value is " + value.ToString()); |

## Source Code
You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.
