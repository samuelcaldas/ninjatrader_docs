
NinjaScript > Language Reference > Common > System Indicator Methods > KeyReversalUp

KeyReversalUp

| << [Click to Display Table of Contents](keyreversalup.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [System Indicator Methods](indicators-1.md) > KeyReversalUp | [Previous page](keyreversaldown-1.md) [Return to chapter overview](indicators-1.md) [Next page](linear_regression-1.md) |
| --- | --- |
## Description
Returns a value of 1 when the current close is greater than the prior close and the current low has penetrated the lowest low of the last n bars.

## Syntax
KeyReversalUp(int period)  

KeyReversalUp(ISeries<double> input, int period)
 
Returns default value  

KeyReversalUp(int period)[int barsAgo]  

KeyReversalUp(ISeries<double> input, int period)[int barsAgo]

## Return Value
double; Accessing this method via an index value [int barsAgo] returns the indicator value of the referenced bar.

## Parameters

| input | Indicator source data ([?](valid_input_data_for_indicator-1.md)) |
| --- | --- |
| period | Number of bars used in the calculation |
 
## 
## Example

| ns |
| --- |
| // If we get a reversal over the past 10 bars go long if (KeyReversalUp(10)[0] == 1)    EnterLong(); |

## Source Code
You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.
