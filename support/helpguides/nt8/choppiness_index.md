﻿
NinjaScript > Language Reference > Common > System Indicator Methods > Choppiness Index
Choppiness Index
| << [Click to Display Table of Contents](choppiness_index.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > [System Indicator Methods](indicators.md) > Choppiness Index | [Previous page](chande_momentum_oscillator_cmo.md) [Return to chapter overview](indicators.md) [Next page](commitment-of-traders-(cot).md) |
| --- | --- |
## Description
The Choppiness Index is designed to determine if the market is choppy (trading sideways) or not choppy (trading within a trend in either direction)
 
## Syntax
ChoppinessIndex(int period)
ChoppinessIndex(ISeries<double> input, int period)
 
## Return Value
double; Accessing this method via an index value [int barsAgo] returns the indicator value of the referenced bar.
 
## Parameters
| input | Indicator source data ([?](valid_input_data_for_indicator.md)) |
| --- | --- |
| period | Number of bars used in the calculation |
 
## 
## Examples
| ns |
| --- |
| // Prints the current value of a 14 period Choppiness Index double value = ChoppinessIndex(14)[0]; Print("The current Choppiness Index value is " + value.ToString()); |

