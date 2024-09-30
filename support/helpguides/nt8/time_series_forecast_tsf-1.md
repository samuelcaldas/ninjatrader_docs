
NinjaScript > Language Reference > Common > System Indicator Methods > Time Series Forecast (TSF)
Time Series Forecast (TSF)

| << [Click to Display Table of Contents](time_series_forecast_tsf.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [System Indicator Methods](indicators-1.md) > Time Series Forecast (TSF) | [Previous page](swing-1.md) [Return to chapter overview](indicators-1.md) [Next page](trend-lines-1.md) |
| --- | --- |

## Description
The Time Series Forecast function displays the statistical trend of a security's price over a specified time period based on linear regression analysis. Instead of a straight linear regression trendline, the Time Series Forecast plots the last point of multiple linear regression trendlines. This is why this indicator may sometimes referred to as the "moving linear regression" indicator or the "regression oscillator."

## Syntax
TSF(int forecast, int period)  

TSF(ISeries<double> input, int forecast, int period)
 
Returns default value  

TSF(int forecast, int period)[int barsAgo]  

TSF(ISeries<double> input, int forecast, int period)[int barsAgo]

## Return Value
double; Accessing this method via an index value [int barsAgo] returns the indicator value of the referenced bar.

## Parameters
| forecast | Forecast period |
| --- | --- |
| input | Indicator source data ([?](valid_input_data_for_indicator-1.md)) |
| period | Number of bars used in the calculation |

## Example
| ns |
| --- |
| // Prints the current value of a 20 period TSF using default price type double value = TSF(3, 20)[0]; Print("The current TSF value is " + value.ToString()); |

## Source Code
You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.
