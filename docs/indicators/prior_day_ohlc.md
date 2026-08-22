# Prior Day OHLC

## Description

The prior day (session) open, high, low and close values.

> **Note:** Only use this indicator on intraday series.

## Syntax

PriorDayOHLC()  
PriorDayOHLC(`ISeries<double>` input)

 

Returns prior session open value  
PriorDayOHLC().PriorOpen[int barsAgo]  
PriorDayOHLC(`ISeries<double>` input).PriorOpen[int barsAgo]

 

Returns prior session high value  
PriorDayOHLC().PriorHigh[int barsAgo]  
PriorDayOHLC(`ISeries<double>` input).PriorHigh[int barsAgo]

 

Returns prior session low value  
PriorDayOHLC().PriorLow[int barsAgo]  
PriorDayOHLC(`ISeries<double>` input).PriorLow[int barsAgo]

 

Returns prior session close value  
PriorDayOHLC().PriorClose[int barsAgo]  
PriorDayOHLC(`ISeries<double>` input).PriorClose[int barsAgo]

## Return Value

double; Accessing this method via an index value [int barsAgo] returns the indicator value of the referenced bar.

## Parameters

| Name / Option | Description |
| --- | --- |
| input | Indicator source data ([?](valid_input_data_for_indicator.md)) |

## Example

```csharp
// Prints the value of the prior session low
double value = PriorDayOHLC().PriorLow[0];
Print("The prior session low value is " + value.ToString());
```

## Source Code

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.
