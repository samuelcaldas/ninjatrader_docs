
NinjaScript \> Language Reference \> Common \> ISeries\<T\> \> PriceSeries\<double\> \> Low
Low
| \<\< [Click to Display Table of Contents](low.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [ISeries\<T\>](iseriest.md) \> [PriceSeries\<double\>](priceseries.md) \> Low | [Previous page](inputs.md) [Return to chapter overview](priceseries.md) [Next page](lows.md) |
| --- | --- |
## Definition
A collection of historical bar low prices.
 
## Property Value
An ISeries\<double\> type object. Accessing this property via an index value \[int barsAgo] returns a double value representing the price of the referenced bar.
 
## Syntax
Low  

Low\[int barsAgo]
 
## 
## Examples
| ns |
| --- |
| // Current bar low price double barLowPrice \= Low\[0];   // Low price of 10 bars ago double barLowPrice \= Low\[10];   // Current bar value of a 20 period exponential moving average of low prices double value \= EMA(Low, 20)\[0]; |

 
