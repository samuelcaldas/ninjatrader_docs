
NinjaScript \> Language Reference \> Common \> System Indicator Methods \> ZigZag
ZigZag

| \<\< [Click to Display Table of Contents](zigzag.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [System Indicator Methods](indicators-1.md) \> ZigZag | [Previous page](woodies_pivots-1.md) [Return to chapter overview](indicators-1.md) [Next page](tradinghours-1.md) |
| --- | --- |

## Description
The ZigZag indicator highlights trends based on user defined threshold values and helps filtering the noise in price charts, it's not a classical indicator but more a reactive filter showing extreme price points. In processing it's calculations it can update it's current direction and price extreme point based on newly incoming data, the current developing leg should be thought of temporary until a new leg in opposite direction has been set.
 
You can access methods within this indicator to determine the number of bars ago a zigzag high or low point occurred or the current zigzag value, it is only meaningful to work with in Calculate.OnBarClose mode for the [Calculate](calculate-1.md) property.

## Syntax \- Bars Ago
High Bar  

ZigZag(DeviationType deviationType, double deviationValue, bool useHighLow).HighBar(int barsAgo, int instance, int lookBackPeriod)  

ZigZag(ISeries\<double\> input, DeviationType deviationType, double deviationValue, bool useHighLow).HighBar(int barsAgo, int instance, int lookBackPeriod)  

   

Low Bar  

ZigZag(DeviationType deviationType, double deviationValue, bool useHighLow).LowBar(int barsAgo, int instance, int lookBackPeriod)  

ZigZag(ISeries\<double\> input, DeviationType deviationType, double deviationValue, bool useHighLow).LowBar(int barsAgo, int instance, int lookBackPeriod)
 
## Return Value
An int value representing the number of bars ago. Returns a value of \-1 if a swing point is not found within the look back period.

## Syntax \- Value
| High Value ZigZag(DeviationType deviationType, double deviationValue, bool useHighLow).ZigZagHigh\[int barsAgo] ZigZag(ISeries\<double\> input, DeviationType deviationType, double deviationValue, bool useHighLow).ZigZagHigh\[int barsAgo]   Low Value ZigZag(DeviationType deviationType, double deviationValue, bool useHighLow).ZigZagLow\[int barsAgo] ZigZag(ISeries\<double\> input, DeviationType deviationType, double deviationValue, bool useHighLow).ZigZagLow\[int barsAgo] |
| --- |

 
## Return Value
double; Accessing this method via an index value \[int barsAgo] returns the indicator value of the referenced bar.
\* A return value of 0 (zero) indicates that a zigzag high or low has not yet formed.

## Parameters
| barsAgo | The number of bars ago that serves as the starting bar and works backwards |
| --- | --- |
| deviationType | Possible values are: DeviationType.Points DeviationType.Percent |
| deviationValue | The deviation value |
| input | Indicator source data ([?](valid_input_data_for_indicator-1.md)) |
| instance | The occurrence to check for (1 is the most recent, 2 is the 2nd most recent etc...) |
| lookBackPeriod | Number of bars to look back to check for the test condition. Test is evaluated on the current bar and the bars in the look back period. |
| useHighLow | When true, both High and Low price series are used. When false, the default input is used for both highs and lows. |

## Example
| ns |
| --- |
| // Prints the high price of the most recent zig zag high Print("The high of the zigzag bar is " \+ High\[Math.Max(0, ZigZag(DeviationType.Points, 0\.5, false).HighBar(0, 1, 100))]); |

## Source Code
You can view this indicator method source code by selecting the menu New \> NinjaScript Editor \> Indicators within the NinjaTrader Control Center window.
