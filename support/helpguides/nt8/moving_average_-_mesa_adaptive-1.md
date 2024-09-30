
NinjaScript \> Language Reference \> Common \> System Indicator Methods \> Moving Average \- Mesa Adaptive (MAMA)

Moving Average \- Mesa Adaptive (MAMA)

| \<\< [Click to Display Table of Contents](moving_average_-_mesa_adaptive.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [System Indicator Methods](indicators-1.md) \> Moving Average \- Mesa Adaptive (MAMA) | [Previous page](moving_average_-_kaufmans_adap-1.md) [Return to chapter overview](indicators-1.md) [Next page](moving_average_-_simple_sma-1.md) |
| --- | --- |
## Description
The MESA Adaptive Moving Average (MAMA) adapts to price movement in an entirely new and unique way. The adaptation is based on the rate change of phase as measured by the Hilbert Transform Discriminator. The advantage of this method of adaptation is that it features a fast attack average and a slow decay average so that composite average rapidly ratchets behind price changes and holds the average value until the next ratchet occurs. 

## Syntax
MAMA(double fastLimit, double slowLimit)  

MAMA(ISeries\<double\> input, double fastLimit, double slowLimit)
 
Returns MAMA value  

MAMA(double fastLimit, double slowLimit)\[int barsAgo]  

MAMA(ISeries\<double\> input, double fastLimit, double slowLimit)\[int barsAgo]
 
Returns Fama (Following Adaptive Moving Average) value  

MAMA(double fastLimit, double slowLimit).Fama\[int barsAgo]  

MAMA(ISeries\<double\> input, double fastLimit, double slowLimit).Fama\[int barsAgo]

## Return Value
double; Accessing this method via an index value \[int barsAgo] returns the indicator value of the referenced bar.

## Parameters

| fastLimit | Upper limit of the alpha value |
| --- | --- |
| input | Indicator source data ([?](valid_input_data_for_indicator-1.md)) |
| slowLimit | Lower limit of the alpha value |
 
## 
## Examples

| ns |
| --- |
| // Prints the current value of a 20 period MAMA using default price type double value \= MAMA(0\.5, 0\.05).Default\[0]; Print("The current MAMA value is " \+ value.ToString());   // Prints the current value of a 20 period Fama using high price type double value \= MAMA(High, 0\.5, 0\.05).Fama\[0]; Print("The current Fama value is " \+ value.ToString()); |

## Source Code
You can view this indicator method source code by selecting the menu New \> NinjaScript Editor \> Indicators within the NinjaTrader Control Center window.
