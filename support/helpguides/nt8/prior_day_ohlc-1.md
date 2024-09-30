
NinjaScript > Language Reference > Common > System Indicator Methods > Prior Day OHLC

Prior Day OHLC

| << [Click to Display Table of Contents](prior_day_ohlc.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [System Indicator Methods](indicators-1.md) > Prior Day OHLC | [Previous page](price_oscillator-1.md) [Return to chapter overview](indicators-1.md) [Next page](psychological_line-1.md) |
| --- | --- |
## Description
The prior day (session) open, high, low and close values.
 

| Note: Only use this indicator on intraday series. |
| --- |
## 
## Syntax
PriorDayOHLC()  

PriorDayOHLC(ISeries<double> input)
 
Returns prior session open value  

PriorDayOHLC().PriorOpen[int barsAgo]  

PriorDayOHLC(ISeries<double> input).PriorOpen[int barsAgo]
 
Returns prior session high value  

PriorDayOHLC().PriorHigh[int barsAgo]  

PriorDayOHLC(ISeries<double> input).PriorHigh[int barsAgo]
 
Returns prior session low value  

PriorDayOHLC().PriorLow[int barsAgo]  

PriorDayOHLC(ISeries<double> input).PriorLow[int barsAgo]
 
Returns prior session close value  

PriorDayOHLC().PriorClose[int barsAgo]  

PriorDayOHLC(ISeries<double> input).PriorClose[int barsAgo]

## Return Value
double; Accessing this method via an index value [int barsAgo] returns the indicator value of the referenced bar.

## Parameters

| input | Indicator source data ([?](valid_input_data_for_indicator-1.md)) |
| --- | --- |

## Example

| ns |
| --- |
| // Prints the value of the prior session low double value = PriorDayOHLC().PriorLow[0]; Print("The prior session low value is " + value.ToString()); |
 
## 
## Source Code
You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.
