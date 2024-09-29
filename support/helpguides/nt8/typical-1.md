


NinjaScript \> Language Reference \> Common \> ISeries\<T\> \> PriceSeries\<double\> \> Typical






















Typical







| \<\< [Click to Display Table of Contents](typical.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [ISeries\<T\>](iseriest-1.md) \> [PriceSeries\<double\>](priceseries-1.md) \> Typical | [Previous page](opens-1.md) [Return to chapter overview](priceseries-1.md) [Next page](typicals-1.md) |
| --- | --- |











## Definition


A collection of historical bar typical prices. Typical price \= (High \+ Low \+ Close) / 3\.


 


## Property Value


An ISeries\<double\> type object. Accessing this property via an index value \[int barsAgo] returns a double value representing the price of the referenced bar.


 


## Syntax


Typical  

Typical\[int barsAgo]


 


 


## 


## Examples




| ns |
| --- |
| // Current bar typical price double barTypicalPrice \= Typical\[0];   // Typical price of 10 bars ago double barTypicalPrice \= Typical\[10];   // Current bar value of a 20 period exponential moving average of typical prices double value \= EMA(Typical, 20)\[0]; |









