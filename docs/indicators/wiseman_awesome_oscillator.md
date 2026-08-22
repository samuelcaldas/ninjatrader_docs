# Wiseman Awesome Oscillator

## Description

The Wiseman Awesome Oscillator is a momentum indicator to identify trends and reversals. This indicator was provided by Profitunity: [http://www.profitunity.com](http://www.profitunity.com/)

## Syntax

WisemanAwesomeOscillator()

WisemanAwesomeOscillator(`ISeries<double>` input)

## Return Value

double; Accessing this method via an index value [int barsAgo] returns the indicator value of the referenced bar.

## Parameters

| Name / Option | Description |
| --- | --- |
| input | Indicator source data ([?](valid_input_data_for_indicator.md)) |

## Examples

![Ns](../images/ns.png)

```csharp
// Prints the current value of the Wiseman Awesome Oscillator
double value = WisemanAwesomeOscillator()[0];
Print("The current Wiseman Awesome Oscillator value is " + value.ToString());
```