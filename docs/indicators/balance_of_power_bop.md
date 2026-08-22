# Balance of Power (BOP)

## Description

The balance of power (BOP) indicator measures the strength of the bulls vs. bears by assessing the ability of each to push price to an extreme level.

## Syntax

BOP(int smooth)  
BOP(`ISeries<double>` input, int smooth)

 

Returns default value  
BOP(int smooth)[int barsAgo]  
BOP(`ISeries<double>` input, int smooth)[int barsAgo]

## Return Value

double; Accessing this method via an index value [int barsAgo] returns the indicator value of the referenced bar.

## Parameters

| Name / Option | Description |
| --- | --- |
| input | Indicator source data ([?](valid_input_data_for_indicator.md)) |
| smooth | The smoothing period |

## Example

```csharp
// Prints the current value of BOP using default price type and 3 period smoothing
double value = BOP(3)[0];
Print("The current BOP value is " + value.ToString());
```

## Source Code

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.
