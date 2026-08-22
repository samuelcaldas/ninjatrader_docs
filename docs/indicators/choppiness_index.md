# Choppiness Index

## Description

The Choppiness Index is designed to determine if the market is choppy (trading sideways) or not choppy (trading within a trend in either direction)

## Syntax

ChoppinessIndex(int period)

ChoppinessIndex(`ISeries<double>` input, int period)

## Return Value

double; Accessing this method via an index value [int barsAgo] returns the indicator value of the referenced bar.

## Parameters

| Name / Option | Description |
| --- | --- |
| input | Indicator source data ([?](valid_input_data_for_indicator.md)) |
| period | Number of bars used in the calculation |

## Examples

![Ns](../images/ns.png)

```csharp
// Prints the current value of a 14 period Choppiness Index
double value = ChoppinessIndex(14)[0];
Print("The current Choppiness Index value is " + value.ToString());
```