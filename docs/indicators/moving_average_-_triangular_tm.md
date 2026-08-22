# Moving Average - Triangular (TMA)

## Description

The Triangular Moving Average is a form of [Weighted Moving Average](moving_average_-_weighted_wma.md) wherein the weights are assigned in a triangular pattern. For example, the weights for a 7 period Triangular Moving Average would be 1, 2, 3, 4, 3, 2, 1. This gives more weight to the middle of the time series and less weight to the oldest and newest data.

## Syntax

TMA(int period)  
TMA(`ISeries<double>` input, int period)

 

Returns default value  
TMA(int period)[int barsAgo]  
TMA(`ISeries<double>` input, int period)[int barsAgo]

## Return Value

double; Accessing this method via an index value [int barsAgo] returns the indicator value of the referenced bar.

## Parameters

| Name / Option | Description |
| --- | --- |
| input | Indicator source data ([?](valid_input_data_for_indicator.md)) |
| period | Number of bars used in the calculation |

## Examples

```csharp
// Prints the current value of a 20 period TMA using default price type
double value = TMA(20)[0];
Print("The current TMA value is " + value.ToString());
// Prints the current value of a 20 period TMA using high price type
double value = TMA(High, 20)[0];
Print("The current TMA value is " + value.ToString());
```

## Source Code

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.
