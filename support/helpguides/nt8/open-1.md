



Open

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\open.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [ISeries<T>](iseriest-1.htm) > [PriceSeries<double>](priceseries-1.htm) >  Open | [Previous page](medians-1.htm) [Return to chapter overview](priceseries-1.htm) [Next page](opens-1.htm) |

Definition
----------

A collection of historical bar opening prices.

Property Value
--------------

An ISeries<double> type object. Accessing this property via an index value [int barsAgo] returns a double value representing the price of the referenced bar.

Syntax
------

Open  
Open[int barsAgo]

Examples
--------

| ns |
| --- |
| // Current bar opening price  double barOpenPrice = Open[0];     // Opening price of 10 bars ago  double barOpenPrice = Open[10];     // Current bar value of a 20 period simple moving average of opening prices  double value = SMA(Open, 20)[0]; |