



Money Flow Oscillator

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\money_flow_oscillator.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [System Indicator Methods](indicators-1.htm) >  Money Flow Oscillator | [Previous page](money_flow_index_mfi-1.htm) [Return to chapter overview](indicators-1.htm) [Next page](moving_average_-_double_expone-1.htm) |

Description
-----------

The Money Flow Oscillator measures the amount of money flow volume over a specific period. A move into positive territory indicates buying pressure while a move into negative territory indicates selling pressure.

Syntax
------

MoneyFlowOscillator(int period)

MoneyFlowOscillator(ISeries<double> input, int period)

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
| // Prints the current value of a 10 period Money Flow Oscillator  double value = MoneyFlowOscillator(10)[0];  Print("The current Money Flow Oscillator value is " + value.ToString()); |