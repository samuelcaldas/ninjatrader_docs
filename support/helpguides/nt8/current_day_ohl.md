



Current Day OHL

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](current_day_ohl.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Common](common.htm) > [System Indicator Methods](indicators.htm) >  Current Day OHL | [Previous page](correlation.htm) [Return to chapter overview](indicators.htm) [Next page](darvas.htm) |

Description
-----------

The current day (session) open, high and low values.

|  |
| --- |
| Note: Only use this indicator on intraday series. |

Syntax
------

CurrentDayOHL()  
CurrentDayOHL(ISeries<double> input)

 

Returns current session open value  
CurrentDayOHL().CurrentOpen[int barsAgo]  
CurrentDayOHL(ISeries<double> input).CurrentOpen[int barsAgo]

 

Returns current session high value  
CurrentDayOHL().CurrentHigh[int barsAgo]  
CurrentDayOHL(ISeries<double> input).CurrentHigh[int barsAgo]

 

Returns current session low value  
CurrentDayOHL().CurrentLow[int barsAgo]  
CurrentDayOHL(ISeries<double> input).CurrentLow[int barsAgo]

Return Value
------------

double; Accessing this method via an index value [int barsAgo] returns the indicator value of the referenced bar.

Parameters
----------

|  |  |
| --- | --- |
| input | Indicator source data ([?](valid_input_data_for_indicator.htm)) |

Example
-------

| ns |
| --- |
| // Prints the current value of the session low  double value = CurrentDayOHL().CurrentLow[0];  Print("The current session low value is " + value.ToString()); |

Source Code
-----------

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.