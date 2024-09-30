
NinjaScript > Language Reference > Common > ISeries<T> > PriceSeries<double> > Low

Low

| << [Click to Display Table of Contents](low.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [ISeries<T>](iseriest-1.md) > [PriceSeries<double>](priceseries-1.md) > Low | [Previous page](inputs-1.md) [Return to chapter overview](priceseries-1.md) [Next page](lows-1.md) |
| --- | --- |
## Definition
A collection of historical bar low prices.
 
## Property Value
An ISeries<double> type object. Accessing this property via an index value [int barsAgo] returns a double value representing the price of the referenced bar.
 
## Syntax
Low  

Low[int barsAgo]
 
## 
## Examples

| ns |
| --- |
| // Current bar low price double barLowPrice = Low[0];   // Low price of 10 bars ago double barLowPrice = Low[10];   // Current bar value of a 20 period exponential moving average of low prices double value = EMA(Low, 20)[0]; |
 
