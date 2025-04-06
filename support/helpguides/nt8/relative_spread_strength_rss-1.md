



Relative Spread Strength (RSS)

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\relative_spread_strength_rss.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [System Indicator Methods](indicators-1.htm) >  Relative Spread Strength (RSS) | [Previous page](regression_channel-1.htm) [Return to chapter overview](indicators-1.htm) [Next page](relative_strength_index_rsi-1.htm) |

Description
-----------

Developed by Ian Copsey, Relative Spread Strength is a variation to the [Relative Strength Index](relative_strength_index_rsi-1.htm).

Syntax
------

RSS(int eMA1, int eMA2, int length)

RSS(ISeries<double> input, int eMA1, int eMA2, int length)

 

Returns default value

RSS(int eMA1, int eMA2, int length)[int barsAgo]

RSS(ISeries<double> input, int eMA1, int eMA2, int length)[int barsAgo]

Return Value
------------

double; Accessing this method via an index value [int barsAgo] returns the indicator value of the referenced bar.

Parameters
----------

|  |  |
| --- | --- |
| eMA1 | First EMA's period |
| eMA2 | Second EMA's period |
| input | Indicator source data ([?](valid_input_data_for_indicator-1.htm)) |
| length | Number of bars used in the calculation |

Examples
--------

| ns |
| --- |
| // Prints the current value of the RSS using default price type  double value = RSS(10, 40, 5)[0];  Print("The current RSS value is " + value.ToString());     // Prints the current value of the RSS using high price type  double value = RSS(High, 10, 40, 5)[0];  Print("The current RSS value is " + value.ToString()); |

Source Code
-----------

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.