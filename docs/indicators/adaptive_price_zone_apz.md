# Adaptive Price Zone (APZ)

## Description

The Adaptive Price Zone indicator from the S&C, September 2006 article "Trading With An Adpative Price Zone" by Lee Leibfarth is a set of bands based on a short term double smooth exponential moving average. The bands form a channel that surrounds the average price and tracks price fluctuations quickly, especially in volatile markets. As price crosses above the zone it can signal an opportunity to sell in anticipation of a reversal. As price crosses below the zone it can signal an opportunity to buy in anticipation of a reversal.

## Syntax

APZ(double bandPct, int period)   
APZ()

 

Returns upper band value   
APZ(double bandPct, int period).Upper[int barsAgo]   
APZ(]

 

Returns lower band value   
APZ(double bandPct, int period).Lower[int barsAgo]   
APZ(]

## Return Value

double; Accessing this method via an index value [int barsAgo] returns the indicator value of the referenced bar.

## Parameters

| Name / Option | Description |
| --- | --- |
| bandPct | The number of standard deviations |
| input | ?) |
| period | Number of bars used in the calculation |

## Example

```csharp
// Prints the current upper band value of a 20 period APZ
];
Print(upperValue.ToString());
```
## Source Code

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.
