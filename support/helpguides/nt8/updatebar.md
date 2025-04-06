



UpdateBar()

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](updatebar.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Bars Type](bars_type.htm) >  UpdateBar() | [Previous page](barstype_sessioniterator.htm) [Return to chapter overview](bars_type.htm) [Next page](chart_style.htm) |

Definition
----------

Updates a data point in our Bars Type.

Syntax
------

UpdateBar(Bars bars, double high, double low, double close, DateTime time, long volumeAdded)

Parameters
----------

|  |  |
| --- | --- |
| bars | The Bars object of your bars type |
| high | A double value representing the high price |
| low | A double value representing the low price |
| close | A double value representing the close price |
| time | A DateTime value representing the time |
| volume | A long value representing the volume |

Examples
--------

| ns |
| --- |
| UpdateBar(bars, high, low, close, time, volume); |