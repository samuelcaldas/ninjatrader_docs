# Open

## Definition

A collection of historical bar opening prices.

## Property Value

An `ISeries<double>` type object. Accessing this property via an index value [int barsAgo] returns a double value representing the price of the referenced bar.

## Syntax

Open  
Open[int barsAgo]

## Examples

![Ns](../images/ns.png)

```csharp
// Current bar opening price
double barOpenPrice = Open[0];
// Opening price of 10 bars ago
double barOpenPrice = Open[10];
// Current bar value of a 20 period simple moving average of opening prices
double value = SMA(Open, 20)[0];
```