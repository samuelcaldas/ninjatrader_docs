



AddBar()

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\addbar.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Bars Type](bars_type-1.htm) >  AddBar() | [Previous page](bars_type-1.htm) [Return to chapter overview](bars_type-1.htm) [Next page](applydefaultbaseperiodvalue-1.htm) |

Definition
----------

Adds new data points for the Bars Type.

Syntax
------

AddBar(Bars bars, double open, double high, double low, double close, DateTime time, long volume)

AddBar(Bars bars, double open, double high, double low, double close, DateTime time, long volume, double bid, double ask)

Parameters
----------

|  |  |
| --- | --- |
| bars | The Bars object of your bars type |
| open | double value representing the open price |
| high | double value representing the high price |
| low | double value representing the low price |
| close | double value representing the close price |
| time | DateTime value representing the time |
| volume | long value representing the volume |
| bid | double value representing the bid price |
| ask | double value representing the ask price |

Examples
--------

|  |
| --- |
| AddBar(bars,bars.BarsPeriod.Value)); |