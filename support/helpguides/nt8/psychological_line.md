



Psychological Line

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](psychological_line.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Common](common.htm) > [System Indicator Methods](indicators.htm) >  Psychological Line | [Previous page](prior_day_ohlc.htm) [Return to chapter overview](indicators.htm) [Next page](range.htm) |

Description
-----------

The Psychological Line is the ratio of the number of rising bars over the specified number of bars.

Syntax
------

PsychologicalLine(int period)

PsychologicalLine(ISeries<double> input, int period)

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
| // Prints the current value of a 10 period Psychological Line  double value = PsychologicalLine(10)[0];  Print("The current Psychological Line value is " + value.ToString()); |