
NinjaScript \> Language Reference \> Common \> System Indicator Methods \> R\-squared

R\-squared

| \<\< [Click to Display Table of Contents](r_squared.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [System Indicator Methods](indicators.md) \> R\-squared | [Previous page](relative_volatility_index_rvi.md) [Return to chapter overview](indicators.md) [Next page](standard_deviation_stddev.md) |
| --- | --- |
## Description
The r\-squared indicator calculates how well the price approximates a linear regression line. The indicator gets its name from the calculation, which is, the square of the correlation coefficient (referred to in mathematics by the Greek letter rho, or r). The range of the r\-squared is from zero to one.
 
... Courtesy of [FMLabs](http://www.fmlabs.com/reference/default.htm?url=rsquared.md)

## Syntax
RSquared(int period)
RSquared(ISeries\<double\> input, int period)
 
Returns default value
RSquared(int period)\[int barsAgo]
RSquared(ISeries\<double\> input, int period)\[int barsAgo]

## Return Value
double; Accessing this method via an index value \[int barsAgo] returns the indicator value of the referenced bar.

## Parameters

| input | Indicator source data ([?](valid_input_data_for_indicator.md)) |
| --- | --- |
| period | Number of bars used in the calculation |

## Examples

| ns |
| --- |
| // Prints the current value of a 20 period R\-squared using default price type double value \= RSquared(20)\[0]; Print("The current R\-squared value is " \+ value.ToString());   // Prints the current value of a 20 period R\-squared using high price type double value \= RSquared(High, 20)\[0]; Print("The current R\-squared value is " \+ value.ToString()); |

## Source Code
You can view this indicator method source code by selecting the menu New \> NinjaScript Editor \> Indicators within the NinjaTrader Control Center window.
