



Summation (SUM)

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](summation_sum.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Common](common.htm) > [System Indicator Methods](indicators.htm) >  Summation (SUM) | [Previous page](stochastics_rsi_stochrsi.htm) [Return to chapter overview](indicators.htm) [Next page](swing.htm) |

Description
-----------

Returns the sum of the values taken over a specified period.

Syntax
------

SUM(int period)  
SUM(ISeries<double> input, int period)

 

Returns default value  
SUM(int period)[int barsAgo]  
SUM(ISeries<double> input, int period)[int barsAgo]

Return Value
------------

double; Accessing this method via an index value [int barsAgo] returns the indicator value of the referenced bar.

Parameters
----------

|  |  |
| --- | --- |
| input | Indicator source data ([?](valid_input_data_for_indicator.htm)) |
| period | Number of bars used in the calculation |

Examples
--------

| ns |
| --- |
| // Prints the current value of a 20 period SUM using default price type  double value = SUM(20)[0];  Print("The current SUM value is " + value.ToString());     // Prints the current value of a 20 period SUM using high price type  double value = SUM(High, 20)[0];  Print("The current SUM value is " + value.ToString()); |

Source Code
-----------

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.