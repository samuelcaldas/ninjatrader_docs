
NinjaScript \> Language Reference \> Common \> System Indicator Methods \> Vortex
Vortex

| \<\< [Click to Display Table of Contents](vortex.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [System Indicator Methods](indicators.md) \> Vortex | [Previous page](volume_up_down.md) [Return to chapter overview](indicators.md) [Next page](williams_r.md) |
| --- | --- |

## Description
The Vortex indicator is an oscillator used to identify trends. A bullish signal triggers when the VIPlus line crosses above the VIMinus line. A bearish signal triggers when the VIMinus line crosses above the VIPlus line.
 
## Syntax
Vortex(int period)
Vortex(ISeries\<double\> input, int period)
 
Returns VIPlus value  

Vortex(int period).VIPlus\[int barsAgo]  

Vortex(ISeries\<double\> input, int period).VIPlus\[int barsAgo]
 
Returns VIMinus value  

Vortex(int period).VIMinus\[int barsAgo]  

Vortex(ISeries\<double\> input, int period).VIMinus\[int barsAgo]
 
## Return Value
double; Accessing this method via an index value \[int barsAgo] returns the indicator value of the referenced bar.
 
## Parameters
| input | Indicator source data ([?](valid_input_data_for_indicator.md)) |
| --- | --- |
| period | Number of bars used in the calculation |

 
## 
## Examples
| ns |
| --- |
| // Prints the current VIPlus value of a 14 period Vortex double valueP \= Vortex(14).VIPlus\[0]; Print("The current Vortex VIPlus value is " \+ valueP.ToString());   // Prints the current VIMinus value of a 14 period Vortex double valueM \= Vortex(14).VIMinus\[0]; Print("The current Vortex VIMinusvalue is " \+ valueM.ToString()); |

