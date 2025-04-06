



n Bars Up

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\n_bars_up.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [System Indicator Methods](indicators-1.htm) >  n Bars Up | [Previous page](n_bars_down-1.htm) [Return to chapter overview](indicators-1.htm) [Next page](on_balance_volume_obv-1.htm) |

Description
-----------

Evaluates for n number of consecutive higher closes. Returns a value of 1 when the condition is true or 0 when false.

Syntax
------

NBarsUp(int barCount, bool barUp, bool higherHigh, bool higherLow)  
NBarsUp(ISeries<double> input, int barCount, bool barUp, bool higherHigh, bool higherLow)

 

Returns default value  
NBarsUp(int barCount, bool barUp, bool higherHigh, bool higherLow)[int barsAgo]  
NBarsUp(ISeries<double> input, int barCount, bool barUp, bool higherHigh, bool higherLow)[int barsAgo]

Return Value
------------

double; Accessing this method via an index value [int barsAgo] returns the indicator value of the referenced bar.

Parameters
----------

|  |  |
| --- | --- |
| input | Indicator source data ([?](valid_input_data_for_indicator-1.htm)) |
| barCount | The number of required consecutive higher closes |
| barUp | Each bar's close must be higher than the open; true or false |
| higherHigh | Consecutive higher highs required; true or false |
| higherLow | Consecutive higher lows required; true or false |

Example
-------

| ns |
| --- |
| // OnBarUpdate method  protected override void OnBarUpdate()  {     // Evaluates if we have 3 consecutive higher closes     double value = NBarsUp(3, true, true, true)[0];        if (value == 1)         Print("We have three consecutive higher closes");  } |

Source Code
-----------

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.