
NinjaScript > Language Reference > Common > System Indicator Methods > Moving Average - Variable (VMA)

Moving Average - Variable (VMA)

| << [Click to Display Table of Contents](moving_average_-_variable_vma.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [System Indicator Methods](indicators-1.md) > Moving Average - Variable (VMA) | [Previous page](moving_average_-_triple_expon2-1.md) [Return to chapter overview](indicators-1.md) [Next page](moving_average_-_volume_weight-1.md) |
| --- | --- |
## Description
A Variable Moving Average is an exponential moving average that automatically adjusts its smoothing percentage based on market volatility. Giving more weight to the current data increases sensitivity thus making it a better signal indicator for short and long term markets.

## Syntax
VMA(int period, int volatilityPeriod)  

VMA(ISeries<double> input, int period, int volatilityPeriod)
 
Returns default value  

VMA(int period, int volatilityPeriod)[int barsAgo]  

VMA(ISeries<double> input, int period, int volatilityPeriod)[int barsAgo]

## Return Value
double; Accessing this method via an index value [int barsAgo] returns the indicator value of the referenced bar.

## Parameters

| input | Indicator source data ([?](valid_input_data_for_indicator-1.md)) |
| --- | --- |
| period | Number of bars used in the calculation |
| volatilityPeriod | The number of bars used to calculate the [CMO](chande_momentum_oscillator_cmo-1.md) based volatility index |
 
## 
## Examples

| ns |
| --- |
| // OnBarUpdate method of a strategy protected override void OnBarUpdate() {    // Print out the VMA value of lows 3 bars ago for fun    double value = VMA(Low, 9, 9)[3];    Print("The value is " + value.ToString());      // Go long if price closes above the current VMA value    if (Close[0] > VMA(9, 9)[0])        EnterLong(); } |

## Source Code
You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.
