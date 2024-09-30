
NinjaScript \> Language Reference \> Common \> System Indicator Methods \> Moving Average Ribbon

Moving Average Ribbon

| \<\< [Click to Display Table of Contents](moving_average_ribbon.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [System Indicator Methods](indicators.md) \> Moving Average Ribbon | [Previous page](moving_average_convergence-divergence_macd.md) [Return to chapter overview](indicators.md) [Next page](net_change_display.md) |
| --- | --- |
## Description
The Moving Average Ribbon is a series of incrementing moving averages.
 
## Syntax
MovingAverageribbon(RibbonMAType movingAverage, int basePeriod, int incrementalPeriod)
MovingAverageribbon(ISeries\<double\> input, RibbonMAType movingAverage, int basePeriod, int incrementalPeriod)
 
Returns the MovingAverage1 value (Replace the 1 with the desired moving average you want the value to return)
MovingAverageribbon(RibbonMAType movingAverage, int basePeriod, int incrementalPeriod).MovingAverage1\[int barsAgo]
MovingAverageribbon(ISeries\<double\> input, RibbonMAType movingAverage, int basePeriod, int incrementalPeriod).MovingAverage1\[int barsAgo]
 
## Return Value
double; Accessing this method via an index value \[int barsAgo] returns the indicator value of the referenced bar.
 
## Parameters

| input | Indicator source data ([?](valid_input_data_for_indicator.md)) |
| --- | --- |
| RibbonMAType | Moving average to use for calculations |
| basePeriod | Number of bars used in the calculation for the fastest moving average |
| incrementalPeriod | Number of bars to increase for the calculation in each additional moving average |
 
## 
## Examples

| ns |
| --- |
| // Prints the current value of the 3rd moving average double value \= MovingAverageRibbon(RibbonMAType.Exponential, 10, 10).MovingAverage3\[0]; Print("The current 3rd moving average's value is " \+ value.ToString()); |
