
NinjaScript > Language Reference > Common > System Indicator Methods > Chande Momentum Oscillator (CMO)

Chande Momentum Oscillator (CMO)
| << [Click to Display Table of Contents](chande_momentum_oscillator_cmo.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > [System Indicator Methods](indicators.md) > Chande Momentum Oscillator (CMO) | [Previous page](chaikin_volatility.md) [Return to chapter overview](indicators.md) [Next page](choppiness_index.md) |
| --- | --- |
## Description
The Chande Momentum Oscillator was developed by Tushar S. Chande and is described in the 1994 book The New Technical Trader by Tushar S. Chande and Stanley Kroll. This indicator is a modified [RSI](relative_strength_index_rsi.md). Where the RSI divides the upward movement by the net movement (up / (up + down)), the CMO divides the total movement by the net movement ((up - down) / (up + down)). Values under -50 indicate oversold conditions while values over 50 indicate overbought conditions.

## Syntax
CMO(int period)  

CMO(ISeries<double> input, int period)
 
Returns default value  

CMO(int period)[int barsAgo]  

CMO(ISeries<double> input, int period)[int barsAgo]

## Return Value
double; Accessing this method via an index value [int barsAgo] returns the indicator value of the referenced bar.

## Parameters
| input | Indicator source data ([?](valid_input_data_for_indicator.md)) |
| --- | --- |
| period | The number of bars to include in the calculation |

 
## 
## Examples
| ns |
| --- |
| // Prints the current value of a 20 period CMO using default price type double value = CMO(20)[0]; Print("The current CMO value is " + value.ToString());   // Prints the current value of a 20 period CMO using high price type double value = CMO(High, 20)[0]; Print("The current CMO value is " + value.ToString()); |

## Source Code
You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.
