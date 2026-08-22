# RoundDownToTickSize()

## Definition

Returns a value that is rounded down to the nearest valid value evenly divisible by the instrument's tick size.

## Method Return Value

A double value.

## Syntax

Instrument.MasterInstrument.RoundDownToTickSize(double price)

## Parameters

| Name / Option | Description |
| --- | --- |
| price | A double value representing a price |

## Examples

![Ns](../images/ns.png)

```csharp
//Takes the last 3 closes, divides them by 3, and rounds the value down to the nearest valid tick size
Value[0] = Instrument.MasterInstrument.RoundDownToTickSize((Close[0] + Close[1] + Close[2]) / 3);
```