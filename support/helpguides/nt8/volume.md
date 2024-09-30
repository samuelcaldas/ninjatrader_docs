
NinjaScript \> Language Reference \> Common \> System Indicator Methods \> Volume (VOL)
Volume (VOL)

| \<\< [Click to Display Table of Contents](volume.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [System Indicator Methods](indicators.md) \> Volume (VOL) | [Previous page](ultimate_oscillator.md) [Return to chapter overview](indicators.md) [Next page](volume_moving_average_volma.md) |
| --- | --- |

## Description
Volume is simply the number of shares (or contracts) traded during a specified time frame (e.g., hour, day, week, month, etc). The analysis of volume is a basic yet very important element of technical analysis. Volume provides clues as to the intensity of a given price move.
 
... Courtesy of [Market In Out](http://www.marketinout.com/technical_analysis.php?id=114)

## Syntax
VOL()  

VOL(ISeries\<double\> input)
 
Returns default value  

VOL()\[int barsAgo]  

VOL(ISeries\<double\> input)\[int barsAgo]

## Return Value
double; Accessing this method via an index value \[int barsAgo] returns the indicator value of the referenced bar.

## Parameters
| input | Indicator source data ([?](valid_input_data_for_indicator.md)) |
| --- | --- |

## Example
| ns |
| --- |
| // Prints the current value VOL double value \= VOL()\[0]; Print("The current VOL value is " \+ value.ToString()); |

## Source Code
You can view this indicator method source code by selecting the menu New \> NinjaScript Editor \> Indicators within the NinjaTrader Control Center window.
