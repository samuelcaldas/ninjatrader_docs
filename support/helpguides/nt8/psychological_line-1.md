



Psychological Line

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\psychological_line.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [System Indicator Methods](indicators-1.htm) >  Psychological Line | [Previous page](prior_day_ohlc-1.htm) [Return to chapter overview](indicators-1.htm) [Next page](range-1.htm) |

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
| input | Indicator source data ([?](valid_input_data_for_indicator-1.htm)) |
| period | Number of bars used in the calculation |

Examples
--------

| ns |
| --- |
| // Prints the current value of a 10 period Psychological Line  double value = PsychologicalLine(10)[0];  Print("The current Psychological Line value is " + value.ToString()); |