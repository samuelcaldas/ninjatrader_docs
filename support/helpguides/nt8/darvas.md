


NinjaScript \> Language Reference \> Common \> System Indicator Methods \> Darvas






















Darvas







| \<\< [Click to Display Table of Contents](darvas.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [System Indicator Methods](indicators.md) \> Darvas | [Previous page](current_day_ohl.md) [Return to chapter overview](indicators.md) [Next page](directional_movement_dm.md) |
| --- | --- |











## Description


A trading strategy that was developed in 1956 by former ballroom dancer Nicolas Darvas.  Darvas' trading technique involved buying into stocks that were trading at new 52\-week highs with correspondingly high volumes.


 


... Courtesy of [Investopedia](http://www.investopedia.com/terms/d/darvasboxtheory.asp)


 


 


## Syntax


Darvas()


Darvas(ISeries\<double\> input)


 


Returns the upper value


Darvas().Upper\[int barsAgo]


Darvas(ISeries\<double\> input).Upper\[int barsAgo]


 


Returns the lower value


Darvas().Lower\[int barsAgo]


Darvas(ISeries\<double\> input).Lower\[int barsAgo]


 


 


## Return Value


double; Accessing this method via an index value \[int barsAgo] returns the indicator value of the referenced bar.


 


 


## Parameters




| input | Indicator source data ([?](valid_input_data_for_indicator.md)) |
| --- | --- |



 


## 


## Example




| ns |
| --- |
| // Prints the current upper Darvas value double value \= Darvas().Upper\[0]; Print("The current upper Darvas value is " \+ value.ToString()); |



 


 


## Source Code


You can view this indicator method source code by selecting the menu New \> NinjaScript Editor \> Indicators within the NinjaTrader Control Center window.








