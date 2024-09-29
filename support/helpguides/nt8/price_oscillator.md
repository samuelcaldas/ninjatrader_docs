


NinjaScript \> Language Reference \> Common \> System Indicator Methods \> Price Oscillator






















Price Oscillator







| \<\< [Click to Display Table of Contents](price_oscillator.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [System Indicator Methods](indicators.md) \> Price Oscillator | [Previous page](polarized_fractal_efficiency_p.md) [Return to chapter overview](indicators.md) [Next page](prior_day_ohlc.md) |
| --- | --- |











## Description


The Price Oscillator is an indicator based on the difference between two [moving averages](moving_average_-_exponential_e.md), and is expressed as either a percentage or in absolute terms.


 


... Courtesy of [StockCharts](http://stockcharts.com/education/IndicatorAnalysis/indic_priceOscillator.md)


 


 


## Syntax


PriceOscillator(int fast, int slow, int smooth)  

PriceOscillator(ISeries\<double\> input, int fast, int slow, int smooth)


 


Returns default value  

PriceOscillator(int fast, int slow, int smooth)\[int barsAgo]  

PriceOscillator(ISeries\<double\> input, int fast, int slow, int smooth)\[int barsAgo]


 


 


## Return Value


double; Accessing this method via an index value \[int barsAgo] returns the indicator value of the referenced bar.


 


 


## Parameters




| fast | The number of bars to calculate the fast [EMA](moving_average_-_exponential_e.md) |
| --- | --- |
| input | Indicator source data ([?](valid_input_data_for_indicator.md)) |
| slow | The number of bars to calculate the slow [EMA](moving_average_-_exponential_e.md) |
| smooth | The number of bars to calculate the [EMA](moving_average_-_exponential_e.md) signal line |



 


 


## Example




| ns |
| --- |
| // Prints the current value of a 20 period PriceOscillator using default price type double value \= PriceOscillator(12, 26, 9)\[0]; Print("The current PriceOscillator value is " \+ value.ToString()); |



 


 


## Source Code


You can view this indicator method source code by selecting the menu New \> NinjaScript Editor \> Indicators within the NinjaTrader Control Center window.








