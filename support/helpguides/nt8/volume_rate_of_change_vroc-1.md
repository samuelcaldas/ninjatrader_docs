
NinjaScript > Language Reference > Common > System Indicator Methods > Volume Rate of Change (VROC)
Volume Rate of Change (VROC)

| << [Click to Display Table of Contents](volume_rate_of_change_vroc.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [System Indicator Methods](indicators-1.md) > Volume Rate of Change (VROC) | [Previous page](volume_oscillator-1.md) [Return to chapter overview](indicators-1.md) [Next page](volume_up_down-1.md) |
| --- | --- |

## Description
Volume Rate of Change is identical to [Price Rate Of Change (ROC)](rate_of_change_roc-1.md) indicator except that it uses volume instead of price.

## Syntax
VROC(int period, int smooth)  

VROC(ISeries<double> input, int period, int smooth)
 
Returns default value  

VROC(int period, int smooth)[int barsAgo]  

VROC(ISeries<double> input, int period, int smooth)[int barsAgo]

## Return Value
double; Accessing this method via an index value [int barsAgo] returns the indicator value of the referenced bar.

## Parameters
| input | Indicator source data ([?](valid_input_data_for_indicator-1.md)) |
| --- | --- |
| period | Number of bars used in the calculation |
| smooth | The number of bars for smoothing the signal |

 
## 
## Example
| ns |
| --- |
| // Prints the current value of VROC double value = VROC(13, 3)[0]; Print("The current VROC value is " + value.ToString()); |

## Source Code
You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.
