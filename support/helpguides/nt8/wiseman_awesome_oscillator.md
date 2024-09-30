
NinjaScript > Language Reference > Common > System Indicator Methods > Wiseman Awesome Oscillator
Wiseman Awesome Oscillator

| << [Click to Display Table of Contents](wiseman_awesome_oscillator.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > [System Indicator Methods](indicators.md) > Wiseman Awesome Oscillator | [Previous page](wiseman_alligator.md) [Return to chapter overview](indicators.md) [Next page](woodies_cci.md) |
| --- | --- |

## Description
The Wiseman Awesome Oscillator is a momentum indicator to identify trends and reversals. This indicator was provided by Profitunity: [http://www.profitunity.com](http://www.profitunity.com/)
 
## Syntax
WisemanAwesomeOscillator()
WisemanAwesomeOscillator(ISeries<double> input)
 
## Return Value
double; Accessing this method via an index value [int barsAgo] returns the indicator value of the referenced bar.
 
## Parameters
| input | Indicator source data ([?](valid_input_data_for_indicator.md)) |
| --- | --- |

 
## 
## Examples
| ns |
| --- |
| // Prints the current value of the Wiseman Awesome Oscillator double value = WisemanAwesomeOscillator()[0]; Print("The current Wiseman Awesome Oscillator value is " + value.ToString()); |

