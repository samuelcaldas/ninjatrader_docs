



Stochastics RSI (StochRSI)

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\stochastics_rsi_stochrsi.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [System Indicator Methods](indicators-1.htm) >  Stochastics RSI (StochRSI) | [Previous page](stochastics_fast-1.htm) [Return to chapter overview](indicators-1.htm) [Next page](summation_sum-1.htm) |

Description
-----------

This is an indicator on indicator implementation. It is simply a [Stochastics](stochastics-1.htm) indicator applied on [RSI](relative_strength_index_rsi-1.htm).

Syntax
------

StochRSI(int period)  
StochRSI(ISeries<double> input, int period)

 

Returns default value  
StochRSI(int period)[int barsAgo]  
StochRSI(ISeries<double> input, int period)[int barsAgo]

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
| // Evaluates if the current bar StochRSI value is greater than the value one bar ago  if (StochRSI(14)[0] > StochRSI(14)[1])     Print("Stochastics RSI is rising"); |

Source Code
-----------

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.