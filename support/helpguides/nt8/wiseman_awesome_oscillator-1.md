



Wiseman Awesome Oscillator

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\wiseman_awesome_oscillator.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [System Indicator Methods](indicators-1.htm) >  Wiseman Awesome Oscillator | [Previous page](wiseman_alligator-1.htm) [Return to chapter overview](indicators-1.htm) [Next page](woodies_cci-1.htm) |

Description
-----------

The Wiseman Awesome Oscillator is a momentum indicator to identify trends and reversals. This indicator was provided by Profitunity: [http://www.profitunity.com](http://www.profitunity.com/)

Syntax
------

WisemanAwesomeOscillator()

WisemanAwesomeOscillator(ISeries<double> input)

Return Value
------------

double; Accessing this method via an index value [int barsAgo] returns the indicator value of the referenced bar.

Parameters
----------

|  |  |
| --- | --- |
| input | Indicator source data ([?](valid_input_data_for_indicator-1.htm)) |

Examples
--------

| ns |
| --- |
| // Prints the current value of the Wiseman Awesome Oscillator  double value = WisemanAwesomeOscillator()[0];  Print("The current Wiseman Awesome Oscillator value is " + value.ToString()); |