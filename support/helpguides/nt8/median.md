
NinjaScript > Language Reference > Common > ISeries<T> > PriceSeries<double> > Median

Median

| << [Click to Display Table of Contents](median.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > [ISeries<T>](iseriest.md) > [PriceSeries<double>](priceseries.md) > Median | [Previous page](lows.md) [Return to chapter overview](priceseries.md) [Next page](medians.md) |
| --- | --- |
## Definition
A collection of historical bar median prices. Median price = (High + Low) / 2.
 
## Property Value
An ISeries<double> type object. Accessing this property via an index value [int barsAgo] returns a double value representing the price of the referenced bar.
## 
## Syntax
Median  

Median[int barsAgo]
## 
## 
## Examples

| ns |
| --- |
| // Current bar median price double barMedianPrice = Median[0];   // Median price of 10 bars ago double barMedianPrice = Median[10];   // Current bar value of a 20 period exponential moving average of median prices double value = EMA(Median, 20)[0]; |
