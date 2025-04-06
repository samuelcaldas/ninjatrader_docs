



Fisher Transform

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\fisher_transform.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [System Indicator Methods](indicators-1.htm) >  Fisher Transform | [Previous page](fibonacci_pivots-1.htm) [Return to chapter overview](indicators-1.htm) [Next page](forecast_oscillator_fosc-1.htm) |

Description
-----------

With distinct turning points and a rapid response time, the Fisher Transform uses the assumption that while prices do not have a normal or Gaussian probability density function (that familiar bell-shaped curve), you can create a nearly Gaussian probability density function by normalizing price (or an indicator such as RSI) and applying the Fisher Transform. Use the resulting peak swings to clearly identify price reversals.

Syntax
------

FisherTransform(int period)  
FisherTransform(ISeries<double> input, int period)

 

Returns default value  
FisherTransform(int period)[int barsAgo]  
FisherTransform(ISeries<double> input, int period)[int barsAgo]

Return Value
------------

double; Accessing this method via an index value [int barsAgo] returns the indicator value of the referenced bar.

Parameters
----------

|  |  |
| --- | --- |
| input | Indicator source data ([?](valid_input_data_for_indicator-1.htm)) |
| period | Number of bars used in the calculation |

Example
-------

| ns |
| --- |
| // Prints the current value of a 10 period using default (median) price type  double value = FisherTransform(10)[0];  Print("The current Fisher Transform value is " + value.ToString()); |

Source Code
-----------

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.