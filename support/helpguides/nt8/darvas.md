



Darvas

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](darvas.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Common](common.htm) > [System Indicator Methods](indicators.htm) >  Darvas | [Previous page](current_day_ohl.htm) [Return to chapter overview](indicators.htm) [Next page](directional_movement_dm.htm) |

Description
-----------

A trading strategy that was developed in 1956 by former ballroom dancer Nicolas Darvas.  Darvas' trading technique involved buying into stocks that were trading at new 52-week highs with correspondingly high volumes.

... Courtesy of [Investopedia](http://www.investopedia.com/terms/d/darvasboxtheory.asp)

Syntax
------

Darvas()

Darvas(ISeries<double> input)

 

Returns the upper value

Darvas().Upper[int barsAgo]

Darvas(ISeries<double> input).Upper[int barsAgo]

 

Returns the lower value

Darvas().Lower[int barsAgo]

Darvas(ISeries<double> input).Lower[int barsAgo]

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
| // Prints the current upper Darvas value  double value = Darvas().Upper[0];  Print("The current upper Darvas value is " + value.ToString()); |

Source Code
-----------

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.