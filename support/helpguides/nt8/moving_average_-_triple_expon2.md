
NinjaScript > Language Reference > Common > System Indicator Methods > Moving Average - Triple Exponential (TRIX)

Moving Average - Triple Exponential (TRIX)

| << [Click to Display Table of Contents](moving_average_-_triple_expon2.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > [System Indicator Methods](indicators.md) > Moving Average - Triple Exponential (TRIX) | [Previous page](moving_average_-_triple_expone.md) [Return to chapter overview](indicators.md) [Next page](moving_average_-_variable_vma.md) |
| --- | --- |
## Description
The triple exponential average (TRIX) indicator is an oscillator used to identify oversold and overbought markets, and it can also be used as a momentum indicator.
 
... Courtesy of [Investopedia](http://www.investopedia.com/articles/technical/02/092402.asp)

## Syntax
TRIX(int period, int signalPeriod)  

TRIX(ISeries<double> input, int period, int signalPeriod)
 
Returns trix value  

TRIX(int period, int signalPeriod)[int barsAgo]  

TRIX(ISeries<double> input, int period, int signalPeriod)[int barsAgo]
 
Returns signal value  

TRIX(int period, int signalPeriod).Signal[int barsAgo]  

TRIX(ISeries<double> input, int period, int signalPeriod).Signal[int barsAgo]

## Return Value
double; Accessing this method via an index value [int barsAgo] returns the indicator value of the referenced bar.

## Parameters

| input | Indicator source data ([?](valid_input_data_for_indicator.md)) |
| --- | --- |
| period | Number of bars used in the calculation |
| signalPeriod | Period for signal line |

## Examples

| ns |
| --- |
| // Prints the current value of a 20 period TRIX using default price type double value = TRIX(20, 3).Default[0]; Print("The current TRIX value is " + value.ToString());   // Prints the current signal value of a 20 period TRIX using high price type double value = TRIX(High, 20, 3).Signal[0]; Print("The current TRIX signal value is " + value.ToString()); |

## Source Code
You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.
