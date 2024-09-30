
NinjaScript > Language Reference > Common > System Indicator Methods > Chaikin Volatility
Chaikin Volatility
| << [Click to Display Table of Contents](chaikin_volatility.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > [System Indicator Methods](indicators.md) > Chaikin Volatility | [Previous page](chaikin_oscillator.md) [Return to chapter overview](indicators.md) [Next page](chande_momentum_oscillator_cmo.md) |
| --- | --- |
## Description
The Chaikin Volatility Indicator is the difference between two moving averages of a volume weighted accumulation-distribution line. By comparing the spread between a security's high and low prices, it quantifies volatility as a widening of the range between the high and the low price.

## Syntax
ChaikinVolatility(int mAPeriod, int rOCPeriod)  

ChaikinVolatility(ISeries<double> input, int mAPeriod, int rOCPeriod)  

   

Returns default value  

ChaikinVolatility(int mAPeriod, int rOCPeriod)[int barsAgo]  

ChaikinVolatility(ISeries<double> input, int mAPeriod, int rOCPeriod)[int barsAgo]

## Return Value
double; Accessing this method via an index value [int barsAgo] returns the indicator value of the referenced bar.

## Parameters
| input | Indicator source data ([?](valid_input_data_for_indicator.md)) |
| --- | --- |
| mAPeriod | Number of bars used in the moving average calculation |
| rOCPeriod | Number of bars used in the rate of change calculation |
 
## 
## Example
| ns |
| --- |
| // Prints the current value of the 20 period Chaikin Volatility double value = ChaikinVolatility(20, 20)[0]; Print("The current Chaikin Volatility value is " + value.ToString()); |

## Source Code
You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

