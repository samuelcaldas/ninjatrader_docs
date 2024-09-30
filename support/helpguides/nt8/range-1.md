
NinjaScript > Language Reference > Common > System Indicator Methods > Range
Range
| << [Click to Display Table of Contents](range.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [System Indicator Methods](indicators-1.md) > Range | [Previous page](psychological_line-1.md) [Return to chapter overview](indicators-1.md) [Next page](range_indicator_rind-1.md) |
| --- | --- |
## Description
Returns the range of a bar. 

## Syntax
Range()  

Range(ISeries<double> input)
 
Returns default value  

Range()[int barsAgo]  

Range(ISeries<double> input)[int barsAgo]

## Return Value
double; Accessing this method via an index value [int barsAgo] returns the indicator value of the referenced bar.

## Parameters
| input | Indicator source data ([?](valid_input_data_for_indicator-1.md)) |
| --- | --- |
| period | Number of bars used in the calculation |

## Examples
| ns |
| --- |
| // Prints the range of the current bar double value = Range()[0]; Print("The current bar's range is " + value.ToString());   // Prints the 20 period simple moving average of range double value = SMA(Range(), 20)[0]; Print("The 20 period average of range is " + value.ToString()); |

 
## 
## Source Code
You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.
