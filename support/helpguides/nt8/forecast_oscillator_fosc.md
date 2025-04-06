



Forecast Oscillator (FOSC)

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](forecast_oscillator_fosc.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Common](common.htm) > [System Indicator Methods](indicators.htm) >  Forecast Oscillator (FOSC) | [Previous page](fisher_transform.htm) [Return to chapter overview](indicators.htm) [Next page](keltner_channel.htm) |

Description
-----------

The Forecast Oscillator calculates the percentage difference between the actual price and the Time Series Forecast (the endpoint of a linear regression line). When the price and the forecast are equal, the Oscillator is zero. When the price is greater than the forecast, the Oscillator is greater than zero. When the price is less than the forecast, the Oscillator is less than zero.

... Courtesy of [FM Labs](http://www.fmlabs.com/reference/default.htm?url=ForecastOscillator.htm)

Syntax
------

FOSC(int period)  
FOSC(ISeries<double> input, int period)

 

Returns default value  
FOSC(int period)[int barsAgo]  
FOSC(ISeries<double> input, int period)[int barsAgo]

Return Value
------------

double; Accessing this method via an index value [int barsAgo] returns the indicator value of the referenced bar.

Parameters
----------

|  |  |
| --- | --- |
| input | Indicator source data ([?](valid_input_data_for_indicator.htm)) |
| period | Number of bars used in the calculation |

Example
-------

| ns |
| --- |
| // Evaluates if the current bar FOCS is above zero  if (FOSC(14)[0] > 0)     Print("FOSC is above zero indicating prices may rise"); |

Source Code
-----------

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.