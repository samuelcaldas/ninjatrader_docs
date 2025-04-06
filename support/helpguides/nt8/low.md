



Low

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](low.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Common](common.htm) > [ISeries<T>](iseriest.htm) > [PriceSeries<double>](priceseries.htm) >  Low | [Previous page](inputs.htm) [Return to chapter overview](priceseries.htm) [Next page](lows.htm) |

Definition
----------

A collection of historical bar low prices.

Property Value
--------------

An ISeries<double> type object. Accessing this property via an index value [int barsAgo] returns a double value representing the price of the referenced bar.

Syntax
------

Low  
Low[int barsAgo]

Examples
--------

| ns |
| --- |
| // Current bar low price  double barLowPrice = Low[0];     // Low price of 10 bars ago  double barLowPrice = Low[10];     // Current bar value of a 20 period exponential moving average of low prices  double value = EMA(Low, 20)[0]; |