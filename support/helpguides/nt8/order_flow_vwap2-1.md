
NinjaScript \> Language Reference \> Common \> System Indicator Methods \> Order Flow VWAP

Order Flow VWAP

| \<\< [Click to Display Table of Contents](order_flow_vwap2.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [System Indicator Methods](indicators-1.md) \> Order Flow VWAP | [Previous page](order_flow_volumetric_bars2-1.md) [Return to chapter overview](indicators-1.md) [Next page](parabolic_sar-1.md) |
| --- | --- |
## Description
Volume Weighted Average Price. A total of the dollars traded for every transaction (price multiplied by number of shares traded) and then divided by the total shares traded for the day. Also included are standard deviation bands.
 
## Syntax
OrderFlowVWAP(VWAPResolution resolution, TradingHours tradingHoursInstance, VWAPStandardDeviations numStandardDeviations, double sD1Multiplier, double sD2Multiplier, double sD3Multiplier)
OrderFlowVWAP(ISeries\<double\> input, VWAPResolution resolution, TradingHours tradingHoursInstance, VWAPStandardDeviations numStandardDeviations, double sD1Multiplier, double sD2Multiplier, double sD3Multiplier)
 
Returns the VWAP value
OrderFlowVWAP(VWAPResolution resolution, TradingHours tradingHoursInstance, VWAPStandardDeviations numStandardDeviations, double sD1Multiplier, double sD2Multiplier, double sD3Multiplier).VWAP\[int barsAgo]
OrderFlowVWAP(ISeries\<double\> input, VWAPResolution resolution, TradingHours tradingHoursInstance, VWAPStandardDeviations numStandardDeviations, double sD1Multiplier, double sD2Multiplier, double sD3Multiplier).VWAP\[int barsAgo]
 
Returns the StdDev1Upper value
OrderFlowVWAP(VWAPResolution resolution, TradingHours tradingHoursInstance, VWAPStandardDeviations numStandardDeviations, double sD1Multiplier, double sD2Multiplier, double sD3Multiplier).StdDev1Upper\[int barsAgo]
OrderFlowVWAP(ISeries\<double\> input, VWAPResolution resolution, TradingHours tradingHoursInstance, VWAPStandardDeviations numStandardDeviations, double sD1Multiplier, double sD2Multiplier, double sD3Multiplier).StdDev1Upper\[int barsAgo]
 
Returns the StdDev1Lower value
OrderFlowVWAP(VWAPResolution resolution, TradingHours tradingHoursInstance, VWAPStandardDeviations numStandardDeviations, double sD1Multiplier, double sD2Multiplier, double sD3Multiplier).StdDev1Lower\[int barsAgo]
OrderFlowVWAP(ISeries\<double\> input, VWAPResolution resolution, TradingHours tradingHoursInstance, VWAPStandardDeviations numStandardDeviations, double sD1Multiplier, double sD2Multiplier, double sD3Multiplier).StdDev1Lower\[int barsAgo]
 
Returns the StdDev2Upper value
OrderFlowVWAP(VWAPResolution resolution, TradingHours tradingHoursInstance, VWAPStandardDeviations numStandardDeviations, double sD1Multiplier, double sD2Multiplier, double sD3Multiplier).StdDev2Upper\[int barsAgo]
OrderFlowVWAP(ISeries\<double\> input, VWAPResolution resolution, TradingHours tradingHoursInstance, VWAPStandardDeviations numStandardDeviations, double sD1Multiplier, double sD2Multiplier, double sD3Multiplier).StdDev2Upper\[int barsAgo]
 
Returns the StdDev2Lower value
OrderFlowVWAP(VWAPResolution resolution, TradingHours tradingHoursInstance, VWAPStandardDeviations numStandardDeviations, double sD1Multiplier, double sD2Multiplier, double sD3Multiplier).StdDev2Lower\[int barsAgo]
OrderFlowVWAP(ISeries\<double\> input, VWAPResolution resolution, TradingHours tradingHoursInstance, VWAPStandardDeviations numStandardDeviations, double sD1Multiplier, double sD2Multiplier, double sD3Multiplier).StdDev2Lower\[int barsAgo]
 
Returns the StdDev3Upper value
OrderFlowVWAP(VWAPResolution resolution, TradingHours tradingHoursInstance, VWAPStandardDeviations numStandardDeviations, double sD1Multiplier, double sD2Multiplier, double sD3Multiplier).StdDev3Upper\[int barsAgo]
OrderFlowVWAP(ISeries\<double\> input, VWAPResolution resolution, TradingHours tradingHoursInstance, VWAPStandardDeviations numStandardDeviations, double sD1Multiplier, double sD2Multiplier, double sD3Multiplier).StdDev3Upper\[int barsAgo]
 
Returns the StdDev3Lower value
OrderFlowVWAP(VWAPResolution resolution, TradingHours tradingHoursInstance, VWAPStandardDeviations numStandardDeviations, double sD1Multiplier, double sD2Multiplier, double sD3Multiplier).StdDev3Lower\[int barsAgo]
OrderFlowVWAP(ISeries\<double\> input, VWAPResolution resolution, TradingHours tradingHoursInstance, VWAPStandardDeviations numStandardDeviations, double sD1Multiplier, double sD2Multiplier, double sD3Multiplier).StdDev3Lower\[int barsAgo]

## Return Value
double; Accessing this method via an index value \[int barsAgo] returns the indicator value of the referenced bar.

## Parameters

| input | Indicator source data ([?](valid_input_data_for_indicator-1.md)) |
| --- | --- |
| resolution | The data the indicator will run off of: Standard Tick |
| tradingHoursInstance | The trading hour template that will indicate when the VWAP resets |
| numStandardDeviations | The number of standard deviations of the VWAP |
| sD1Multiplier | The multiplier for the first standard deviation |
| sD2Multiplier | The multiplier for the second standard deviation |
| sD3Multiplier | The multiplier for the third standard deviation |
 
## 
## Examples

| ns |
| --- |
| // A 1 tick data series must be added to the OnStateChange() if using a Tick Resolution (our second example call below in OnBarUpdate()) else if (State \=\= State.Configure) {  AddDataSeries(Data.BarsPeriodType.Tick, 1); }   // OnBarUpdate() logic if (BarsInProgress \=\= 0) { // Prints the VWAP value using a standard resolution off of RTH trading hours double VWAPValue \= OrderFlowVWAP(VWAPResolution.Standard, TradingHours.String2TradingHours("CME US Index Futures RTH"), VWAPStandardDeviations.Three, 1, 2, 3).VWAP\[0]; Print("The current VWAP with a standard resolution on CME US Index Futures RTH is " \+ VWAPValue.ToString());   // Prints the first upper standard deviation value using a tick resolution off of trading hours of the Data Series double VWAPStdDevUp1 \= OrderFlowVWAP(VWAPResolution.Tick, Bars.TradingHours, VWAPStandardDeviations.Three, 1, 2, 3).StdDev1Upper\[0]; Print("The current VWAP with a tick resolution on " \+ Bars.TradingHours.ToString() \+ " is " \+ VWAPStdDevUp1\.ToString()); } else if (BarsInProgress \=\= 1) { // We have to update the secondary tick series of the cached indicator using Tick Resolution to make sure the values we get in BarsInProgress \=\= 0 are in sync OrderFlowVWAP(BarsArray\[0], VWAPResolution.Tick, BarsArray\[0].TradingHours, VWAPStandardDeviations.Three, 1, 2, 3).Update(OrderFlowVWAP(BarsArray\[0], VWAPResolution.Tick, BarsArray\[0].TradingHours, VWAPStandardDeviations.Three, 1, 2, 3).BarsArray\[1].Count \- 1, 1); } |
 

| Notes:  1\. Referencing multiple OrderFlowVWAP's with different ResetInterval’s in a single NinjaScript Indicator / Strategy is not supported by default. Please contact [\[email protected]](/cdn-cgi/l/email-protection#8bfbe7eaffede4f9e6f8fefbfbe4f9ffcbe5e2e5e1eafff9eaefeef9a5e8e4e6) for a workaround. 2\. Referencing OrderFlowVWAP in a NinjaScript indicator or strategy which runs on either Calcuate.OnEachTick or .OnPriceChange, historical data is needed for accurate calculations. |
| --- |
## 
