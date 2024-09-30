
NinjaScript \> Language Reference \> Common \> ISeries\<T\> \> PriceSeries\<double\> \> Weighted
Weighted

| \<\< [Click to Display Table of Contents](weighted.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [ISeries\<T\>](iseriest-1.md) \> [PriceSeries\<double\>](priceseries-1.md) \> Weighted | [Previous page](values-1.md) [Return to chapter overview](priceseries-1.md) [Next page](weighteds-1.md) |
| --- | --- |

## Definition
A collection of historical bar weighted prices. Weighted price \= (High \+ Low \+ Close \+ Close) / 4\.
 
## Property Value
An ISeries\<double\> type object. Accessing this property via an index value \[int barsAgo] returns a double value representing the price of the referenced bar.
 
## Syntax
Weighted  

Weighted\[int barsAgo]
 
## 
## Examples
| ns |
| --- |
| // Current bar weighted price double barWeigthedPrice \= Weighted\[0];   // Weighted price of 10 bars ago double barWeigthedPrice \= Weighted\[10];   // Current bar value of a 20 period exponential moving average of weighted prices double value \= EMA(Weighted, 20)\[0]; |

