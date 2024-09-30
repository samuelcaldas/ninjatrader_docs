
NinjaScript > Language Reference > Common > System Indicator Methods > Standard Deviation (StdDev)

Standard Deviation (StdDev)

| << [Click to Display Table of Contents](standard_deviation_stddev.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > [System Indicator Methods](indicators.md) > Standard Deviation (StdDev) | [Previous page](r_squared.md) [Return to chapter overview](indicators.md) [Next page](standard_error_stderror.md) |
| --- | --- |
## Description
In probability theory and statistics, standard deviation is a measure of the variability or dispersion of a population, a data set, or a probability distribution. A low standard deviation indicates that the data points tend to be very close to the same value (the mean), while high standard deviation indicates that the data are “spread out” over a large range of values.
 
... Courtesy of [Wikipedia](http://en.wikipedia.org/wiki/Standard_deviation)

## Syntax
StdDev(int period)  

StdDev(ISeries<double> input, int period)
 
Returns default value  

StdDev(int period)[int barsAgo]  

StdDev(ISeries<double> input, int period)[int barsAgo]

## Return Value
double; Accessing this method via an index value [int barsAgo] returns the indicator value of the referenced bar.

## Parameters

| input | Indicator source data ([?](valid_input_data_for_indicator.md)) |
| --- | --- |
| period | Number of bars used in the calculation |

## Examples

| ns |
| --- |
| // Prints the current value of a 20 period StdDev using default price type double value = StdDev(20)[0]; Print("The current StdDev value is " + value.ToString());   // Prints the current value of a 20 period StdDev using high price type double value = StdDev(High, 20)[0]; Print("The current StdDev value is " + value.ToString()); |

## Source Code
You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.
