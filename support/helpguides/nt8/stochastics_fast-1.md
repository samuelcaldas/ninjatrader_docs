
NinjaScript > Language Reference > Common > System Indicator Methods > Stochastics Fast
Stochastics Fast
| << [Click to Display Table of Contents](stochastics_fast.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [System Indicator Methods](indicators-1.md) > Stochastics Fast | [Previous page](stochastics-1.md) [Return to chapter overview](indicators-1.md) [Next page](stochastics_rsi_stochrsi-1.md) |
| --- | --- |
## Description
Developed by George C. Lane in the late 1950s, the Stochastic Oscillator is a momentum indicator that shows the location of the current close relative to the high/low range over a set number of periods. Closing levels that are consistently near the top of the range indicate accumulation (buying pressure) and those near the bottom of the range indicate distribution (selling pressure). 
 
... Courtesy of [StockCharts](http://stockcharts.com/school/doku.php?id=chart_school:technical_indicators:stochastic_oscillator_fast_slow_and_full)

## Syntax
StochasticsFast(int periodD, int periodK)  

StochasticsFast(ISeries<double> input, int periodD, int periodK)
 
Returns %D value  

StochasticsFast(int periodD, int periodK).D[int barsAgo]  

StochasticsFast(ISeries<double> input, int periodD, int periodK).D[int barsAgo]
 
Returns %K value  

StochasticsFast(int periodD, int periodK).K[int barsAgo]  

StochasticsFast(ISeries<double> input, int periodD, int periodK).K[int barsAgo]

## Return Value
double; Accessing this method via an index value [int barsAgo] returns the indicator value of the referenced bar.

## Parameters
| input | Indicator source data ([?](valid_input_data_for_indicator-1.md)) |
| --- | --- |
| periodD | The period for the moving average of periodD |
| periodK | The period for the moving average of periodK |

## Examples
| ns |
| --- |
| // Prints the current %D value double value = StochasticsFast(3, 14).D[0]; Print("The current StochasticsFast %D value is " + value.ToString());   // Prints the current %K value double value = StochasticsFast(3, 14).K[0]; Print("The current StochasticsFast %K value is " + value.ToString()); |

## Source Code
You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.
