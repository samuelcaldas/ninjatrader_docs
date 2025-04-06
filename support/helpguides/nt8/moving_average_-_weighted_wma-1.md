



Moving Average - Weighted (WMA)

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\moving_average_-_weighted_wma.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [System Indicator Methods](indicators-1.htm) >  Moving Average - Weighted (WMA) | [Previous page](moving_average_-_volume_weight-1.htm) [Return to chapter overview](indicators-1.htm) [Next page](moving_average_-_zero_lag_expo-1.htm) |

Description
-----------

The Weighted Moving Average gives the latest price more weight than prior prices. Each prior price in the period gets progressively less weight as they become older.

Syntax
------

WMA(int period)  
WMA(ISeries<double> input, int period)

 

Returns default value  
WMA(int period)[int barsAgo]  
WMA(ISeries<double> input, int period)[int barsAgo]

Return Value
------------

double; Accessing this method via an index value [int barsAgo] returns the indicator value of the referenced bar.

Parameters
----------

|  |  |
| --- | --- |
| input | Indicator source data ([?](valid_input_data_for_indicator-1.htm)) |
| period | Number of bars used in the calculation |

Examples
--------

| ns |
| --- |
| // Prints the current value of a 20 period WMA using default price type  double value = WMA(20)[0];  Print("The current WMA value is " + value.ToString());     // Prints the current value of a 20 period WMA using high price type  double value = WMA(High, 20)[0];  Print("The current WMA value is " + value.ToString()); |

Source Code
-----------

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.