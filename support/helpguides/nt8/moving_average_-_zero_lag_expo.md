
NinjaScript > Language Reference > Common > System Indicator Methods > Moving Average - Zero Lag Exponential (ZLEMA)

Moving Average - Zero Lag Exponential (ZLEMA)

| << [Click to Display Table of Contents](moving_average_-_zero_lag_expo.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > [System Indicator Methods](indicators.md) > Moving Average - Zero Lag Exponential (ZLEMA) | [Previous page](moving_average_-_weighted_wma.md) [Return to chapter overview](indicators.md) [Next page](moving_average_convergence-divergence_macd.md) |
| --- | --- |
## Description
The Zero-Lag Exponential Moving Average is a variation on the Exponential Moving Average. The Zero-Lag keeps the benefit of the heavier weighting of recent values, but attempts to remove lag by subtracting older data to minimize the cumulative effect.
 
... Courtesy of [FMLabs](http://www.fmlabs.com/reference/default.htm?url=ZeroLagExpMA.md)

## Syntax
ZLEMA(int period)  

ZLEMA(ISeries<double> input, int period)
 
Returns default value  

ZLEMA(int period)[int barsAgo]  

ZLEMA(ISeries<double> input, int period)[int barsAgo]

## Return Value
double; Accessing this method via an index value [int barsAgo] returns the indicator value of the referenced bar.

## Parameters

| input | Indicator source data ([?](valid_input_data_for_indicator.md)) |
| --- | --- |
| period | Number of bars used in the calculation |

## Examples

| ns |
| --- |
| // Prints the current value of a 20 period ZLEMA using default price type double value = ZLEMA(20)[0]; Print("The current SMA value is " + value.ToString());   // Prints the current value of a 20 period ZLEMA using high price type double value = ZLEMA(High, 20)[0]; Print("The current ZLEMA value is " + value.ToString()); |

## Source Code
You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.
