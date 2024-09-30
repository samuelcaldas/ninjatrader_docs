
NinjaScript > Language Reference > Common > System Indicator Methods > Chaikin Money Flow
Chaikin Money Flow
| << [Click to Display Table of Contents](chaikin_money_flow.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > [System Indicator Methods](indicators.md) > Chaikin Money Flow | [Previous page](candlestickpattern.md) [Return to chapter overview](indicators.md) [Next page](chaikin_oscillator.md) |
| --- | --- |
## Description
The formula for Chaikin Money Flow is the cumulative total of the Accumulation/Distribution Values for 21 periods divided by the cumulative total of volume for 21 periods. 
 
... Courtesy of [StockCharts](http://stockcharts.com/education/IndicatorAnalysis/indic_ChaikinMoneyFlow1.md)

## Syntax
ChaikinMoneyFlow(int period)  

ChaikinMoneyFlow(ISeries<double> input, int period)
 
Returns default value  

ChaikinMoneyFlow(int period)[int barsAgo]  

ChaikinMoneyFlow(ISeries<double> input, int period)[int barsAgo]

## Return Value
double; Accessing this method via an index value [int barsAgo] returns the indicator value of the referenced bar.

## Parameters
| input | Indicator source data ([?](valid_input_data_for_indicator.md)) |
| --- | --- |
| period | Number of bars used in the calculation |
 
## 
## Example
| ns |
| --- |
| // Prints the current value of a 20 period ChaikinMoneyFlow using default price type double value = ChaikinMoneyFlow(20)[0]; Print("The current ChaikinMoneyFlow value is " + value.ToString()); |

## Source Code
You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

