
NinjaScript \> Language Reference \> Common \> System Indicator Methods \> Woodies CCI
Woodies CCI

| \<\< [Click to Display Table of Contents](woodies_cci.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [System Indicator Methods](indicators.md) \> Woodies CCI | [Previous page](wiseman_awesome_oscillator.md) [Return to chapter overview](indicators.md) [Next page](woodies_pivots.md) |
| --- | --- |

## Description
NinjaTrader provides the Woodies CCI indicator. It's implemented as specified by Woodie.
 
## Syntax
WoodiesCCI()  

WoodiesCCI(ISeries\<double\> input)
 
Returns default value  

WoodiesCCI()\[int barsAgo]  

WoodiesCCI(ISeries\<double\> input)\[int barsAgo]
 
Returns turbo value  

WoodiesCCI().Turbo\[int barsAgo]  

WoodiesCCI(ISeries\<double\> input).Turbo\[int barsAgo]
 
Returns histogram bar color  

WoodiesCCI().ZoneBars\[int barsAgo]  

WoodiesCCI(ISeries\<double\> input).ZoneBars\[int barsAgo]
 
Return values representing the chopzone plot color are as follows:
0 \= Negative (default color is red)  

1 \= Positive (default color is blue)  

2 \= Neutral (default color is gray)  

3 \= Last neutral bar (default color is yellow)
 
Returns chopzone value  

WoodiesCCI().ChopZone\[int barsAgo]  

WoodiesCCI(ISeries\<double\> input).ChopZone\[int barsAgo]
 
Return values representing the chopzone plot color are as follows:
 
\-4 \= DarkRed  

\-3 \= LightRed  

\-2 \= DarkOrange  

\-1 \= LightOrange  

0 \= Yellow  

1 \= Lime  

2 \= LightGreen  

3 \= DarkGreen  

4 \= Cyan  

 
Returns sidewinder value  

WoodiesCCI().Sidewinder\[int barsAgo]  

WoodiesCCI(ISeries\<double\> input).Sidewinder\[int barsAgo]  

   

Return values representing the sidewinder plot value are as follows:  

   

\-1 \= Warning  

0 \= Neutral  

1 \= Trending

## Return Value
double; Accessing this method via an index value \[int barsAgo] returns the indicator value of the referenced bar.

## Parameters
| input | Indicator source data ([?](valid_input_data_for_indicator.md)) |
| --- | --- |

## Example
| ns |
| --- |
| // Prints the current value of a 14 period WoodiesCCI using default price type double value \= WoodiesCCI(2, 5, 14, 34, 25, 6, 60, 100, 2\)\[0]; Print("The current WoodiesCCI value is " \+ value.ToString());   // Prints the current turbo value of a 14 / 6 period WoodiesCCI using default price type double value2 \= WoodiesCCI(2, 5, 14, 34, 25, 6, 60, 100, 2\).Turbo\[0]; Print("The current WoodiesCCI turbo value is " \+ value2\.ToString()); |

 
