# Summation (SUM)

## Description

Returns the sum of the values taken over a specified period.

## Syntax

SUM(int period)  
SUM(`ISeries<double>` input, int period)

 

Returns default value  
SUM(int period)[int barsAgo]  
SUM(`ISeries<double>` input, int period)[int barsAgo]

## Return Value

double; Accessing this method via an index value [int barsAgo] returns the indicator value of the referenced bar.

## Parameters

|  |  |
| --- | --- |
| input | Indicator source data ([?](valid_input_data_for_indicator.md)) |
| period | Number of bars used in the calculation |

## Examples

```csharp
// Prints the current value of a 20 period SUM using default price type
double value = SUM(20)[0];
Print("The current SUM value is " + value.ToString());
// Prints the current value of a 20 period SUM using high price type
double value = SUM(High, 20)[0];
Print("The current SUM value is " + value.ToString());
```

## Source Code

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.
