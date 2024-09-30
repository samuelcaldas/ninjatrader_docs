
NinjaScript > Language Reference > Common > System Indicator Methods > Momentum
Momentum
| << [Click to Display Table of Contents](momentum.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [System Indicator Methods](indicators-1.md) > Momentum | [Previous page](minimum_min-1.md) [Return to chapter overview](indicators-1.md) [Next page](money_flow_index_mfi-1.md) |
| --- | --- |
## Description
By measuring the amount that a security's price has changed over a given time span, the Momentum indicator provides an indication of a market's velocity and to some degree, a measure of the extent to which a trend still holds true. It can also be helpful in spotting likely reversal points.

## Syntax
Momentum(int period)  

Momentum(ISeries<double> input, int period)
 
Returns default value
Momentum(int period)[int barsAgo]  

Momentum(ISeries<double> input, int period)[int barsAgo]

## Return Value
double; Accessing this method via an index value [int barsAgo] returns the indicator value of the referenced bar.

## Parameters
| input | Indicator source data ([?](valid_input_data_for_indicator-1.md)) |
| --- | --- |
| period | Number of bars used in the calculation |

 
## 
## Examples
| ns |
| --- |
| // Prints the current value of a 20 period Momentum using default price type double value = Momentum(20)[0]; Print("The current Momentum value is " + value.ToString());   // Prints the current value of a 20 period Momentum using high price type double value = Momentum(High, 20)[0]; Print("The current Momentum value is " + value.ToString()); |

## Source Code
You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.
