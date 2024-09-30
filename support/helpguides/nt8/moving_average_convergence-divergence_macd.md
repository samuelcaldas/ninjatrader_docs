
NinjaScript \> Language Reference \> Common \> System Indicator Methods \> Moving Average Convergence\-Divergence (MACD)

Moving Average Convergence\-Divergence (MACD)

| \<\< [Click to Display Table of Contents](moving_average_convergence-divergence_macd.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [System Indicator Methods](indicators.md) \> Moving Average Convergence\-Divergence (MACD) | [Previous page](moving_average_-_zero_lag_expo.md) [Return to chapter overview](indicators.md) [Next page](moving_average_ribbon.md) |
| --- | --- |
## Description
MACD uses moving averages, which are lagging indicators, to include some trend\-following characteristics. These lagging indicators are turned into a momentum oscillator by subtracting the longer moving average from the shorter moving average. 
 
... Courtesy of [StockCharts](http://stockcharts.com/education/IndicatorAnalysis/indic_MACD1.md)

## Syntax
MACD(int fast, int slow, int smooth)  

MACD(ISeries\<double\> input, int fast, int slow, int smooth)
 
Returns MACD value  

MACD(int fast, int slow, int smooth)\[int barsAgo]  

MACD(ISeries\<double\> input, int fast, int slow, int smooth)\[int barsAgo]
 
Returns average value  

MACD(int fast, int slow, int smooth).Avg\[int barsAgo]  

MACD(ISeries\<double\> input, int fast, int slow, int smooth).Avg\[int barsAgo]
 
Returns difference value  

MACD(int fast, int slow, int smooth).Diff\[int barsAgo]  

MACD(ISeries\<double\> input, int fast, int slow, int smooth).Diff\[int barsAgo]

## Return Value
double; Accessing this method via an index value \[int barsAgo] returns the indicator value of the referenced bar.

## Parameters

| fast | The number of bars to calculate the fast [EMA](moving_average_-_exponential_e.md) |
| --- | --- |
| input | Indicator source data ([?](valid_input_data_for_indicator.md)) |
| slow | The numbers of bars to calculate the slow EMA |
| smooth | The number of bars to calculate the EMA signal line |

## Examples

| ns |
| --- |
| // Prints the current MACD value double value \= MACD(12, 26, 9)\[0]; Print("The current MACD value is " \+ value.ToString());   // Prints the current MACD average value double value \= MACD(12, 26, 9).Avg\[0]; Print("The current MACD average value is " \+ value.ToString());   // Prints the current MACD difference value double value \= MACD(12, 26, 9).Diff\[0]; Print("The current MACD difference value is " \+ value.ToString()); |

## Source Code
You can view this indicator method source code by selecting the menu New \> NinjaScript Editor \> Indicators within the NinjaTrader Control Center window.
