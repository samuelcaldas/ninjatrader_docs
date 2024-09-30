
NinjaScript > Language Reference > Common > System Indicator Methods > Money Flow Index (MFI)
Money Flow Index (MFI)
| << [Click to Display Table of Contents](money_flow_index_mfi.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [System Indicator Methods](indicators-1.md) > Money Flow Index (MFI) | [Previous page](momentum-1.md) [Return to chapter overview](indicators-1.md) [Next page](money_flow_oscillator-1.md) |
| --- | --- |
## Description
The Money Flow Index (MFI) is a momentum indicator that is similar to the Relative Strength Index (RSI) in both interpretation and calculation. However, MFI is a more rigid indicator in that it is volume-weighted, and is therefore a good measure of the strength of money flowing in and out of a security.
 
... Courtesy of [StockCharts](http://stockcharts.com/education/IndicatorAnalysis/indic_MFI.md)

## Syntax
MFI(int period)  

MFI(ISeries<double> input, int period)
 
Returns default value  

MFI(int period)[int barsAgo]  

MFI(ISeries<double> input, int period)[int barsAgo] 

## Return Value
double; Accessing this method via an index value [int barsAgo] returns the indicator value of the referenced bar.

## Parameters
| input | Indicator source data ([?](valid_input_data_for_indicator-1.md)) |
| --- | --- |
| period | Number of bars used in the calculation |

 
## 
## Example
| ns |
| --- |
| // Prints the current value of a 20 period MFI using default price type double value = MFI(20)[0]; Print("The current MFI value is " + value.ToString()); |

## Source Code
You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.
