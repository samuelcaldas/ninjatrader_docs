
NinjaScript > Language Reference > Common > System Indicator Methods > Darvas

Darvas
| << [Click to Display Table of Contents](darvas.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [System Indicator Methods](indicators-1.md) > Darvas | [Previous page](current_day_ohl-1.md) [Return to chapter overview](indicators-1.md) [Next page](directional_movement_dm-1.md) |
| --- | --- |
## Description
A trading strategy that was developed in 1956 by former ballroom dancer Nicolas Darvas.  Darvas' trading technique involved buying into stocks that were trading at new 52-week highs with correspondingly high volumes.
 
... Courtesy of [Investopedia](http://www.investopedia.com/terms/d/darvasboxtheory.asp)

## Syntax
Darvas()
Darvas(ISeries<double> input)
 
Returns the upper value
Darvas().Upper[int barsAgo]
Darvas(ISeries<double> input).Upper[int barsAgo]
 
Returns the lower value
Darvas().Lower[int barsAgo]
Darvas(ISeries<double> input).Lower[int barsAgo]

## Return Value
double; Accessing this method via an index value [int barsAgo] returns the indicator value of the referenced bar.

## Parameters
| input | Indicator source data ([?](valid_input_data_for_indicator-1.md)) |
| --- | --- |

 
## 
## Example
| ns |
| --- |
| // Prints the current upper Darvas value double value = Darvas().Upper[0]; Print("The current upper Darvas value is " + value.ToString()); |

## Source Code
You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.
