﻿
NinjaScript > Language Reference > Common > System Indicator Methods > McClellan Oscillator

McClellan Oscillator

| << [Click to Display Table of Contents](mcclellan_oscillator.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > [System Indicator Methods](indicators.md) > McClellan Oscillator | [Previous page](maximum_max.md) [Return to chapter overview](indicators.md) [Next page](minimum_min.md) |
| --- | --- |
## Description
McClellan Oscillator is the difference between two exponential moving averages of the NYSE advance decline spread. This indicator require ADV and DECL index data.
 
## Syntax
## McClellanOscillator(int fastPeriod, int slowPeriod)
McClellanOsillator(ISeries<double> input, int fastPeriod, int slowPeriod)
 
## Return Value
double; Accessing this method via an index value [int barsAgo] returns the indicator value of the referenced bar.
 
## Parameters

| input | Indicator source data ([?](valid_input_data_for_indicator.md)) |
| --- | --- |
| fastPeriod | Number of bars used in the fast moving average calculation |
| slowPeriod | Number of bars used in the slow moving average calculation |
 
## 
## Examples

| ns |
| --- |
| // An ADV and DECL data series must be added to OnStateChange() else if (State == State.Configure) {  AddDataSeries("^ADV");  AddDataSeries("^DECL"); }   // Prints the current value of the McClellan Oscillator with a 19 fast period moving average & 39 slow period double value = McClellanOscillator(19, 39)[0]; Print("The current McClellan Oscillator value is " + value.ToString()); |
