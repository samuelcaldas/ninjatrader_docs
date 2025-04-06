



KeyReversalDown

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\keyreversaldown.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [System Indicator Methods](indicators-1.htm) >  KeyReversalDown | [Previous page](keltner_channel-1.htm) [Return to chapter overview](indicators-1.htm) [Next page](keyreversalup-1.htm) |

Description
-----------

Returns a value of 1 when the current close is less than the prior close and the current high has penetrated the highest high of the last n bars.

Syntax
------

KeyReversalDown(int period)  
KeyReversalDown(ISeries<double> input, int period)

 

Returns default value  
KeyReversalDown(int period)[int barsAgo]  
KeyReversalDown(ISeries<double> input, int period)[int barsAgo]

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
| // If we get a reversal over the past 10 bars go short  if (KeyReversalDown(10)[0] == 1)     EnterShort(); |

Source Code
-----------

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.