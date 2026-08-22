# Weighted

## Definition

A collection of historical bar weighted prices. Weighted price = (High + Low + Close + Close) / 4.

## Property Value

An `ISeries<double>` type object. Accessing this property via an index value [int barsAgo] returns a double value representing the price of the referenced bar.

## Syntax

Weighted  
Weighted[int barsAgo]

## Examples

```csharp
// Current bar weighted price
double barWeigthedPrice = Weighted[0];
// Weighted price of 10 bars ago
double barWeigthedPrice = Weighted[10];
// Current bar value of a 20 period exponential moving average of weighted prices
double value = EMA(Weighted, 20)[0];
```
