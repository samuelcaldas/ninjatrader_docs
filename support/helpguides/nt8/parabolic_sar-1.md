



Parabolic SAR

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\parabolic_sar.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [System Indicator Methods](indicators-1.htm) >  Parabolic SAR | [Previous page](order_flow_vwap2-1.htm) [Return to chapter overview](indicators-1.htm) [Next page](percentage_price_oscillator_pp-1.htm) |

Description
-----------

The parabolic SAR is a technical indicator that is used by many traders to determine the direction of an asset's momentum and the point in time when this momentum has a higher-than-normal probability of switching directions.

... Courtesy of [Investopedia](http://www.investopedia.com/articles/technical/02/042202.asp)

Syntax
------

ParabolicSAR(double acceleration, double accelerationMax, double accelerationStep)

ParabolicSAR(ISeries<double> input, double acceleration, double accelerationMax, double accelerationStep)

 

 

Returns default value  
ParabolicSAR(double acceleration, double accelerationMax, double accelerationStep)[int barsAgo]  
ParabolicSAR(ISeries<double> input, double acceleration, double accelerationStep, double accelerationMax)[int barsAgo]

Return Value
------------

double; Accessing this method via an index value [int barsAgo] returns the indicator value of the referenced bar.

Parameters
----------

|  |  |
| --- | --- |
| acceleration | Acceleration value |
| accelerationStep | Step value used to increment acceleration value |
| accelerationMax | Max acceleration value |
| input | Indicator source data ([?](valid_input_data_for_indicator-1.htm)) |

Example
-------

| ns |
| --- |
| // Prints the current value of ParabolicSAR using default price type  double value = ParabolicSAR(0.02, 0.2, 0.02)[0];  Print("The current ParabolicSAR value is " + value.ToString()); |

Source Code
-----------

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.