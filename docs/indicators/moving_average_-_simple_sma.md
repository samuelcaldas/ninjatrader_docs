# Moving Average - Simple (SMA)

## Description

The Simple Moving Average is calculated by summing the closing prices of the security for a period of time and then dividing this total by the number of time periods. Sometimes called an arithmetic moving average, the SMA is basically the average stock price over time.

## Syntax

SMA(int period)  
SMA(`ISeries<double>` input, int period)

 

Returns default value  
SMA(int period)[int barsAgo]  
SMA(`ISeries<double>` input, int period)[int barsAgo]

## Return Value

double; Accessing this method via an index value [int barsAgo] returns the indicator value of the referenced bar.

## Parameters

| Name / Option | Description |
| --- | --- |
| input | Indicator source data ([?](valid_input_data_for_indicator.md)) |
| period | Number of bars used in the calculation |

## Examples

```csharp
// Prints the current value of a 20 period SMA using default price type
double value = SMA(20)[0];
Print("The current SMA value is " + value.ToString());
// Prints the current value of a 20 period SMA using high price type
double value = SMA(High, 20)[0];
Print("The current SMA value is " + value.ToString());
```

## Source Code

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.
