# Typical

## Definition

A collection of historical bar typical prices. Typical price = (High + Low + Close) / 3.

## Property Value

An `ISeries<double>` type object. Accessing this property via an index value [int barsAgo] returns a double value representing the price of the referenced bar.

## Syntax

Typical  
Typical[int barsAgo]

## Examples

![Ns](../images/ns.png)

```csharp
// Current bar typical price
double barTypicalPrice = Typical[0];
// Typical price of 10 bars ago
double barTypicalPrice = Typical[10];
// Current bar value of a 20 period exponential moving average of typical prices
double value = EMA(Typical, 20)[0];
```