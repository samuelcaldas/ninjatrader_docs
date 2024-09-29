


NinjaScript \> Language Reference \> Common \> ISeries\<T\> \> PriceSeries\<double\> \> Open






















Open







| \<\< [Click to Display Table of Contents](open.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [ISeries\<T\>](iseriest-1.md) \> [PriceSeries\<double\>](priceseries-1.md) \> Open | [Previous page](medians-1.md) [Return to chapter overview](priceseries-1.md) [Next page](opens-1.md) |
| --- | --- |











## Definition


A collection of historical bar opening prices.


 


## Property Value


An ISeries\<double\> type object. Accessing this property via an index value \[int barsAgo] returns a double value representing the price of the referenced bar.


## 


## Syntax


Open  

Open\[int barsAgo]


 


## 


## Examples




| ns |
| --- |
| // Current bar opening price double barOpenPrice \= Open\[0];   // Opening price of 10 bars ago double barOpenPrice \= Open\[10];   // Current bar value of a 20 period simple moving average of opening prices double value \= SMA(Open, 20)\[0]; |









