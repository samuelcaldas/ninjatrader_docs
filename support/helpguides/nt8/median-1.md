



Median

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\median.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [ISeries<T>](iseriest-1.htm) > [PriceSeries<double>](priceseries-1.htm) >  Median | [Previous page](lows-1.htm) [Return to chapter overview](priceseries-1.htm) [Next page](medians-1.htm) |

Definition
----------

A collection of historical bar median prices. Median price = (High + Low) / 2.

Property Value
--------------

An ISeries<double> type object. Accessing this property via an index value [int barsAgo] returns a double value representing the price of the referenced bar.

Syntax
------

Median  
Median[int barsAgo]

Examples
--------

| ns |
| --- |
| // Current bar median price  double barMedianPrice = Median[0];     // Median price of 10 bars ago  double barMedianPrice = Median[10];     // Current bar value of a 20 period exponential moving average of median prices  double value = EMA(Median, 20)[0]; |