
NinjaScript > Language Reference > Common > System Indicator Methods > Volume Oscillator
Volume Oscillator

| << [Click to Display Table of Contents](volume_oscillator.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > [System Indicator Methods](indicators.md) > Volume Oscillator | [Previous page](volume_moving_average_volma.md) [Return to chapter overview](indicators.md) [Next page](volume_rate_of_change_vroc.md) |
| --- | --- |

## Description
The Volume Oscillator uses the difference between two [moving averages](moving_average_-_simple_sma.md) of [volume](volume.md) to determine if the trend is increasing or decreasing. A value above zero indicates that the shorter term volume moving average has risen above the longer term volume moving average. This indicates that the shorter term trend is higher than the longer term trend. Rising prices with with increased short term volume is bullish as is falling prices with decreased volume. Falling prices with increased volume or rising prices with decreased volume indicate market weakness.

## Syntax
VolumeOscillator(int fast, int slow)  

VolumeOscillator(ISeries<double> input, int fast, int slow)
 
Returns default value  

VolumeOscillator(int fast, int slow)[int barsAgo]  

VolumeOscillator(ISeries<double> input, int fast, int slow)[int barsAgo]

## Return Value
double; Accessing this method via an index value [int barsAgo] returns the indicator value of the referenced bar.

## Parameters
| fast | The number of bars to include in the short term moving average |
| --- | --- |
| input | Indicator source data ([?](valid_input_data_for_indicator.md)) |
| slow | The number of bars to include in the long term moving average |

 
## 
## Example
| ns |
| --- |
| // Prints the current value of a Volume Oscillator double value = VolumeOscillator(12, 26)[0]; Print("The current Volume Oscillator value is " + value.ToString()); |

## Source Code
You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.
