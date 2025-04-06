



UpdateBar()

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\updatebar.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Bars Type](bars_type-1.htm) >  UpdateBar() | [Previous page](barstype_sessioniterator-1.htm) [Return to chapter overview](bars_type-1.htm) [Next page](chart_style-1.htm) |

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